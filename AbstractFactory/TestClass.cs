using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AbstractFactory
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void Test()
        {
            var africaFactory = new Africa();
            var animalWorld = new AnimalWorld(africaFactory);
            animalWorld.RunFoodChain();

            var asiaFactory = new Asia();
            var animalWorldAsia = new AnimalWorld(asiaFactory);
            animalWorldAsia.RunFoodChain();
        }
    }
}
