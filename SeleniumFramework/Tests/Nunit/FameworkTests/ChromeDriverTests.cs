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
        private HomeScreen _homeScreen;
        [SetUp]
        public void Setup()
        {
            _homeScreen = new HomeScreen();
        }

        [Test]
        public void ChromeDriverExecuteTest()
        {
            var url = "https://au.yahoo.com";
            _homeScreen.Navigation.GoToUrl(url);
        }
    }
}
