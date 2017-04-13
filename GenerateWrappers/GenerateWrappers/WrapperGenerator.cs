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

     
        [TestCase("File")]
        [TestCase("Directory")]
        public void GenerateWrappersForStaticsInSystemIO(string name)
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
            var mydoc = ExtractXmlDefinitions();
            Assert.That(mydoc, Is.Not.Null);
            var searchterm = $"M:System.IO.{name}.";
           
            ProcessMethods(name, "System.IO",mydoc, searchterm, outputInterface, outputClass);
            Assert.That(outputInterface.Count, Is.GreaterThan(6));
            Assert.That(outputClass.Count, Is.GreaterThan(6));
            WriteOutput(name, outputInterface, outputClass);
        }


        [Explicit]
        [TestCase("Console")]
        public void GenerateWrappersForStaticsInSystem(string name)
        {
            var outputInterface = new List<string> { $"// WrapThat library for System.{name}", "  ", "namespace WrapThat.SystemBase {", " ", $"public partial interface I{name}", "{" };
            var outputClass = new List<string>
            {
                $"// WrapThat library for System.{name}  (Namespace is SystemBase in order to avoid conflicts with using System)",
                "  ",
                "namespace WrapThat.SystemBase {",
                " ",
                $"public partial class {name}: I{name} ",
                "{"
            };
            var mydoc = ExtractXmlDefinitions();
            Assert.That(mydoc, Is.Not.Null);
            var searchterm = $"M:System.{name}.";

            ProcessMethods(name, "System", mydoc, searchterm, outputInterface, outputClass);
            Assert.That(outputInterface.Count, Is.GreaterThan(6));
            Assert.That(outputClass.Count, Is.GreaterThan(6));
            WriteOutput(name, outputInterface, outputClass);
        }



        private static void WriteOutput(string name, ICollection<string> outputInterface, ICollection<string> outputClass)
        {
            outputInterface.Add("}}");
            outputClass.Add("}}");
            var path = TestContext.CurrentContext.TestDirectory;
            var pathI = Path.Combine(path, @"..\..\..\Wrappers", $"{name}Interface.g.cs");
            var pathC = Path.Combine(path, @"..\..\..\Wrappers", $"{name}.g.cs");
            File.WriteAllLines(pathI, outputInterface);
            File.WriteAllLines(pathC, outputClass);
        }

        private static doc ExtractXmlDefinitions()
        {
            var pathIS = @"C:\Windows\Microsoft.NET\Framework\v2.0.50727\en\mscorlib.xml";
            var serializer = new XmlSerializer(typeof(doc));
            var mydoc = (doc) serializer.Deserialize(new XmlTextReader(pathIS));
            return mydoc;
        }

        private static void ProcessMethods(string name, string theNamespace, doc mydoc, string searchterm,  ICollection<string> outputInterface,
            ICollection<string> outputClass)
        {
            var start = searchterm.Length;
            foreach (var member in mydoc.members.Where(o => o.name.Contains(searchterm)))
            {
                var hasparams = member.name.IndexOf("(");
                var def = hasparams >= 0
                    ? member.name.Substring(start, hasparams - start)
                    : member.name.Substring(start);
                var returns = ExtractReturn(member);
                var parameterList = "(";
                var callList = "(";
                if (hasparams >= 0)
                {
                    var pt1 = member.name.IndexOf("(") + 1;
                    var pt2 = member.name.IndexOf(")");
                    var ptl = pt2 - pt1;
                    var paramliststring = CreateParameterList(member, pt1, ptl);
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
                var classLine = "public " + returns + def + parameterList + " => " + $"{theNamespace}.{name}." + def +
                                callList + ";";
                outputClass.Add(classLine);
                if (member.name.Contains("CreateDirectory"))
                {
                    Assert.That(def, Does.Not.Contains("("), $"def: {def}");
                    Assert.That(parameterList, Does.Not.Contains("(("), $"def: {parameterList}");
                    Assert.That(returns, Does.Not.Contain("M:"), $"returns: {returns}");
                    Assert.That(callList.StartsWith("("), $"calllist: {callList}");

                }
                if (member.name.Contains("Exists"))
                {
                    Assert.That(returns, Is.EqualTo("bool "), $"return type was {returns}");
                }
            }
        }

        private static string ExtractReturn(memberType member)
        {
            string returns = "void ";
            var txt = member.returns?.see?.cref;
            if (txt != null)
                returns = txt.Substring(txt.IndexOf(":") + 1) + " ";
            else
            {
                var first = member.returns?.Text.FirstOrDefault();
                if (first == null)
                    return returns;
                if (first.StartsWith("true") || first.StartsWith("false"))
                    return "bool ";
            }
            return returns;
        }

        private static string CreateParameterList(memberType member, int pt1, int ptl)
        {
            var paramliststring = member.name.Substring(pt1, ptl).Replace("System.String", "string");
            paramliststring =
                paramliststring.Replace("System.Int32", "int")
                    .Replace("System.Int64", "long")
                    .Replace("System.Single", "float")
                    .Replace("System.Char[]", "char[]")
                    .Replace("System.Char", "char")
                    .Replace("System.Object", "object")
                    .Replace("System.Decimal", "decimal")
                    .Replace("System.Double", "double")
                    .Replace("System.Boolean", "bool")
                    .Replace("System.UInt32", "uint")
                    .Replace("System.UInt64", "ulong");
            return paramliststring;
        }
    }
}
