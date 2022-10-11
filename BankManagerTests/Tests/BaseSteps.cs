using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Tests
{
    [Binding]
    public class BaseSteps
    {
        protected static IWebDriver driver;

        [BeforeFeature]
        public static void BeforeFeauture()
        {
            driver = new ChromeDriver(@"D:\ChromeDriver\");
            driver.Navigate().GoToUrl("https://www.globalsqa.com/angularJs-protractor/BankingProject/");
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            driver.Close();
        }
    }
}
