using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Remote;

namespace SeleniumFramework.FrameWork.UIOperations
{
    public class Link
    {
        private readonly RemoteWebDriver _webDriver;
        public Link(RemoteWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public void ClickLinkByText(string linkText)
        {
            var linkElement = _webDriver.FindElementByLinkText(linkText);
            linkElement.Click();
        }

        public void ClickLinkByXpath(string xpath)
        {
            var linkElement = _webDriver.FindElementByXPath(xpath);
            linkElement.Click();
        }
    }
}
