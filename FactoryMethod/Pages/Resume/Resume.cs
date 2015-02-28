using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Pages.Resume
{
    public class Resume : Document
    {
        public override void CreateDocument()
        {
            Pages.Add(new EducationalPage());
            Pages.Add(new SkillsPage());
            Pages.Add(new ExperiencePage());
        }
    }
}
