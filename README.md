![](assets/noun_Source Code_996120.png)

# msbuild-Contrib.Microsoft.Build.SourcePackage

> Create *.Source.nupkg*'s! :package: :sparkles:

## Build status

[![](https://img.shields.io/appveyor/ci/dittodhole/msbuild-contrib-microsoft-build-sourcepackage.svg)](https://ci.appveyor.com/project/dittodhole/msbuild-contrib-microsoft-build-sourcepackage)

## Installing

### myget.org

[![](https://img.shields.io/myget/dittodhole/vpre/Contrib.Microsoft.Build.SourcePackage.svg)](https://www.myget.org/feed/dittodhole/package/nuget/Contrib.Microsoft.Build.SourcePackage)

```powershell
PM> Install-Package -Id Contrib.Microsoft.Build.SourcePackage -pre --source https://www.myget.org/F/dittodhole/api/v2
```

### nuget.org

[![](https://img.shields.io/nuget/v/Contrib.Microsoft.Build.SourcePackage.svg)](https://www.nuget.org/packages/Contrib.Microsoft.Build.SourcePackage)

```powershell
PM> Install-Package -Id Contrib.Microsoft.Build.SourcePackage
```

## Configuration

To build the project as a source package, simply use the `SourcePackage` [Configuration](https://docs.microsoft.com/en-us/visualstudio/ide/understanding-build-configurations?view=vs-2019) available in the build options.

## Developing & Building

```cmd
> git clone https://github.com/dittodhole/msbuild-Contrib.Microsoft.Build.SourcePackage.git
> cd msbuild-Contrib.Microsoft.Build.SourcePackage
msbuild-Contrib.Microsoft.Build.SourcePackage> cd build
msbuild-Contrib.Microsoft.Build.SourcePackage/build> build.bat
```

This will create the following artifacts:

- `artifacts/Contrib.Microsoft.Build.SourcePackage.{version}.nupkg`

## License

msbuild-Contrib.Microsoft.Build.SourcePackage is published under [WTFNMFPLv3](https://github.com/dittodhole/WTFNMFPLv3).

## Icon

[Source Code](https://thenounproject.com/icon/996120/) by [Creative Stall](https://thenounproject.com/creativestall) from the Noun Project.
