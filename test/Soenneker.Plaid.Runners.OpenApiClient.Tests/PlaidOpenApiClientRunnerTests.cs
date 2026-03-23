using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Plaid.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class PlaidOpenApiClientRunnerTests : FixturedUnitTest
{
    public PlaidOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
