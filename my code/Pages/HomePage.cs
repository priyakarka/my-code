using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using my_code.Utilities;
using OpenQA.Selenium;

namespace my_code.Pages
{
    internal class HomePage
    {
        public void GoToTMPage(IWebDriver driver) 
        {

            
            // Go to TM page
            IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationDropdown.Click();
            wait.WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 2);


            IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmOption.Click();

        }

        public void GoToEmployeePage(IWebDriver driver)
        {

        }
    }
}
