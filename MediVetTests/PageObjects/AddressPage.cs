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
    class AddressPage : BasePage
    {
        private IWebDriver _driver;

        [FindsBy(How = How.Name, Using = "processAddress")]
        [CacheLookup]
        private IWebElement processAddress { get; set; }

        [FindsBy(How = How.Name, Using = "message")]
        private IWebElement Message { get; set; }

        public AddressPage(IWebDriver driver) : base(driver)
        {
            this._driver = driver;
        }

        public void ProcessAddress()
        {

            Message.SendKeys("Test order address");
            processAddress.Click();

        }

        public override bool IsAt()
        {
            throw new NotImplementedException();
        }
    }
}
