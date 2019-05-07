using FluentAssertions;
using NUnit.Framework;
using One.UI.Controllers;
using System.Net;
using System.Threading.Tasks;

namespace One.Tests.Integration.Smoke
{
    public class StartUpTest: GlobalSetup
    {
        [Test]
        public async Task ServerShouldStart() =>
            (await httpClient.GetAsync(nameof(HomeController.ServidorDeveExistir)))
                .StatusCode.Should().Be(HttpStatusCode.OK);



        [Test]
        public async Task DataBaseShouldStart() =>
            (await httpClient.GetAsync(nameof(HomeController.BancoDeDadosDeveExistir)))
                .StatusCode.Should().Be(HttpStatusCode.OK);
    }
}
