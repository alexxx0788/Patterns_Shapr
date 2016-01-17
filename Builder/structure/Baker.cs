using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.structure
{
    // пекарь
    class Baker
    {
        public void Bake(BreadBuilder breadBuilder)
        {
            breadBuilder.SetWheatFlour();
            breadBuilder.SetRyeFlour();
            breadBuilder.SetSalt();
            breadBuilder.SetAdditives();
        }
    }
}
