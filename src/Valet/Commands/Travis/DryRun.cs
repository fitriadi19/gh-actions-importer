using System.CommandLine;

namespace Valet.Commands.Travis;

public class DryRun : ContainerCommand
{
    public DryRun(string[] args) : base(args)
    {
    }

    protected override string Name => "travis-ci";
    protected override string Description => "Convert a Travis CI pipeline to a GitHub Actions workflow and output it's yaml file.";

    protected override List<Option> Options => new()
    {
        Common.Repository,
        Common.Organization,
        Common.InstanceUrl,
        Common.AccessToken,
        Common.SourceGitHubInstanceUrl,
        Common.SourceGitHubAccessToken,
        Common.SourceFilePath
    };
}