using OpenQA.Selenium;

namespace ObjectPages
{
    public class AddCustomerPage : BasePage
    {
        public AddCustomerPage(IWebDriver webDriver) : base(webDriver)
        {
        }
        private IWebElement btnAddCustomer => driver.FindElement(By.XPath("//button[@ng-click='addCust()']"));
        private IWebElement firstName => driver.FindElement(By.XPath("//input[@ng-model='fName']"));
        private IWebElement lastName => driver.FindElement(By.XPath("//input[@ng-model='lName']"));
        private IWebElement postCode => driver.FindElement(By.XPath("//input[@ng-model='postCd']"));
        private IWebElement createBtn => driver.FindElement(By.XPath("//button[@type='submit']"));
        public void ClickButtonAddCustomer() => btnAddCustomer.Click();
        public void ClickFirstName() => firstName.Click();
        public void ClickLastName() => lastName.Click();
        public void ClickPostCode() => postCode.Click();
        public void ClickCreate() => createBtn.Click();
        public void EnterFirstName() => firstName.SendKeys("test");
        public void EnterLastName() => lastName.SendKeys("test22323");
        public void EnterPostCode() => postCode.SendKeys("3002304");
        public string CatchAlert() => driver.SwitchTo().Alert().Text;
       
    }
}
