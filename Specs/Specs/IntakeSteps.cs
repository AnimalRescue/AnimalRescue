using System;
using TechTalk.SpecFlow;
using TestingFramework;

namespace Specs
{
    [Binding]
    public class IntakeSteps
    {
        [Given(@"The user is logged in")]
        public void GivenTheUserIsLoggedIn()
        {
            var c = new Class1();
            c.Go();
        }
        
        [Given(@"The user has intake permission")]
        public void GivenTheUserHasIntakePermission()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"The user does not have intake permission")]
        public void GivenTheUserDoesNotHaveIntakePermission()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"The user is authorized")]
        public void GivenTheUserIsAuthorized()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"The user is at the intake screen")]
        public void GivenTheUserIsAtTheIntakeScreen()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"The user attempts to perform intake")]
        public void WhenTheUserAttemptsToPerformIntake()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"The user has not selected an animal type")]
        public void WhenTheUserHasNotSelectedAnAnimalType()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"The user has selected an animal type")]
        public void WhenTheUserHasSelectedAnAnimalType()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the intake screen should be displayed")]
        public void ThenTheIntakeScreenShouldBeDisplayed()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"A user-not-authorized error message should be displayed")]
        public void ThenAUser_Not_AuthorizedErrorMessageShouldBeDisplayed()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"The screen cannot be submitted")]
        public void ThenTheScreenCannotBeSubmitted()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"The screen can be submitted")]
        public void ThenTheScreenCanBeSubmitted()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
