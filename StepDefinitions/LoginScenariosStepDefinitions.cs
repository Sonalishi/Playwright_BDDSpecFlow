using System;
using System.Threading.Tasks;
using Playwright_BDDSpecFlow.Drivers;
using Playwright_BDDSpecFlow.PageObjects;
using Reqnroll;

namespace Playwright_BDDSpecFlow.StepDefinitions
{
    [Binding]
    public class LoginScenariosStepDefinitions 
    {
        private readonly PlaywriteDriver driver;
        private readonly LoginPage _loginpage;
        public LoginScenariosStepDefinitions(PlaywriteDriver driver)
        {
                        this.driver = driver;
                        _loginpage = new LoginPage(driver.Page);
        }   


        [Given("the user is on the login page")]
        public void GivenTheUserIsOnTheLoginPage()
        {
            driver.Page.GotoAsync("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
        }

        [When("the user enters a valid username {string}")]
        public async Task WhenTheUserEntersAValidUsername(string username)
        {
            await _loginpage.EnterUsername(username);
        }

        [When("the user enters a valid password {string}")]
        public async Task WhenTheUserEntersAValidPassword(string password)
        {
            await _loginpage.EnterPassword(password);
        }           

        [When("the user clicks the {string} button")]
        public async Task WhenTheUserClicksTheButton(string login)
        {
            await _loginpage.ClickLoginButton();
        }

        [Then("the user should be redirected to the dashboard")]
        public async Task ThenTheUserShouldBeRedirectedToTheHomepageDashboard()
        {
            await driver.Page.WaitForURLAsync("https://opensource-demo.orangehrmlive.com/web/index.php/dashboard/index");
          // await ExpectedExceptionAttribute(driver.Page).ToHaveURLAsync("https://opensource-demo.orangehrmlive.com/web/index.php/dashboard/index");
            
        }
        /*
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
        }*/

    }
}
