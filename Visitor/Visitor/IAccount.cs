using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    interface IAccount
    {
        void Accept(IVisitor visitor);
    }
}
