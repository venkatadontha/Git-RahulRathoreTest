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
    class SummaryPage : BasePage
    {
        private IWebDriver _driver;

        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/p[@class='cart_navigation clearfix']/a[1]")]
        [CacheLookup]
        private IWebElement proceedToCheckOUt { get; set; }

        [FindsBy(How = How.ClassName, Using = "ajax_cart_no_product")]
        private IWebElement ShoppingCartNoElement { get; set; }

        public SummaryPage(IWebDriver driver) : base(driver)
        {
            this._driver = driver;
        }

        public void ProceedToCheckOut()
        {
            Thread.Sleep(3000);
            proceedToCheckOUt.Click();
        }

        public override bool IsAt()
        {
            throw new NotImplementedException();
        }
    }
}
