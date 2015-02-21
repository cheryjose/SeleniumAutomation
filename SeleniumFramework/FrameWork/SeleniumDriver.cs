using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using OpenQA.Selenium.Chrome;
using FrameWork = SeleniumFramework.FrameWork;

namespace SeleniumFramework.FrameWork
{
    public class SeleniumDriver
    {
        private ChromeOptions chromeOptions;
        public ChromeDriver ChromeDriver;
        private enum ChromeOptionsKey
        {
            ChromeDriverPath
        }

        public enum Driver
        {
            Chrome,
            Ie,
            Firefox
        }

        public SeleniumDriver(Driver driver)
        {
            switch(driver)
            {
                case Driver.Chrome:
                    chromeOptions = new ChromeOptions();
                    ChromeDriver = new ChromeDriver(SetChromeOptions());
                    break;
                case Driver.Ie:
                    break;
                case Driver.Firefox:
                    break;
            }
        }

        public ChromeOptions SetChromeOptions()
        {
            var binaryLocation = ConfigurationManager.AppSettings[ChromeOptionsKey.ChromeDriverPath.ToString()];
            chromeOptions.BinaryLocation = binaryLocation;
            return chromeOptions;
        }
    }
}
