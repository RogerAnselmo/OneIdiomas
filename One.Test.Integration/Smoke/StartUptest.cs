using FluentAssertions;
using NUnit.Framework;
using One.UI.Controllers;
using System.Net;
using System.Threading.Tasks;

namespace One.Test.Integration.Smoke
{

    public class StartUptest: GlobalSetup
    {
        [Test]
        public async Task ServerShouldStart() =>
            (await httpClient.GetAsync(nameof(HomeController.ApplicationIsAlive)))
                .StatusCode.Should().Be(HttpStatusCode.OK);



        [Test]
        public async Task DataBaseShouldStart() =>
            (await httpClient.GetAsync(nameof(HomeController.DataBaseIsAlive)))
                .StatusCode.Should().Be(HttpStatusCode.OK);
    }
}
