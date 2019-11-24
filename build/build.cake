var confiurations = new[]
{
  "Release",
  "SourcePackage"
};
var artifactsDirectory = Directory("../artifacts");
var sourceDirectory = Directory("../src");
var solutionFile = sourceDirectory + File("Contrib.Microsoft.Build.SourcePackage.sln");

Task("Build")
  .IsDependentOn("Clean")
  .Does(() =>
{
  Information($"Building {MakeAbsolute(solutionFile)}");

  foreach (var configuration in cofigurations)
  {
    MSBuild(solutionFile,
            settings => settings.SetConfiguration(configuration)
                                .WithRestore()
                                .WithProperty("PackageOutputPath", MakeAbsolute(artifactsDirectory).FullPath));
  }
});

Task("Clean")
  .Does(() =>
{
  Information($"Cleaning {MakeAbsolute(artifactsDirectory)}");

  if (DirectoryExists(artifactsDirectory))
  {
    DeleteDirectory(artifactsDirectory,
                    new DeleteDirectorySettings
                    {
                      Recursive = true
                    });
  }

  CreateDirectory(artifactsDirectory);
});

var targetArgument = Argument("target", "Build");
RunTarget(targetArgument);
