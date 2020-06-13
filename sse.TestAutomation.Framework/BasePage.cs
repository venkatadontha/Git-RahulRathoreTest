using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
//using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;

namespace Laxmi.TestAutomation.Framework
{
    public abstract class BasePage
    {
        private IWebDriver _driver;

        //Dummy element
        [FindsBy(How = How.LinkText, Using = "TestElement")]
        [CacheLookup]
        private IWebElement TestElement { get; set; }

        public BasePage(IWebDriver driver)
        {
            this._driver = driver;
            PageFactory.InitElements(_driver,this);
        }

        abstract public bool  IsAt();

    }
}
