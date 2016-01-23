using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator.structure
{
    class BulgerianPizza : Pizza
    {
        public BulgerianPizza()
            : base("Болгарская пицца")
        { }
        public override int GetCost()
        {
            return 8;
        }
    }
}
