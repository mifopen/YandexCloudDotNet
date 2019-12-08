using System.Linq;
using Nuke.Common;
using Nuke.Common.Execution;
using Nuke.Common.Git;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.DotNet;
using Nuke.Common.Tools.GitVersion;
using Nuke.Common.Utilities.Collections;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.IO.PathConstruction;
using static Nuke.Common.Tools.DotNet.DotNetTasks;
using static Nuke.Common.Tools.Git.GitTasks;

[CheckBuildProjectConfigurations]
class Build: NukeBuild
{
    public static int Main()
    {
        return Execute<Build>(x => x.Compile);
    }

    [Parameter("Configuration to build - Default is 'Debug' (local) or 'Release' (server)")]
    readonly Configuration Configuration = IsLocalBuild ? Configuration.Debug : Configuration.Release;

    [Parameter("NuGet api key")] readonly string ApiKey;
    readonly string LicenseFile = RootDirectory / "LICENSE";

    [Solution] readonly Solution Solution;
    [GitRepository] readonly GitRepository GitRepository;
    [GitVersion] readonly GitVersion GitVersion;

    AbsolutePath SourceDirectory => RootDirectory / "src";
    AbsolutePath TestsDirectory => RootDirectory / "tests";
    AbsolutePath ArtifactsDirectory => RootDirectory / "artifacts";

    Target Clean
        => _ => _
                .Before(Restore)
                .Executes(() =>
                          {
                              SourceDirectory.GlobDirectories("**/bin", "**/obj")
                                             .ToArray()
                                             .ForEach(DeleteDirectory);
                              TestsDirectory.GlobDirectories("**/bin", "**/obj")
                                            .ToArray()
                                            .ForEach(DeleteDirectory);
                              EnsureCleanDirectory(ArtifactsDirectory);
                          });

    Target Restore
        => _ => _
               .Executes(() =>
                         {
                             DotNetRestore(s => s
                                               .SetProjectFile(Solution));
                         });

    Target Compile
        => _ => _
                .DependsOn(Restore)
                .Executes(() =>
                          {
                              DotNetBuild(s => s
                                               .SetProjectFile(Solution)
                                               .SetConfiguration(Configuration)
                                               .SetAssemblyVersion(GitVersion.AssemblySemVer)
                                               .SetFileVersion(GitVersion.AssemblySemFileVer)
                                               .SetInformationalVersion(GitVersion.InformationalVersion)
                                               .EnableNoRestore());
                          });

    Target Pack
        => _ => _
                .DependsOn(Clean, Compile)
                .Executes(() =>
                          {
                              var licenseUrl = GitRepository.GetGitHubBrowseUrl(LicenseFile, "master");
                              DotNetPack(s => s
                                              //                                            .SetPackageReleaseNotes(changelogUrl)
                                              .SetWorkingDirectory(RootDirectory)
                                              .SetPackageLicenseUrl(licenseUrl)
                                              .SetProject(Solution.Path)
                                              .EnableNoBuild()
                                              .SetConfiguration(Configuration)
                                              .EnableIncludeSymbols()
                                              .SetOutputDirectory(ArtifactsDirectory)
                                              .SetDescription(".NET http client for Yandex Cloud Api")
                                              .SetVersion(GitVersion.NuGetVersionV2));
                          });

    Target Publish
        => _ => _
                .DependsOn(Pack)
                .Requires(() => ApiKey)
                .Requires(() => Equals(Configuration, Configuration.Release))
                .Executes(() =>
                          {
                              GlobFiles(ArtifactsDirectory, "*.nupkg")
                                  .NotEmpty()
                                  .Where(x => !x.EndsWith(".symbols.nupkg"))
                                  .ForEach(x => DotNetNuGetPush(s => s
                                                                     .SetTargetPath(x)
                                                                     .SetSource("https://api.nuget.org/v3/index.json")
                                                                     .SetApiKey(ApiKey)));
                          });

    Target PublishLocal
        => _ => _
                .DependsOn(Pack)
                .Executes(() =>
                          {
                              GlobFiles(ArtifactsDirectory, "*.nupkg")
                                  .NotEmpty()
                                  .Where(x => !x.EndsWith(".symbols.nupkg"))
                                  .ForEach(x => DotNetNuGetPush(s => s
                                                                     .SetTargetPath(x)
                                                                     .SetSource("/Users/mif/Documents/GitHub/localnuget")));
                          });

    Target GenerateProto
        => _ => _
               .Executes(() =>
                         {
                             var dir = BuildProjectDirectory / "ProtoGenerator";
                             var sourceDirectory = SourceDirectory / "YandexCloudDotNet" / "cloudapi";
                             DeleteDirectory(dir / "cloudapi");
                             DeleteDirectory(dir / "Generated");
                             DeleteDirectory(sourceDirectory);

                             Git("clone https://github.com/yandex-cloud/cloudapi.git", dir);
                             DotNetBuild(x => x.SetWorkingDirectory(dir));
                             CopyDirectoryRecursively(dir / "Generated" / "cloudapi",
                                                      sourceDirectory);

                             DeleteDirectory(dir / "cloudapi");
                             DeleteDirectory(dir / "Generated");
                         });
}
