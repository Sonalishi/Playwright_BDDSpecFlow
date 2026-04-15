using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;

namespace Playwright_BDDSpecFlow.PageObjects
{
    public class Dashboard
    {
        private IPage _page;
        public Dashboard(IPage page)
        {
            _page = page;
        }


        private ILocator Admin_Menu => _page.Locator("a[href=\"/web/index.php/admin/viewAdminModule\"]");
         
        private ILocator PIM_Menu => _page.Locator("a[href=\"/web/index.php/pim/viewPimModule\"]");
        private ILocator Leave_Menu => _page.Locator("a[href=\"/web/index.php/leave/viewLeaveModule\"]");
        private ILocator Claim_Menu => _page.Locator("a[href=\"/web/index.php/claim/viewClaimModule\"]");
        private ILocator Recruitment_Menu => _page.Locator("a[href=\"/web/index.php/recruitment/viewRecruitmentModule\"]");


        public async Task ClickElement(String Menu)
        {
            if (Menu == "Admin")
            {
                await Admin_Menu.ClickAsync();
            }
            else if (Menu == "PIM")
            {
                await PIM_Menu.ClickAsync();
            }
            else if (Menu == "Leave")
            {
                await Leave_Menu.ClickAsync();
            }
            else if (Menu == "Claim")
            {
                await Claim_Menu.ClickAsync();
            }
            else if (Menu == "Recruitment")
            {
                await Recruitment_Menu.ClickAsync();
            }
            else
            {
                throw new ArgumentException("Invalid Menu Name");
            }
        }       


    }
}
