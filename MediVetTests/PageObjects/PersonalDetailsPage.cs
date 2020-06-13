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
using TestWebSiteTests.POCOs;

namespace TestWebSiteTests.PageObjects
{
    class PersonDetailsPage : BasePage
    {
        private IWebDriver _driver;

        [FindsBy(How = How.Id, Using = "id_gender1")]
        [CacheLookup]
        private IWebElement Gender { get; set; }

        [FindsBy(How = How.Id, Using = "customer_firstname")]
        [CacheLookup]
        private IWebElement FirstName { get; set; }

        [FindsBy(How = How.Id, Using = "customer_lastname")]
        [CacheLookup]
        private IWebElement LastName { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        [CacheLookup]
        private IWebElement Email { get; set; }

        [FindsBy(How = How.Id, Using = "passwd")]
        [CacheLookup]
        private IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "days")]
        [CacheLookup]
        private IWebElement Day { get; set; }

        [FindsBy(How = How.Id, Using = "months")]
        [CacheLookup]
        private IWebElement Month { get; set; }

        [FindsBy(How = How.Id, Using = "years")]
        [CacheLookup]
        private IWebElement Year { get; set; }

        [FindsBy(How = How.Id, Using = "company")]
        [CacheLookup]
        private IWebElement Company { get; set; }

        [FindsBy(How = How.Id, Using = "address1")]
        [CacheLookup]
        private IWebElement Address1 { get; set; }

        [FindsBy(How = How.Id, Using = "address2")]
        [CacheLookup]
        private IWebElement Address2 { get; set; }

        [FindsBy(How = How.Id, Using = "city")]
        [CacheLookup]
        private IWebElement City { get; set; }

        [FindsBy(How = How.Id, Using = "id_state")]
        [CacheLookup]
        private IWebElement State { get; set; }

        [FindsBy(How = How.Id, Using = "postcode")]
        [CacheLookup]
        private IWebElement Postcode { get; set; }

        [FindsBy(How = How.Id, Using = "other")]
        [CacheLookup]
        private IWebElement Other { get; set; }

        [FindsBy(How = How.Id, Using = "phone_mobile")]
        [CacheLookup]
        private IWebElement PhoneNumber { get; set; }

        [FindsBy(How = How.Id, Using = "alias")]
        [CacheLookup]
        private IWebElement Alias { get; set; }

        [FindsBy(How = How.Id, Using = "submitAccount")]
        [CacheLookup]
        private IWebElement Submit { get; set; }

        public PersonDetailsPage(IWebDriver driver) : base(driver)
        {
            this._driver = driver;
        }

        public void SetUpPersonalDetails()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            Thread.Sleep(3000);
            IWebElement element = wait.Until(drv => drv.FindElement(By.Id("id_gender1")));

            Gender.Click();
            FirstName.SendKeys("Laxmi");
            LastName.SendKeys("Swamy");
            //Email.SendKeys("");
            Password.SendKeys("LaxmiSwamy");

            SelectElement days = new SelectElement(Day);
            days.SelectByIndex(2);

            SelectElement months = new SelectElement(Month);
            months.SelectByIndex(1);

            SelectElement years = new SelectElement(Year);
            years.SelectByText("1978  ");

            Company.SendKeys("Laxmi");
            Address1.SendKeys("1 tyberton place");
            Address2.SendKeys("line2");
            City.SendKeys("Reading");

            new SelectElement(State).SelectByText("Alabama");
            Postcode.SendKeys("12345");
            Other.SendKeys("Other test information");

            PhoneNumber.SendKeys("00447511207789");
            Alias.Clear();
            Alias.SendKeys("LaxmiSwamy");
            Submit.Click();

        }


        public void SetUpPersonalDetails(PersonalDetailsVO personalDetailsVO)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            Thread.Sleep(3000);
            IWebElement element = wait.Until(drv => drv.FindElement(By.Id("id_gender1")));

            Gender.Click();
            FirstName.SendKeys(personalDetailsVO.FirstName);
            LastName.SendKeys(personalDetailsVO.LastName);
            //Email.SendKeys("");
            Password.SendKeys(personalDetailsVO.Password);

            //will parse DOB later
            SelectElement days = new SelectElement(Day);
            days.SelectByIndex(2);

            SelectElement months = new SelectElement(Month);
            months.SelectByIndex(1);

            SelectElement years = new SelectElement(Year);
            years.SelectByText("1978  ");

            Company.SendKeys(personalDetailsVO.Company);
            Address1.SendKeys(personalDetailsVO.Address1);
            Address2.SendKeys(personalDetailsVO.Address2);
            City.SendKeys(personalDetailsVO.Address2);

            new SelectElement(State).SelectByText(personalDetailsVO.State);
            Postcode.SendKeys(personalDetailsVO.PostCode);
            Other.SendKeys("Other test information");

            PhoneNumber.SendKeys(personalDetailsVO.PhoneNumber);
            Alias.Clear();
            Alias.SendKeys(personalDetailsVO.Alias);
            Submit.Click();

        }

        public override bool IsAt()
        {
            throw new NotImplementedException();
        }
    }
}
