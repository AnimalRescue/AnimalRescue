using System;
using TechTalk.SpecFlow;
using TestingFramework;

namespace Specs.Steps
{
    [Binding]
    public class IntakeSteps
    {
        [Given(@"the user is an authorized to perform intake")]
        public void GivenTheUserIsAnAuthorizedToPerformIntake()
        {
            var c = new Class1();
            c.Go();
        }
        
        [When(@"a new animal is taken into the rescue")]
        public void WhenANewAnimalIsTakenIntoTheRescue()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the animal's type must be recorded from a pre-populated list")]
        public void ThenTheAnimalSTypeMustBeRecordedFromAPre_PopulatedList()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
