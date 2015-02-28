using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using NUnit.Framework;
using FactoryMethod.Pages.Resume;

namespace FactoryMethod
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void Test()
        {
            var resume = new Resume();
            resume.CreateDocument();
            
            foreach(var page in resume.Pages)
            {
                Debug.WriteLine(string.Format("{0}_{1}", resume.GetType().Name, page.GetType().Name));
            }
        }
    }
}
