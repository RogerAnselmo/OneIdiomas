using Microsoft.AspNetCore.TestHost;
using NUnit.Framework;
using One.UI;
using OpenQA.Selenium;
using System;
using System.IO;
using System.Net.Http;

namespace One.Test.Acceptance
{
    public class GlobalSetup
    {
        protected HttpClient httpClient;
        private TestServer appServer;
        public static IWebDriver driver;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            var builder = WebHostBuilderFactory.CreateFromTypesAssemblyEntryPoint<Startup>(Array.Empty<string>());

            appServer = new TestServer(builder);
            httpClient = appServer.CreateClient();
            driver = DriverSetup.Setup();
        }


        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed
             || TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Inconclusive)
            {
                var screenShootDriver = driver as ITakesScreenshot;
                var screenShoot = screenShootDriver.GetScreenshot();
                var testName = TestContext.CurrentContext.Test.Name;
                var path = Path.Combine("..", "..", "..", "ScreenShoots", $"{testName}-{DateTime.Now.ToString("yyyyMMdd-hhmmss")}.png");
                screenShoot.SaveAsFile(path);
            }
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            appServer?.Dispose();
            driver?.Quit();
        }
    }
}
