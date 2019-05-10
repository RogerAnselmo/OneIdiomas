using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Linq;

namespace One.Test.Acceptance
{
    public static class DriverSetup
    {
        public static IWebDriver Setup()
        {
            var driverPath = ObterDiretórioDoNavegador("selenium.chrome.webdriver", "driver")
                ?? throw new Exception("Driver não encontrado!");

            var service = ChromeDriverService.CreateDefaultService(driverPath);
            var chromeOptions = new ChromeOptions();

            chromeOptions.AddArguments("--start-maximized");

            var driver = new ChromeDriver(service, chromeOptions);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            return driver;
        }

        private static string ObterDiretórioDoNuGet() =>
            Path.Combine(Environment.GetEnvironmentVariable("USERPROFILE")
                ?? Environment.GetEnvironmentVariable("HOME"),
                ".nuget");

        private static string ObterDiretórioDoNavegador(string nomeDoPacote, params string[] diretórios)
        {

            var diretórioDoNuget = ObterDiretórioDoNuGet();
            var diretóriosExpandidos = Environment.ExpandEnvironmentVariables(diretórioDoNuget);
            var diretóriosDosPacotes = Path.Combine(diretóriosExpandidos, "packages", nomeDoPacote);
            var últimaVersão = Directory.EnumerateDirectories(diretóriosDosPacotes)
            .Select(p => new Version(Path.GetFileName(p)))
            .Max();

            var diretórioDoDriver = Path.Combine(diretóriosDosPacotes, últimaVersão.ToString(), Path.Combine(diretórios));
            return diretórioDoDriver;
        }
    }
}
