using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor.structure
{
    interface IAccount
    {
        void Accept(IVisitor visitor);
    }
}
