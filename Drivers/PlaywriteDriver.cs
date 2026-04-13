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
        private IPlaywright _playwright { get; set; }= null;
        private IBrowser _browser { get; set; } = null;
        private readonly Task<IPage> _page;

        public PlaywriteDriver()
        {
            _page = initializePlaywright();
        }

        public IPage Page => _page.Result;

        public async Task<IPage> initializePlaywright()
        {
            _playwright = await Playwright.CreateAsync();
            _browser = await _playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false
            });
           
            return await _browser.NewPageAsync();
        }

        public async Task DisposeAsync()
        {
            if (Page != null)
            {
                await Page.CloseAsync();
            }
            if (_browser != null)
            {
                await _browser.CloseAsync();
            }
            if (_playwright != null)
            {
                _playwright.Dispose();
            }

        }
    }
}
