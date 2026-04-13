using System;
using Reqnroll;

namespace Playwright_BDDSpecFlow.StepDefinitions
{
    [Binding]
    public class LoginScenariosStepDefinitions
    {
        [Given("the user is on the login page")]
        public void GivenTheUserIsOnTheLoginPage()
        {
            throw new PendingStepException();
        }

        [When("the user enters a valid username {string}")]
        public void WhenTheUserEntersAValidUsername(string p0)
        {
            throw new PendingStepException();
        }

        [When("the user enters a valid password {string}")]
        public void WhenTheUserEntersAValidPassword(string p0)
        {
            throw new PendingStepException();
        }

        [When("the user clicks the {string} button")]
        public void WhenTheUserClicksTheButton(string login)
        {
            throw new PendingStepException();
        }

        [Then("the user should be redirected to the homepage\\/dashboard")]
        public void ThenTheUserShouldBeRedirectedToTheHomepageDashboard()
        {
            throw new PendingStepException();
        }

        [When("the user enters an incorrect password {string}")]
        public void WhenTheUserEntersAnIncorrectPassword(string p0)
        {
            throw new PendingStepException();
        }

        [Then("the user should see an error message {string}")]
        public void ThenTheUserShouldSeeAnErrorMessage(string p0)
        {
            throw new PendingStepException();
        }

        [Then("the user should remain on the login page")]
        public void ThenTheUserShouldRemainOnTheLoginPage()
        {
            throw new PendingStepException();
        }

        [When("the user enters a non-existent username {string}")]
        public void WhenTheUserEntersANon_ExistentUsername(string p0)
        {
            throw new PendingStepException();
        }

        [When("the user enters any password {string}")]
        public void WhenTheUserEntersAnyPassword(string p0)
        {
            throw new PendingStepException();
        }

    }
}
