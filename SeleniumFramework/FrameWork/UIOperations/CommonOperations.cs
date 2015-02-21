using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Remote;
using SeleniumFramework.FrameWork.UIOperations;

namespace SeleniumFramework.FrameWork
{
    public class CommonUIOperations
    {
        private readonly RemoteWebDriver _webDriver;
        public readonly Navigation Navigation;
        public readonly Link Link;
        
        public CommonUIOperations(object driver)
        {
            _webDriver = (RemoteWebDriver)driver;
            Navigation = new Navigation(_webDriver);
            Link = new Link(_webDriver);
        }
    }
}
