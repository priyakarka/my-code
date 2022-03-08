using System;
using System.Threading;
using my_code.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace my_code.pages
{
    internal class TM_Tests
    {
        private static object loginPageobj;

        static void Main(string[] args)
        {

            // open chrome browser
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // Login page object initialzation and definition 
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);


            // Home page object intialization and definition 
            HomePage homepageObj = new HomePage();
            homepageObj.GoToTMPage(driver);

            // TM page object intialization and definition 
            TMPage tMPageObj = new TMPage();
            tMPageObj.CreateTM(driver);

            // Edit TM
            tMPageObj.EditTM(driver);

            // Delete TM
            tMPageObj.DeleteTM(driver);
                                     



        }
    }
}
        
            
        
    






