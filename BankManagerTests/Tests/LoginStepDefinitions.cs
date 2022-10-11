using ObjectPages;
using System;
using System.Collections.Generic;
using System.Threading;
using TechTalk.SpecFlow;

namespace Tests
{
    [Binding]
    public class LoginStepDefinitions : BaseSteps
    {
        private LoginPage loginPage;

        [Given(@"I launch the application")]
        public void GivenILaunchTheApplication()
        {
            loginPage = new LoginPage(driver);
            Thread.Sleep(1000);
        }

        [Given(@"I click on the Bank Manager Login link")]
        public void GivenIClickOnTheBankManagerLoginLink()
        {
            loginPage.ClickLogin();
            Thread.Sleep(1000);
        }
    }
}
