using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Asia : ContinentFactory
    {
        public override Herbivore Herbivore()
        {
            return new RainDeer();
        }
        public override Carnivore Carnivore()
        {
            return new Tiger();
        }
    }
}
