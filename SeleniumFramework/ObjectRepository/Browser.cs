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
    public class Browser 
    {
        private readonly SeleniumDriver _seleniumDriver;
        public readonly Navigation Navigation;
        public readonly HomeScreen HomeScreen;
        public readonly NewsScreen NewsScreen;
        public readonly UniversalNavigation UniversalNavigation;
        public Browser()
        {
            _seleniumDriver = new SeleniumDriver();
            _seleniumDriver.WebDriver.Manage().Window.Maximize();
            Navigation = new Navigation(_seleniumDriver.WebDriver);
            HomeScreen = new HomeScreen(_seleniumDriver.WebDriver);
            NewsScreen = new NewsScreen(_seleniumDriver.WebDriver);
            UniversalNavigation = new UniversalNavigation(_seleniumDriver.WebDriver);
        }
    }
}
