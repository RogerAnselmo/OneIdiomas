using Microsoft.AspNetCore.TestHost;
using NUnit.Framework;
using One.UI;
using System;
using System.Net.Http;

namespace One.Test.Integration
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
