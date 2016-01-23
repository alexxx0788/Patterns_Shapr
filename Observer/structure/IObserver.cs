using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer.structure
{
    interface IObserver
    {
        void Update(Object ob);
    }
}
