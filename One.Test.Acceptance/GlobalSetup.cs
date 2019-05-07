using Microsoft.AspNetCore.TestHost;
using NUnit.Framework;
using One.UI;
using OpenQA.Selenium;
using System;
using System.Net.Http;

namespace One.Test.Acceptance
{
    [TestFixture]
    public class GlobalSetup
    {
        protected HttpClient httpClient;
        private TestServer appServer;
        public static IWebDriver driver;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            var builder = WebHostBuilderFactory
                .CreateFromTypesAssemblyEntryPoint<Startup>(Array.Empty<string>());

            appServer = new TestServer(builder);
            httpClient = appServer.CreateClient();
            driver = DriverSetup.Setup();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            appServer?.Dispose();
            driver?.Quit();
        }
    }
}
