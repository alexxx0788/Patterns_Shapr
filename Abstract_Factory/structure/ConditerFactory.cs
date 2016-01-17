using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.structure
{
    abstract class Confectionery
    {
        public abstract Cake MakeCake();
        public abstract List<Muffin> MakeMuffins(int number);
        public abstract List<Profiterole> MakeProfiteroles(int number);
    }
}
