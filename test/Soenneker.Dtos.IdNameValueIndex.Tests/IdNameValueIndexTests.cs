using Soenneker.Tests.HostedUnit;

namespace Soenneker.Dtos.IdNameValueIndex.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class IdNameValueIndexTests : HostedUnitTest
{
    public IdNameValueIndexTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
