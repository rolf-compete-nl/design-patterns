using System.Diagnostics.Contracts;
using VisitorExample.Visitors;

namespace VisitorExample.BaseVisited
{
    public class Person : BaseVisitee
    {
        public Person(string firstName, string lastName)
        {
            Contract.Requires(!string.IsNullOrEmpty(firstName));
            Contract.Requires(!string.IsNullOrEmpty(lastName));
            
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public override void Accept(BaseVisiteeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}