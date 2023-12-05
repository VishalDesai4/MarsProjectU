using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MARSAutomation.Utilities
{
    public class CommonDriver
    {
        public IWebDriver driver;

        [BeforeScenario]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }
        [AfterScenario]
        public void QuitDriver()
        {
            driver.Quit();

        }
    }
}
