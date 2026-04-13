using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_BDDSpecFlow.PageObjects
{
    public class LoginPage
    {
        private IPage _page;

        public LoginPage(IPage page)
        {
            _page = page;
        }

        private ILocator UsernameInput => _page.Locator("input[name='username']");
        private ILocator PasswordInput => _page.Locator("input[name='password']");
        private ILocator LoginButton => _page.Locator("button[type='submit']");

        public async Task EnterUsername(string username)
        {
            await UsernameInput.FillAsync(username);
        }

        public async Task EnterPassword(string password)
        {
            await PasswordInput.FillAsync(password);
        }
   
        public async Task ClickLoginButton()
        {
            await LoginButton.ClickAsync();
        }
    }
}
