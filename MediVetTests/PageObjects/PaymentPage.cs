using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using Laxmi.TestAutomation.Framework;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace TestWebSiteTests.PageObjects
{
    class PaymentPage : BasePage
    {
        private IWebDriver _driver;

        [FindsBy(How = How.CssSelector, Using = ".bankwire")]
        private IWebElement BankWire { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(.,'I confirm my order')]")]
        [CacheLookup]
        private IWebElement ConfirmOrder { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".cheque-indent > .dark")]
        private IWebElement paymentConfirmationMessage { get; set; }

        public PaymentPage(IWebDriver driver) : base(driver)
        {
            this._driver = driver;
        }

        public string PaymentByWire()
        {
            BankWire.Click();
            ConfirmOrder.Click();
            return paymentConfirmationMessage.Text;
        }

        public override bool IsAt()
        {
            throw new NotImplementedException();
        }
    }
}
