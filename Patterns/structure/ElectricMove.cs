using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patterns.structure
{
    class ElectricMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Moving via electric energy");
        }
    }
}
