using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    interface IVisitor
    {
        void VisitClientAcc(Client acc);

        void VisitEmployeeAcc(Employee acc);
    }
}
