using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Remote;

namespace SeleniumFramework.FrameWork.UIOperations
{
    public class Navigation
    {
        private RemoteWebDriver _webDriver;

        public Navigation(RemoteWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public void GoToUrl(string url)
        {
            _webDriver.Navigate().GoToUrl(url);
        }
    }
}
