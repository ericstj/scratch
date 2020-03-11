using System;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.Build.Evaluation;
using Microsoft.Build.Locator;

namespace projectCleanup
{
    class Program
    {

        static void Main(string[] args)
        {
            MSBuildLocator.RegisterMSBuildPath(Environment.ExpandEnvironmentVariables(@"%ProgramFiles%\dotnet\sdk\3.1.100"));
            UpdateFiles();
        }

        // This must be a non-inlined method run after RegisterMSBuildPath so that the loader is hooked
        // before this method is JIT'ed attempting to load MSBuild assemblies.
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void UpdateFiles()
        {   
            foreach(var projectFile in Directory.EnumerateFiles(@"C:\src\dotnet\runtime\src\libraries\", "*.csproj", SearchOption.AllDirectories))
            {
                Console.WriteLine(projectFile);
                Project project = new Project(projectFile);

                var assemblyNameProperty = project.GetProperty("AssemblyName");

                if (assemblyNameProperty != null &&
                    !assemblyNameProperty.IsImported &&
                    assemblyNameProperty.UnevaluatedValue == Path.GetFileNameWithoutExtension(projectFile))
                {
                    project.RemoveProperty(assemblyNameProperty);
                }

                if (project.IsDirty)
                {
                    project.Save();
                }
            }
        }
    }
}
