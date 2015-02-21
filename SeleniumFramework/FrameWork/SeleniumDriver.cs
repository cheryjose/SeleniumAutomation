using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using FrameWork = SeleniumFramework.FrameWork;

namespace SeleniumFramework.FrameWork
{
    public class SeleniumDriver
    {
        public RemoteWebDriver WebDriver;
        private enum ChromeOptionsKey
        {
            ChromeDriverPath,
            Driver
        }

        public enum Driver
        {
            Chrome,
            Ie,
            Firefox
        }

        public SeleniumDriver()
        {
            var driver = (Driver)Enum.Parse(typeof(Driver), GetDriverNameFromConfig());
            switch(driver)
            {
                case Driver.Chrome:
                    WebDriver = new ChromeDriver(GetChromeDriverDirectoryFromConfig(), SetChromeOptions());
                    break;
                case Driver.Ie:
                    break;
                case Driver.Firefox:
                    break;
            }
        }

        public ChromeOptions SetChromeOptions()
        {
            var chromeOptions = new ChromeOptions();
            return chromeOptions;
        }

        public string GetChromeDriverDirectoryFromConfig()
        {
            var binaryLocation = ConfigurationManager.AppSettings[ChromeOptionsKey.ChromeDriverPath.ToString()];
            return binaryLocation;
        }

        public string GetDriverNameFromConfig()
        {
            var driverName = ConfigurationManager.AppSettings[ChromeOptionsKey.Driver.ToString()];
            return driverName;
        }
    }
}
