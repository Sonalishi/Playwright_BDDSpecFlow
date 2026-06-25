using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_BDDSpecFlow.PageObjects
{
    public class E2E
    {
        private IPage _page;

        public E2E(IPage page)
        {
            _page = page;
        }
        public async Task AdminE2E()
{
    await _page.GotoAsync("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
    await _page.GetByRole(AriaRole.Textbox, new() { Name = "Username" }).FillAsync("Admin");
    await _page.GetByRole(AriaRole.Textbox, new() { Name = "Password" }).FillAsync("admin123");
    await _page.GetByRole(AriaRole.Button, new() { Name = "Login" }).ClickAsync();
    await _page.GetByRole(AriaRole.Link, new() { Name = "Admin" }).ClickAsync();
    await _page.GetByRole(AriaRole.Textbox).Nth(1).ClickAsync();
    await _page.GetByRole(AriaRole.Textbox).Nth(1).FillAsync("Admin");
    await _page.GetByText("-- Select --").First.ClickAsync();
    await _page.GetByRole(AriaRole.Option, new() { Name = "Admin" }).ClickAsync();
    await _page.GetByRole(AriaRole.Textbox, new() { Name = "Type for hints..." }).ClickAsync();
    await _page.GetByRole(AriaRole.Textbox, new() { Name = "Type for hints..." }).FillAsync("AdminA");
    await _page.GetByText("AdminAuto QA User").ClickAsync();
    await _page.GetByText("-- Select --").ClickAsync();
    await _page.GetByRole(AriaRole.Option, new() { Name = "Enabled" }).ClickAsync();
    await _page.GetByRole(AriaRole.Button, new() { Name = "Search" }).ClickAsync();
    await _page.GetByText("(1) Record Found").ClickAsync();
}
    }
}

