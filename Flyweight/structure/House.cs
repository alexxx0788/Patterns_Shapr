using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flyweight.structure
{
    abstract class House
    {
        protected int stages; // количество этажей

        public abstract void Build(double longitude, double latitude);
    }
}
