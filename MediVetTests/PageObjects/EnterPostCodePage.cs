using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using Laxmi.TestAutomation.Framework;

namespace Laxmi.TestAutomation.AutomationTests.PageObjects
{
    class TwentyFourHoursEmergencyVet :BasePage
    {
        private IWebDriver _driver;

        [FindsBy(How = How.Name, Using = "address")]
        [CacheLookup]
        private IWebElement PostCode { get; set; }

        [FindsBy(How = How.Id, Using = "resultsEmergency")]
        [CacheLookup]
        private IWebElement HospitalsResults { get; set; }

        public TwentyFourHoursEmergencyVet(IWebDriver driver) :base(driver)
        {
            this._driver = driver;
           //PageFactory.InitElements(_driver, this);
      }

        public TwentyFourHoursEmergencyVet SearchPostCodeAndViewPrices(string postCode)
        {
            Utility.Sleep(1000);
            Utility.ScrollToElement(_driver, PostCode);
            PostCode.SendKeys(postCode);
            PostCode.Submit();
            Utility.Sleep(3000);
            return new TwentyFourHoursEmergencyVet(_driver);
        }

        public Dictionary<int,string> GetHospitalResults()
        {
            Dictionary<int, string> items = new Dictionary<int, string>();
            try
            {
                int item = 0;


                foreach (IWebElement hospital in HospitalsResults.FindElements(By.XPath("div")))
                {
                    Utility.ScrollToElement(_driver, hospital);
                    Utility.Sleep(500);
                    //nearest
                    if (hospital.GetAttribute("class").Contains("practicePartial nearest"))
                    {
                        items.Add(item, hospital.FindElement(By.XPath("h2")).Text);
                    }//rest all
                    else
                    {
                        items.Add(item, hospital.FindElement(By.XPath("div/h3")).Text);
                    }
                    item++;
                }
            }
            catch (Exception e) { Console.WriteLine("Exception Thrown" + e.ToString()); }
            return items;
        }

        public override bool IsAt()
        {
            throw new NotImplementedException();
        }
    }
}
