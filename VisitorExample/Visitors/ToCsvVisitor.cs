using System;
using VisitorExample.BaseVisited;

namespace VisitorExample.Visitors
{
    public class ToCsvVisitor : BaseVisiteeVisitor
    {
        public override void Visit(BaseVisitee visited)
        {
            Console.WriteLine(" ..... ");
        }

        public override void Visit(Person person)
        {
            Console.WriteLine("{0};{1}", person.FirstName, person.LastName);
        }

        public override void Visit(Address address)
        {
            Console.WriteLine("{0};{1}", address.Street, address.City);

        }

        public override void Visit(Email email)
        {
            Console.WriteLine("{0};", email.EmailAddress);
        }
    }
}