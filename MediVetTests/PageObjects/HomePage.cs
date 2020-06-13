using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
//using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;
using Laxmi.TestAutomation.Framework;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace TestWebSiteTests.PageObjects
{
    class HomePage : BasePage
    {
        private IWebDriver _driver;

        [FindsBy(How = How.XPath, Using = "//div[@class='shopping_cart']/a")]
        [CacheLookup]
        private IWebElement ShoppingCart { get; set; }

        [FindsBy(How = How.ClassName, Using = "ajax_cart_no_product")]
        private IWebElement ShoppingCartNoElement { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='homefeatured']/li[1]/div[@class='product-container']/div[1]/div/a[1]/img")]
        [CacheLookup]
        private IWebElement FirstProductItem { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "Sign out")]
        [CacheLookup]
        private IWebElement SignOutElement { get; set; }


        public HomePage(IWebDriver driver) : base(driver)
        {
            this._driver = driver;
        }

        public void NavigateBackToIndexPage(string baseUrl)
        {
            _driver.Navigate().GoToUrl(baseUrl);
        }
        public void ChooseGridItem()
        {
            _driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(10));
            FirstProductItem.Click();
        }

        public void ClearShoppingCartItems()
        {
            try
            {
                if (!ShoppingCartNoElement.Displayed)
                {
                    ShoppingCart.Click();
                    Actions builder = new Actions(_driver);
                    builder.MoveToElement(ShoppingCart);
                    builder.Build();
                    builder.Perform();
                    _driver.FindElement(By.CssSelector(".cross")).Click();
                }
            }
            catch (Exception unKnownException)
            {
                Console.WriteLine(unKnownException.StackTrace);

            }

        }
        public void SignOut()
        {
            SignOutElement.Click();
        }

        public override bool IsAt()
        {
            return (_driver.Title == "My Store") ? true : false;
        }
    }
}
