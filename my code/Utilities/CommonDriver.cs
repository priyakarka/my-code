using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using my_code.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace my_code.Utilities
{
    internal class CommonDriver
    {
        public  IWebDriver driver;

        [OneTimeSetUp]

        public void LoginFunction()
        {
            
            driver = new ChromeDriver();
            

            // Login page object intialization and definition 
            LoginPage loginpageObj = new LoginPage();
            loginpageObj.LoginSteps(driver);

           
        }

        [OneTimeTearDown]

        public void CloseTestRun()
        {
            driver.Quit();

        }


    }
}
