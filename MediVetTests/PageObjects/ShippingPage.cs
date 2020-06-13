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
    class ShippingPage : BasePage
    {
        private IWebDriver _driver;

        [FindsBy(How = How.Id, Using = "cgv")]
        [CacheLookup]
        private IWebElement Shipping { get; set; }

        [FindsBy(How = How.Name, Using = "processCarrier")]
        private IWebElement ProcessCarrrier { get; set; }

        public ShippingPage(IWebDriver driver) : base(driver)
        {
            this._driver = driver;
        }

        public void ProcessShipping()
        {
            Shipping.Click();
            ProcessCarrrier.Click();
            
        }

        public override bool IsAt()
        {
            throw new NotImplementedException();
        }
    }
}
