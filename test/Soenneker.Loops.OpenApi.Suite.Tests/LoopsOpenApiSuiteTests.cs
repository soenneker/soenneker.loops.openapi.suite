using Soenneker.Tests.HostedUnit;

namespace Soenneker.Loops.OpenApi.Suite.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class LoopsOpenApiSuiteTests : HostedUnitTest
{
    public LoopsOpenApiSuiteTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
