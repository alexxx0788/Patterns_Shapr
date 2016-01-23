using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor.structure
{
    interface IVisitor
    {
        void VisitPersonAcc(Person acc);
        void VisitCompanyAc(Company acc);
    }
}
