using System;

namespace Visitor
{
    class VisitorClient
    {
        static void Main(string[] args)
        {
            var company = new Company();
            company.Add(new Client { Name = "Tom", Number = "4141241" });
            company.Add(new Employee { Name = "Jenis", Posititon = "General", Number = "39181244" });
            company.Accept(new HtmlVisitor());

            Console.Read();
        }
    }
}
