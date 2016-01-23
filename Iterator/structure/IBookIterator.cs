using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator.structure
{
    interface IBookIterator
    {
        bool HasNext();
        Book Next();
    }
}
