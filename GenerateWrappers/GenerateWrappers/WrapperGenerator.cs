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


        [Test]
        public void ReflectOnType()
        {
            var dir = typeof(System.IO.Directory).GetMembers(BindingFlags.Static | BindingFlags.Public);
            var findExist = dir.FirstOrDefault(o => o.Name == "Exists");
            Assert.That(findExist, Is.Not.Null);
        }


        [TestCase("File", typeof(File))]
        [TestCase("Directory", typeof(System.IO.Directory))]
        public void GenerateWrappersForStaticsInSystemIO(string name, Type type)
        {
            var methods = type.GetMethods(BindingFlags.Static | BindingFlags.Public).ToList();
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

            ProcessStaticMethods(name, "System.IO", mydoc, searchterm, methods, outputInterface, outputClass);
            Assert.That(outputInterface.Count, Is.GreaterThan(6));
            Assert.That(outputClass.Count, Is.GreaterThan(6));
            WriteOutput(name, outputInterface, outputClass);
        }


        [Explicit]
        [TestCase("Console", typeof(System.Console))]
        public void GenerateWrappersForStaticsInSystem(string name, Type type)
        {
            var methods = type.GetMethods(BindingFlags.Static | BindingFlags.Public).ToList();
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

            ProcessStaticMethods(name, "System", mydoc, searchterm, methods, outputInterface, outputClass);
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
            var mydoc = (doc)serializer.Deserialize(new XmlTextReader(pathIS));
            return mydoc;
        }

        private static void ProcessStaticMethods(string name, string theNamespace, doc mydoc, string searchterm, IEnumerable<MethodInfo> methods, ICollection<string> outputInterface,
            ICollection<string> outputClass)
        {
            var start = searchterm.Length;
            var docMethods = mydoc.members.Where(o => o.name.Contains(searchterm));
            foreach (var member in methods)// mydoc.members.Where(o => o.name.Contains(searchterm)))
            {
                var methodName = member.Name;
                var returns = ExtractReturn(member);
                var parameters = member.GetParameters();
                bool haveDoc = true;
                var docInfo = docMethods.Where(o => o.name == methodName && o.param.Length == parameters.Length).ToList();

                var paramList = BuildParamList(parameters, docInfo, methodName);
                var hasParams = parameters.Length >= 1;
                var parameterList = "";
                var callList = "";
                if (hasParams)
                {
                    parameterList = CreateParameterList(paramList);
                    callList = CreateCallList(paramList);
                }

                var interfaceLine = $"{returns} {methodName}({parameterList});";
                outputInterface.Add(interfaceLine);
                var classLine = $"public {returns} {methodName}({parameterList})  => {theNamespace}.{name}.{methodName}({callList});";
                outputClass.Add(classLine);
                //if (member.name.Contains("CreateDirectory"))
                //{
                //    Assert.That(methodName, Does.Not.Contains("("), $"def: {methodName}");
                //    Assert.That(parameterList, Does.Not.Contains("(("), $"def: {parameterList}");
                //    Assert.That(returns, Does.Not.Contain("M:"), $"returns: {returns}");
                //    Assert.That(callList.StartsWith("("), $"calllist: {callList}");

                //}
                //if (member.name.Contains("Exists"))
                //{
                //    Assert.That(returns, Is.EqualTo("bool"), $"return type was {returns}");
                //}
            }
        }

        private static string CreateCallList(IEnumerable<Parameter> paramList)
        {
            var sb = new StringBuilder();
            int n = 0;
            foreach (var param in paramList)
            {
                if (n > 0)
                    sb.Append(",");
                sb.Append(param.Name);
                n++;
            }
            return sb.ToString();
        }

        private static IEnumerable<Parameter> BuildParamList(IReadOnlyCollection<ParameterInfo> parameters, IReadOnlyCollection<memberType> docInfo, string methodName)
        {
            var list = new List<Parameter>();
            bool haveDoc = true;
            if (docInfo.Count != 1)
            {
                if (!docInfo.Any())
                    haveDoc = false;
                else
                    Assert.Fail($"Found multiple methods ({docInfo.Count} )of name {methodName} with {parameters.Count} parameters");
            }
            foreach (var parameter in parameters)
            {
                var pt = new Parameter { Type = ReplaceSystemTypes(parameter.ParameterType.FullName), Name = parameter.Name };
                list.Add(pt);
            }
            return list;
        }

        private static string ExtractReturn(MethodInfo member)
        {
            var retType = member.ReturnType.FullName;
            return ReplaceSystemTypes(retType);
        }

        private static string CreateParameterList(IEnumerable<Parameter> paramSet)
        {
            var sb = new StringBuilder();
            int n = 0;
            foreach (var param in paramSet)
            {
                if (n > 0)
                    sb.Append(",");
                sb.Append(param.Type);
                sb.Append(" ");
                sb.Append(param.Name);
                n++;
            }
            return sb.ToString();
        }

        private static string ReplaceSystemTypes(string paramliststring)
        {
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
                    .Replace("System.UInt64", "ulong")
                    .Replace("System.Void", "void")
                    .Replace("System.String", "string")
                    .Replace("System.String[]", "string[]");
            return paramliststring;
        }
    }

    public class Parameter
    {
        public string Type { get; set; }
        public string Name { get; set; }
    }
}
