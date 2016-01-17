using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.structure
{
    class CityCenterConfectionery : Confectionery
    {
        public override Cake MakeCake()
        {
            return new PragueCake("an amazing Prague Cake");
        }

        public override List<Muffin> MakeMuffins(int number)
        {
            List<Muffin> muffins = new List<Muffin>();
            for (int i = 0; i < number; i++)
            {
                muffins.Add(new FrenchMuffin(String.Format("a beautiful French Muffin {0}", i + 1)));
            }
            return muffins;
        }

        public override List<Profiterole> MakeProfiteroles(int number)
        {
            List<Profiterole> profiteroles = new List<Profiterole>();
            for (int i = 0; i < number; i++)
            {
                profiteroles.Add(new ChocolateProfiterole(String.Format("a lovely Chocolate Profiterol {0}", i + 1)));
            }
            return profiteroles;
        }
    }
}
