using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDemo.Interfaces
{
    public interface IFactory
    {
        IAnimal CreateAnimal();
    }
}
