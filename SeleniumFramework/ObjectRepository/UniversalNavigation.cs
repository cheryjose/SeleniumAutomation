using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumFramework.FrameWork;

namespace SeleniumFramework.ObjectRepository
{
    public class UniversalNavigation : CommonUIOperations
    {
        private const string UniversalNavigationListId = "//nav/div/a[contains(span,'Universal')]";
        private const string UniversalNavigationItemId = "//nav/div/ol/li/a[contains(.,'{0}')]";
        private const string UniversalNavigationList = "Universal Navigation";
        
        private enum NavigationListItems
        {
            Yahoo7,
            news,
            tv,
            finance,
            sport,
            lifestyle,
            entertainment
        }

        public UniversalNavigation(object webDriver) : base(webDriver) 
        {

        }

        public void ClickUniversalNavigationIcon()
        {
            Link.ClickLinkByText(UniversalNavigationList);
        }

        public void SelectFromUniversalNavigation(string listItem)
        {
            NavigationListItems listItemVal;
            if(Enum.TryParse(listItem, true, out listItemVal)) 
            {
                List.SelectListItemByText(UniversalNavigationListId, string.Format(UniversalNavigationItemId, listItem));
            }
            else throw new Exception(string.Format("Invalid universal navigation list item '{0}'", listItemVal.ToString()));
        }
    }
}
