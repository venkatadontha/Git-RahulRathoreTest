using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace Laxmi.TestAutomation.Framework
{
    public class Utility
    {
        public static void MaxMiseBrowser(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();

        }
        
        public static void ScrollToElement(IWebDriver driver, IWebElement webElement)
        {
            WebDriverExtensions.ExecuteJavaScript(driver, "arguments[0].scrollIntoView();", webElement);

        }

        public static void RunJavaScript(IWebDriver driver, string javaScript, IWebElement webElement)
        {
            WebDriverExtensions.ExecuteJavaScript(driver,javaScript, webElement);
        }

        public static void ClickCheckBox(IWebElement webElement, string OnOrOff)
        {
            if (OnOrOff.ToLower() == "on")
            {
                if(webElement.GetAttribute("checked") != "true" )
                {
                    webElement.Click();
                }
            }
            else
            {
                if (webElement.GetAttribute("checked") == "true")
                {
                    webElement.Click();
                }
            }

        }

        public static void Sleep(int milliSeconds)
        {
            Thread.Sleep(milliSeconds);
        }

        public static void ActionPerform(IWebDriver driver)
        {
            //Actions action = new Actions(driver);
            //action.SendKeys()
        }

        public static string parseCheckBoxOption(string YorN)
        {
            if (YorN.ToLower() == "y") return "on";
            else if (YorN.ToLower() == "n") return "off";
            else return "InvalidTestDataInputParamValue";
        }
    }
}
