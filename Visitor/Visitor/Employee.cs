using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    class Employee: IAccount
    {
        public string Name { get; set; }

        public string Posititon { get; set; }

        public string Number { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitEmployeeAcc(this);
        }
    }
}
