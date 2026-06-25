using Playwright_BDDSpecFlow.Drivers;
using Playwright_BDDSpecFlow.PageObjects;
using Reqnroll;
using System;

namespace Playwright_BDDSpecFlow.StepDefinitions
{
    [Binding]
    public class E2EScenariosStepDefinition
    {
        private readonly PlaywriteDriver driver;
        private readonly E2E _e2e;
        public E2EScenariosStepDefinition(PlaywriteDriver driver)
        {
            this.driver = driver;
           _e2e = new E2E(driver.Page);
        }

        [Given("the user completes Admin flow")]
        public void GivenTheUserCompletesAdminFlow()
        {
            _e2e.AdminE2E();
        }

    }
}
