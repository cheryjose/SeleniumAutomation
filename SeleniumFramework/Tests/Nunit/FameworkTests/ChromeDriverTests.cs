using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SeleniumFramework.FrameWork;
using SeleniumFramework.FrameWork.UIOperations;
using SeleniumFramework.ObjectRepository;

namespace SeleniumFramework.Tests.Nunit.FameworkTests
{
    [TestFixture]   
    public class ChromeDriverTests
    {
        private Browser _browser;
        [SetUp]
        public void Setup()
        {
            _browser = new Browser();
        }

        [Test]
        public void ChromeDriverExecuteTest()
        {
            var url = "https://au.yahoo.com";
            _browser.Navigation.GoToUrl(url);
            _browser.NewsScreen.ClickNewsLink();
            _browser.UniversalNavigation.SelectFromUniversalNavigation("Yahoo7");
        }
    }
}
