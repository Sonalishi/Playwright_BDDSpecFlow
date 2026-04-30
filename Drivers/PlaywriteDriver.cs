using Microsoft.Extensions.Configuration;

using Microsoft.Playwright;
using Playwright_BDDSpecFlow.Manager;
using Reqnroll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_BDDSpecFlow.Drivers
{
    public class PlaywriteDriver
    {
        private IPlaywright _playwright { get; set; } = null;
        private IBrowser _browser { get; set; } = null;
        private IBrowserContext _context { get; set; } = null;
        private readonly Task<IPage> _page;
        private static IConfigurationRoot config;

        public PlaywriteDriver()
        {
            _page = initializePlaywright();
        }

        public IPage Page => _page.Result;

        public async Task<IPage> initializePlaywright()
        {
        
            bool HeadlessValue =ConfigManager.Instance.GetHeadlessMode();
            string browserName = ConfigManager.Instance.GetBrowserVersion();
            _playwright = await Playwright.CreateAsync();
            
            _browser = browserName switch
            {
                "Firefox" => await _playwright.Firefox.LaunchAsync(new() { Headless = HeadlessValue }),
                "Webkit" => await _playwright.Webkit.LaunchAsync(new() { Headless = HeadlessValue }),
                "Chromium" => await _playwright.Chromium.LaunchAsync(new() { Headless = HeadlessValue })
            };
            /*_browser = await _playwright.+"s"+.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = HeadlessValue
            });*/
            _context = await _browser.NewContextAsync(new()
            {
                RecordVideoDir = "videos/"
            });

            return await _context.NewPageAsync();
        }

        
        public async Task DisposeAsync(ScenarioContext scenarioContext)
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
            if(_context != null)
            {
                await _context.CloseAsync();
            }
           
        }
    }
}
