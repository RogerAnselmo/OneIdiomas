using NUnit.Framework;
using Microsoft.AspNetCore.TestHost;
using System.Net.Http;
using One.UI;
using System;

namespace One.Tests.Integration
{
    [TestFixture]
    public class GlobalSetup
    {
        private TestServer appServer;
        protected HttpClient httpClient;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            var builder = WebHostBuilderFactory
                .CreateFromTypesAssemblyEntryPoint<Startup>(Array.Empty<string>());

            appServer = new TestServer(builder);
            httpClient = appServer.CreateClient();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown() => appServer?.Dispose();
    }
}
