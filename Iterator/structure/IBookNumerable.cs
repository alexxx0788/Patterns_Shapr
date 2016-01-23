using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator.structure
{
    interface IBookNumerable
    {
        IBookIterator CreateNumerator();
        int Count { get; }
        Book this[int index] { get; }
    }
}
