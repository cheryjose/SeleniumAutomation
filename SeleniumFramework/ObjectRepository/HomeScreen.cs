using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumFramework.FrameWork;
using SeleniumFramework.ObjectRepository;
using SeleniumFramework.FrameWork.UIOperations;

namespace SeleniumFramework.ObjectRepository
{
    public class HomeScreen 
    {
        private readonly SeleniumDriver _seleniumDriver;
        public readonly Browser Browser;
        public readonly NewsScreen NewsScreen;
        public HomeScreen()
        {
            _seleniumDriver = new SeleniumDriver();
            Browser = new Browser(_seleniumDriver.WebDriver);
            NewsScreen = new NewsScreen(_seleniumDriver.WebDriver);
        }
    }
}
