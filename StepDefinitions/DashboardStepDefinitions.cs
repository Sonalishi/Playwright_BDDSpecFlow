using Playwright_BDDSpecFlow.Drivers;
using Playwright_BDDSpecFlow.PageObjects;
using Reqnroll;
using System;

namespace Playwright_BDDSpecFlow.StepDefinitions
{
    [Binding]
    public class DashboardStepDefinitions
    {
        private readonly PlaywriteDriver driver;
        private readonly Dashboard _dashboard;
        public DashboardStepDefinitions(PlaywriteDriver driver)
        {
            this.driver = driver;
            _dashboard = new Dashboard(driver.Page);
        }


        [Given("the user is on Dashboard page")]
        public async Task GivenTheUserIsOnDashboardPage()
        {
            await driver.Page.WaitForURLAsync("https://opensource-demo.orangehrmlive.com/web/index.php/dashboard/index");

        }

        [When("the user click on {string} option")]
        public async Task WhenTheUserClickOnMenuOption(string menu)
        {
            await _dashboard.ClickElement(menu);
        }

        [Then("the user should navigate to {string} page")]
        public void ThenTheUserShouldNavigateToPage(string menu)
        {
            if (menu == "Admin")
            {
                 driver.Page.WaitForURLAsync("https://opensource-demo.orangehrmlive.com/web/index.php/admin/viewSystemUsers");
                driver.Page.GoBackAsync();
            }
            else if (menu == "PIM")
            {
                driver.Page.WaitForURLAsync("https://opensource-demo.orangehrmlive.com/web/index.php/pim/viewEmployeeList");
                driver.Page.GoBackAsync();
            }
            else if (menu == "Leave")
            {
                driver.Page.WaitForURLAsync("https://opensource-demo.orangehrmlive.com/web/index.php/leave/viewLeaveList");
                driver.Page.GoBackAsync();
            }
            else if (menu == "Claim")
            {
                driver.Page.WaitForURLAsync("https://opensource-demo.orangehrmlive.com/web/index.php/leave/viewLeaveList");
                driver.Page.GoBackAsync();  
            }
            else if (menu == "Recruitment")
            {
                driver.Page.WaitForURLAsync("https://opensource-demo.orangehrmlive.com/web/index.php/recruitment/viewRecruitmentModule");
                driver.Page.GoBackAsync();
            }
            

        }


    }
}
