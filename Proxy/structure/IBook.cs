using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy.structure
{
    interface IBook : IDisposable
    {
        Page GetPage(int number);
    }
}
