using System;
using TechTalk.SpecFlow;

namespace my_code.StepDefinitions
{
    [Binding]
    public class TMFeatureStepDefinitions
    {
        [Given(@"I logged into TurnUp portal successfully")]
        public void GivenILoggedIntoTurnUpPortalSuccessfully()
        {
            throw new PendingStepException();
        }

        [Given(@"I navigate to time and material page")]
        public void GivenINavigateToTimeAndMaterialPage()
        {
            throw new PendingStepException();
        }

        [When(@"I create time and material record")]
        public void WhenICreateTimeAndMaterialRecord()
        {
            throw new PendingStepException();
        }

        [Then(@"the record should be created sucessfully")]
        public void ThenTheRecordShouldBeCreatedSucessfully()
        {
            throw new PendingStepException();
        }
    }
}
