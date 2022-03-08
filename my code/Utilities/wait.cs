using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace my_code.Utilities
{
    internal class wait
    {

        public static void WaitToBeClickable(IWebDriver driver, string locator, string locatorvalue, int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));

            if (locator == "XPath")
            {

                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(locatorvalue)));
            }

            if (locator == "Id")
            {

                wait.Until(ExpectedConditions.ElementToBeClickable(By.Id(locatorvalue)));
            }

            if (locator == "CssSelector")
            {

                wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorvalue)));
            }
        }



        public static void WaitToBeVisible(IWebDriver driver, string locator, string locatorvalue, int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));

            if (locator == "XPath")
            {

                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locatorvalue)));
            }

            if (locator == "Id")
            {

                wait.Until(ExpectedConditions.ElementIsVisible(By.Id(locatorvalue)));
            }

            if (locator == "CssSelector")
            {

                wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(locatorvalue)));
            }

        }

    }
}


