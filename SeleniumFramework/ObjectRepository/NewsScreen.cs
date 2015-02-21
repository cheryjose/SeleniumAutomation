using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumFramework.FrameWork;

namespace SeleniumFramework.ObjectRepository
{
    public class NewsScreen : CommonUIOperations
    {
        public string NewsLinkXpathId = "//Div/Ul/Li/a[text()='News']";

        public NewsScreen(object webDriver):base(webDriver)
        {

        }

        public void ClickNewsLink()
        {
            Link.ClickLinkByXpath(NewsLinkXpathId);
        }
    }
}
