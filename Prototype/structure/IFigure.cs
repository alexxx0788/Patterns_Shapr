using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.structure
{
    interface IFigure
    {
        IFigure Clone();
        void GetInfo();
    }
}
