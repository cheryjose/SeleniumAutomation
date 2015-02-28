using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Document
    {
        private List<Page> _pages = new List<Page>();

        public Document()
        {

        }

        public List<Page> Pages
        {
            get { return _pages; }
        }

        public abstract void CreateDocument();
    }
}
