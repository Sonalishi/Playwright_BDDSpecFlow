using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_BDDSpecFlow.Drivers
{
    public class PlaywriteDriver
    {

        private readonly Task<IPage> _page;

        public PlaywriteDriver()
        {
            _page = initializePlaywright();
        }

        public IPage Page => _page.Result;

        public async Task<IPage> initializePlaywright()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false
            });
           // var context = await browser.NewContextAsync();
            return await browser.NewPageAsync();
        }
    }
}
