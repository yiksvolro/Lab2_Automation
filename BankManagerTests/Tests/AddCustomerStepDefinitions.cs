using NUnit.Framework;
using ObjectPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Tests
{
    [Binding]
    public class AddCustomerStepDefinitions : BaseSteps
    {
        private AddCustomerPage addCustomerPage => new AddCustomerPage(driver);
        [Given("I click on AddCustomer button")]
        public void GivenIClickOnAddCustomerBtn()
        {
            addCustomerPage.ClickButtonAddCustomer();
            Thread.Sleep(1000);
        }

        [Given("I enter the information")]
        public void GivenIClickOnFirstName()
        {
            addCustomerPage.ClickFirstName();
            addCustomerPage.EnterFirstName();

            addCustomerPage.ClickLastName();
            addCustomerPage.EnterLastName();

            addCustomerPage.ClickPostCode();
            addCustomerPage.EnterPostCode();

        }
        [When("I click on create")]
        public void WhenIClickOnCreate()
        {
            addCustomerPage.ClickCreate();
        }
        [Then("I should see success alert")]
        public void ThenIShouldSeeSuccessAlert()
        {
            var result = addCustomerPage.CatchAlert();
            StringAssert.StartsWith("Customer added successfully with customer id :", result);
        }

    }
}
