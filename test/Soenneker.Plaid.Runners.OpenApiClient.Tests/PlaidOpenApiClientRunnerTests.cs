using Soenneker.Tests.HostedUnit;

namespace Soenneker.Plaid.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class PlaidOpenApiClientRunnerTests : HostedUnitTest
{
    public PlaidOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
