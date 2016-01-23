using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator.structure
{
    class ItalianPizza : Pizza
    {
        public ItalianPizza()
            : base("Итальянская пицца")
        { }
        public override int GetCost()
        {
            return 10;
        }
    }
}
