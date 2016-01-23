using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor.structure
{
    class Person : IAccount
    {
        public string Name { get; set; }
        public string Number { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitPersonAcc(this);
        }
    }
}
