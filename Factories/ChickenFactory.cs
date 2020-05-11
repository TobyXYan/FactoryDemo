using FactoryDemo.Animals;
using FactoryDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDemo.Factories
{
    public class ChickenFactory:IFactory
    {
        public IAnimal CreateAnimal()
        {
            return new Chicken();
        }
    }
}
