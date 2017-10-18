using System.Text.RegularExpressions;
using System.Xml.Linq;

// Target - The task you want to start. Runs the Default task if not specified.
var target = Argument("Target", "Default");
// Configuration - The build configuration (Debug/Release) to use.
// 1. If command line parameter parameter passed, use that.
// 2. Otherwise if an Environment variable exists, use that.
var configuration = 
    HasArgument("Configuration") ? Argument<string>("Configuration") :
    EnvironmentVariable("Configuration") != null ? EnvironmentVariable("Configuration") : "Release";
// The build number to use in the version number of the built NuGet packages.
// There are multiple ways this value can be passed, this is a common pattern.
// 1. If command line parameter parameter passed, use that.
// 2. Otherwise if running on AppVeyor, get it's build number.
// 3. Otherwise if running on Travis CI, get it's build number.
// 4. Otherwise if an Environment variable exists, use that.
// 5. Otherwise default the build number to 0.
var buildNumber =
    HasArgument("BuildNumber") ? Argument<int>("BuildNumber") :
    AppVeyor.IsRunningOnAppVeyor ? AppVeyor.Environment.Build.Number :
    TravisCI.IsRunningOnTravisCI ? TravisCI.Environment.Build.BuildNumber :
    EnvironmentVariable("BuildNumber") != null ? int.Parse(EnvironmentVariable("BuildNumber")) : 0;
 
// A directory path to an Artifacts directory.
var artifactsDirectory = Directory("./Artifacts");
 
IList<string> GetCoreFrameworks(string csprojFilePath)
{
    return XDocument
        .Load(csprojFilePath)
        .Descendants("TargetFrameworks")
        .First()
        .Value
        .Split(';')
        .Where(x => Regex.IsMatch(x, @"net[^\d]"))
        .ToList();
}

// Deletes the contents of the Artifacts folder if it should contain anything from a previous build.
Task("Clean")
    .Does(() =>
    {
        CleanDirectory(artifactsDirectory);
        DeleteDirectories(GetDirectories("**/bin"), true);
        DeleteDirectories(GetDirectories("**/obj"), true);
    });
 
// Run dotnet restore to restore all package references.
Task("Restore")
    .IsDependentOn("Clean")
    .Does(() =>
    {
        DotNetCoreRestore();
    });
 
// Find all csproj projects and build them using the build configuration specified as an argument.
 Task("Build")
    .IsDependentOn("Restore")
    .Does(() =>
    {
        foreach(var project in GetFiles("./**/*.csproj"))
        {
            Information(project.ToString());
            var settings = new DotNetCoreBuildSettings()
            {
                Configuration = configuration
            };

            if (!IsRunningOnWindows())
            {
                var frameworks = GetCoreFrameworks(project.ToString());
                if (frameworks.Count == 0)
                {
                    Information("Skipping .NET Framework only project " + project.ToString());
                    continue;
                }
                else
                {
                    Information("Skipping .NET Framework, building " + frameworks.First());
                    settings.Framework = frameworks.First();
                }
            }

            DotNetCoreBuild(
                project.GetDirectory().FullPath,
                settings);
        }
    });
 
// Look under a 'Tests' folder and run dotnet test against all of those projects.
// Then drop the XML test results file in the Artifacts folder at the root.
Task("Test")
    .IsDependentOn("Build")
    .Does(() =>
    {
        foreach(var project in GetFiles("./**/*.Tests.csproj"))
        {
            Information(project.ToString());

            var outputFilePath = MakeAbsolute(artifactsDirectory.Path)
                .CombineWithFilePath(project.GetFilenameWithoutExtension());
            var arguments = new ProcessArgumentBuilder()
                .AppendSwitch("-configuration", configuration)
                .AppendSwitchQuoted("-xml", outputFilePath.AppendExtension(".xml").ToString())
                .AppendSwitchQuoted("-html", outputFilePath.AppendExtension(".html").ToString());
            
            if (!IsRunningOnWindows())
            {
                var frameworks = GetCoreFrameworks(project.ToString());
                if (frameworks.Count == 0)
                {
                    Information("Skipping .NET Framework only project " + project.ToString());
                    continue;
                }
                else
                {
                    Information("Skipping .NET Framework, building " + frameworks.First());
                    arguments.AppendSwitch("-framework", frameworks.First());
                }
            }

            DotNetCoreTool(project, "xunit", arguments);
        }
    });
 
// Run dotnet pack to produce NuGet packages from our projects. Versions the package
// using the build number argument on the script which is used as the revision number 
// (Last number in 1.0.0.0). The packages are dropped in the Artifacts directory.
Task("Pack")
    .IsDependentOn("Test")
    .Does(() =>
    {
        var revision = buildNumber.ToString("D4");
        foreach (var project in GetFiles("./Source/**/*.csproj"))
        {
            DotNetCorePack(
                project.GetDirectory().FullPath,
                new DotNetCorePackSettings()
                {
                    Configuration = configuration,
                    OutputDirectory = artifactsDirectory,
                    VersionSuffix = revision
                });
        }
    });
 
// The default task to run if none is explicitly specified. In this case, we want
// to run everything starting from Clean, all the way up to Pack.
Task("Default")
    .IsDependentOn("Pack");
 
// Executes the task specified in the target argument.
RunTarget(target);