using System;
using System.Threading;
using my_code.Pages;
using my_code.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace my_code.pages
{
    [TestFixture]
    internal class TM_Tests: CommonDriver
    {
        
    [SetUp]
        public void LoginFunction()
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


        }


        [Test]
        public void CreateTM_Test()
        {
          // TM page object intialzation and definition 
            TMPage tMPageObj = new TMPage();
            tMPageObj.CreateTM(driver);
        }

        [Test]
        public void EditTM_Test()
        {

            // Edit TM
            TMPage tMPageObj = new TMPage();
            tMPageObj.EditTM(driver);


        }

        [Test]
        public void DeleteTM_Test()
        {

            // Delete TM
            TMPage tMPageObj = new TMPage();
            tMPageObj.DeleteTM(driver);


        }

        [TearDown]
        public void CloseTestRun()
        {

        }

    }

}
        
            
        
    






