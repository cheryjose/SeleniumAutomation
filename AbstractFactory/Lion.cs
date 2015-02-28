using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Lion : Carnivore
    {
        public override void Eat(Herbivore herbivore)
        {
            Debug.WriteLine(string.Format("{0}_{1}", GetType().Name, herbivore.GetType().Name));
        }
    }
}
