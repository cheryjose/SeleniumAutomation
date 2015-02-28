using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Interactions;

namespace SeleniumFramework.FrameWork.UIOperations
{
    public class List 
    {
        private readonly RemoteWebDriver _webDriver;
        private readonly Actions _actions;
        public List(RemoteWebDriver webDriver)
        {
            _webDriver = webDriver;
            _actions = new Actions(_webDriver);
        }

        public IWebElement GetListElementById(string id)
        {
            var listElement = _webDriver.FindElement(By.XPath(id));
            return listElement;
        }

        public IWebElement GetListItemElementById(string id)
        {
            var listItemElement = _webDriver.FindElement(By.XPath(id));
            return listItemElement;
        }

        public void SelectListItemByText(string listId, string listItemId)
        {
            var listElement = GetListElementById(listId);
            var actions = _actions.ClickAndHold(listElement).Click(GetListItemElementById(listItemId)).Build();
            actions.Perform();
        }
    }
}
