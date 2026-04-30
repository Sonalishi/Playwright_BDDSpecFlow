using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json; // Add this using directive

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_BDDSpecFlow.Manager
{
    public class ConfigManager
    {
        public static ConfigManager _instance;
        public readonly IConfiguration _configuration;

        public ConfigManager()
        {
            var projectPath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\..\"));
            _configuration = new ConfigurationBuilder()
            .SetBasePath(projectPath)
            .AddJsonFile("appSettings.test.json")
            .Build();
        }

        public static ConfigManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ConfigManager();
                }
                return _instance;
            }
        }

        public string GetBaseUrl()
        {
            return _configuration["BaseUrl"];
        }

        public bool GetHeadlessMode()
        {
            return _configuration.GetValue<bool>("TestSettings:Headless");
            
        }

        public string GetBrowserVersion()
        {
            return _configuration.GetValue<string>("TestSettings:Browser");
        }

        }
}
