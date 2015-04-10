using System;
using VisitorExample.BaseVisited;

namespace VisitorExample.Visitors
{
    public class ToHtmlVisitor : BaseVisiteeVisitor
    {
        public override void Visit(BaseVisitee visited)
        {
            Console.WriteLine(" ..... ");
        }

        public override void Visit(Person visited)
        {
            Console.WriteLine("<person>{0} {1}</person>", visited.FirstName, visited.LastName);            
        }

        public override void Visit(Address visited)
        {
            Console.WriteLine("<address>{0} {1}</address>", visited.Street, visited.City);
        }

        public override void Visit(Email email)
        {
            Console.WriteLine("<email>{0}</email>", email.EmailAddress);
        }
    }
}