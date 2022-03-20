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
    [Parallelizable]
    internal class TM_Tests:CommonDriver
    {
        

        [Test, Order(1), Description("Check if user able to create a material record with valid data")]
        public void CreateTM_Test()
        {

            // Home page object intialization and definition 
            HomePage homepageObj = new HomePage();
            homepageObj.GoToTMPage(driver);

            // TM page object intialzation and definition
            TMPage tMPageObj = new TMPage();
            tMPageObj.CreateTM(driver);
        }

        [Test, Order(2), Description("Check if user is able to edit a material record with valid data")]
        public void EditTM_Test()
        {
            // Home page object intialzation and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

            // Edit TM
            TMPage tMPageObj = new TMPage();
            tMPageObj.EditTM(driver, "dummy", "dummy2", "dummy3");
        }

        [Test, Order(3), Description("Check if user is able to delete an existing material record")]
        public void DeleteTM_Test()
        {
            // Home page object intialzation and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

            // Delete TM
            TMPage tMPageObj = new TMPage();
            tMPageObj.DeleteTM(driver);
        }
    }
}










