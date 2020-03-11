using Microsoft.Build.Evaluation;
using Microsoft.Build.Locator;
using System;
using System.Runtime.CompilerServices;

namespace testReeval
{
    class Program
    {

        static void Main(string[] args)
        {
            MSBuildLocator.RegisterMSBuildPath(Environment.ExpandEnvironmentVariables(@"%ProgramFiles%\dotnet\sdk\3.1.100"));
            
            TestReeval();
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static void TestReeval()
        {
            Project project = new Project(@"testProject\testProject.csproj");
            writeProps();
            project.SetProperty("PropA", "global");
            project.SetProperty("PropB", "global");
            project.SetProperty("PropC", "global");
            writeProps();
            project.ReevaluateIfNecessary();
            writeProps();


            void writeProps()
            {
                Console.WriteLine($"PropA: {prop("PropA")}    PropB: {prop("PropB")}    PropC: {prop("PropC")}");
            }
            string prop(string propName) => project.GetPropertyValue(propName);
        }
    }
}
