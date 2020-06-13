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
    class SignInPage : BasePage
    {
        private IWebDriver _driver;

        [FindsBy(How = How.Id, Using = "email_create")]
        [CacheLookup]
        private IWebElement EmailID { get; set; }

        [FindsBy(How = How.Id, Using = "SubmitCreate")]
        private IWebElement SubmitCreate { get; set; }

        public SignInPage(IWebDriver driver) : base(driver)
        {
            this._driver = driver;
        }

        public void SetEmailAndClickOnCreateAccount()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            DateTime t = DateTime.Now;
            string timeStamp = t.ToString().Replace(" ", "").Replace(":", "_").Replace("/", "");
            EmailID.SendKeys("laxmiSwamy" + timeStamp + "@gmail.com");
            SubmitCreate.Click();
        }

        public void SetEmailAndClickOnCreateAccount(string email,string autosuffix)
        {
            string emailTemp = "";
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            DateTime t = DateTime.Now;
            if (autosuffix.ToLower() == "auto")
            {
                string timeStamp = t.ToString().Replace(" ", "").Replace(":", "_").Replace("/", "");
                emailTemp = email + timeStamp + "@gmail.com";
            }
            else
                emailTemp = email;
            EmailID.SendKeys(emailTemp);
            SubmitCreate.Click();
        }
        public override bool IsAt()
        {
            return (_driver.Title == "Login - My Store") ? true : false;
        }
    }
}
