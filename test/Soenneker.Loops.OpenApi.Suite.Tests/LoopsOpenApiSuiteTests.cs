using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Loops.OpenApi.Suite.Tests;

[Collection("Collection")]
public sealed class LoopsOpenApiSuiteTests : FixturedUnitTest
{
    public LoopsOpenApiSuiteTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
