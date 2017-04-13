using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using NUnit.Framework;

namespace GenerateWrappers
{
    public class WrapperGenerator
    {
      
        [Test]
        public void CheckThatMscorlibXmlExist()
        {
            var path = @"C:\Windows\Microsoft.NET\Framework\v2.0.50727\en\mscorlib.xml";
            Assert.That(File.Exists(path));
        }

        [Explicit]
     //   [TestCase("DriveInfo")]
        [TestCase("File")]
        [TestCase("Directory")]
        public void GenerateWrappersForStatics(string name)
        {
            var outputInterface = new List<string> { $"// WrapThat library for System.IO.{name}", "  ", "namespace WrapThat.SystemIO {", " ", $"public partial interface I{name}", "{" };
            var outputClass = new List<string>
            {
                $"// WrapThat library for System.IO.{name}",
                "  ",
                "namespace WrapThat.SystemIO {",
                " ",
                $"public partial class {name}: I{name} ",
                "{"
            };
            var pathIS = @"C:\Windows\Microsoft.NET\Framework\v2.0.50727\en\mscorlib.xml";
            var serializer = new XmlSerializer(typeof(doc));
            var mydoc = (doc)serializer.Deserialize(new XmlTextReader(pathIS));
            Assert.That(mydoc, Is.Not.Null);
            var searchterm = $"M:System.IO.{name}.";
            var start = searchterm.Length;
            foreach (var member in mydoc.members.Where(o => o.name.Contains(searchterm)))
            {
                var hasparams = member.name.IndexOf("(");
                var def = hasparams >= 0 ? member.name.Substring(start, hasparams - start) : member.name.Substring(start);
                string returns = "void ";
                var txt = member.returns?.see?.cref;
                if (txt != null)
                    returns = txt.Substring(txt.IndexOf(":") + 1) + " ";
                var parameterList = "(";
                var callList = "(";
                if (hasparams >= 0)
                {
                    var pt1 = member.name.IndexOf("(") + 1;
                    var pt2 = member.name.IndexOf(")");
                    var ptl = pt2 - pt1;
                    var paramliststring = member.name.Substring(pt1, ptl).Replace("System.String", "string");
                    var paramtypes = paramliststring.Split(',');
                    Assert.That(paramtypes.Length, Is.EqualTo(member.param.Length));

                    int n = 0;
                    foreach (var param in member.param)
                    {
                        Assert.That(param.name, Does.Not.Contains("("), $"param is: {param}");
                        if (n > 0)
                        {
                            parameterList += ",";
                            callList += ",";
                        }
                        parameterList += paramtypes[n] + " " + param.name;
                        callList += param.name;
                        n++;
                    }
                }
                parameterList += ")";
                callList += ")";

                var interfaceLine = returns + def + parameterList + ";";
                outputInterface.Add(interfaceLine);
                var classLine = "public " + returns + def + parameterList + " => " + $"System.IO.{name}." + def +
                                callList + ";";
                outputClass.Add(classLine);
                if (member.name.Contains("CreateDirectory"))
                {
                    Assert.That(def, Does.Not.Contains("("), $"def: {def}");
                    Assert.That(parameterList, Does.Not.Contains("(("), $"def: {parameterList}");
                    Assert.That(returns, Does.Not.Contain("M:"), $"returns: {returns}");
                    Assert.That(callList.StartsWith("("), $"calllist: {callList}");
                }
            }
            Assert.That(outputInterface.Count, Is.GreaterThan(6));
            Assert.That(outputClass.Count, Is.GreaterThan(6));
            outputInterface.Add("}}");
            outputClass.Add("}}");
            var path = TestContext.CurrentContext.TestDirectory;
            var pathI = Path.Combine(path, @"..\..\..\Wrappers", $"{name}Interface.g.cs");
            var pathC = Path.Combine(path, @"..\..\..\Wrappers", $"{name}.g.cs");
            File.WriteAllLines(pathI, outputInterface);
            File.WriteAllLines(pathC, outputClass);

        }
    }
}
