using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Configuration;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;

namespace Laxmi.TestAutomation.Framework
{

    public class BaseTest
    {
        public static IWebDriver Driver { get; set; }

        public void SetUp()
        {
            var environment = ConfigurationManager.AppSettings["Environment"];
            var Browser = ConfigurationManager.AppSettings[environment + "_Browser"];
            switch (Browser.ToUpper())
            {
                case "IE":
                    if (Driver == null)
                    {
                        Driver = new InternetExplorerDriver();
                    }
                    break;

                case "CHROME":
                    if (Driver == null)
                    {
                        Driver = new ChromeDriver();
                    }
                    break;
            }

            string url = ConfigurationManager.AppSettings[environment + "_URL"];
            Driver.Navigate().GoToUrl(url);
            //wait
            //Utility.MaxMiseBrowser(Driver);
        }

        public void NavigateBackToIndexPage()
        {
            var environment = ConfigurationManager.AppSettings["Environment"];
            string url = ConfigurationManager.AppSettings[environment + "_URL"];
            Driver.Navigate().GoToUrl(url);
        }
    }
}
