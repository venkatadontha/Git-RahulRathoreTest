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
    class ItemDetailsPage : BasePage
    {
        private IWebDriver _driver;

        [FindsBy(How = How.XPath, Using = "//p[@id='add_to_cart']/button")]
        [CacheLookup]
        private IWebElement AddToCart { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(.,'Proceed to checkout')]")]
        private IWebElement ProceedToCheckOut { get; set; }


        [FindsBy(How = How.XPath, Using = "//ul[@id='color_to_pick_list']/li")]
        private IWebElement ColorsElements { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='attribute_list']/ul[@id='color_to_pick_list']")]
        private IWebElement ColorsSection { get; set; }

        [FindsBy(How = How.Id, Using = "group_1")]
        private IWebElement listItemSizeElement { get; set; }
       

        public ItemDetailsPage(IWebDriver driver) : base(driver)
        {
            this._driver = driver;
        }

        public string GetColorOfSelectedItem()
        {
            IWebElement selectedColorElement = ColorsSection.FindElement(By.XPath("//li[@class='selected']/a"));
            return  selectedColorElement.GetAttribute("title");
        }
        public void chooseAnotherItemColor()
        {
          
                IWebElement newColorElement = ColorsSection.FindElement(By.XPath("//li[@class='selected']/following-sibling::li"));
                newColorElement.Click();
        }
        public int GetColorsCount()
        {
            return ColorsSection.FindElements(By.XPath("li")).Count;
        }

        public void SelectItemBySize(string size)
        {
            new SelectElement(listItemSizeElement).SelectByText(size);
        }
        public void ClickOnAddToCart()
        {
            Thread.Sleep(2000);
            AddToCart.Click();
            Thread.Sleep(3000);
        }

        public void ClickOnProceedToCheckOut()
        {
            ProceedToCheckOut.Click();
            Thread.Sleep(3000);
        }

        public override bool IsAt()
        {
            throw new NotImplementedException();
        }
    }
}
