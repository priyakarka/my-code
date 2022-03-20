using System;
using my_code.Pages;
using my_code.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace my_code.StepDefinitions
{
    [Binding]
    public class TMFeatureStepDefinitions : CommonDriver
    {
        // Initializing page objects
        LoginPage loginpageObj = new LoginPage();
        HomePage homepageObj = new HomePage();
        TMPage tMPageObj = new TMPage();



        [Given(@"I logged into TurnUp portal successfully")]
        public void GivenILoggedIntoTurnUpPortalSuccessfully()
        {
            driver = new ChromeDriver();
                  
           loginpageObj.LoginSteps(driver);
        }

        [Given(@"I navigate to time and material page")]
        public void GivenINavigateToTimeAndMaterialPage()
        {                     
            homepageObj.GoToTMPage(driver);

        }

        [When(@"I create time and material record")]
        public void WhenICreateTimeAndMaterialRecord()
        {
            // TM page object initialization and definition

            tMPageObj.CreateTM(driver);

        }

        [Then(@"the record should be created sucessfully")]
        public void ThenTheRecordShouldBeCreatedSucessfully()
        {         

            string newCode = tMPageObj.GetCode(driver);
            string newTypeCode = tMPageObj.GetTypeCode(driver);
            string newDescription = tMPageObj.GetDescription(driver);
            string newPrice = tMPageObj.GetPrice(driver);

            Assert.That(newCode == "my code", "Actual code and expected code do not match");
            Assert.That(newTypeCode == "M", "Actual type code and expected code do not match");
            Assert.That(newDescription == "mycode", "Actual description and expected code do not match");
            Assert.That(newPrice == "$12.00", "Actual price and expected code do not match");


        }

        [When(@"I update '([^']*)', '([^']*)', '([^']*)'on an existing time and material record")]
        public void WhenIUpdateOnAnExistingTimeAndMaterialRecord(string p0, string p1, string p2)
        {
            tMPageObj.EditTM(driver, p0, p1, p2);
        }

        [Then(@"the record should have the updated '([^']*)', '([^']*)', '([^']*)'")]
        public void ThenTheRecordShouldHaveTheUpdated(string p0, string p1, string p2)
        {
            string editedDescription = tMPageObj.GetEditedDescription(driver);
            string editedCode = tMPageObj.GetEdtedCode(driver);
            string editedPrice = tMPageObj.GetEdtedPrice(driver);

            Assert.That(editedDescription == p0, "Actual description and expected description do not nmatch");
            Assert.That(editedCode == p1, "Actual description and expected code do not nmatch");
            Assert.That(editedPrice == p2, "Actual description and expected price do not nmatch");
        }





    }
}
