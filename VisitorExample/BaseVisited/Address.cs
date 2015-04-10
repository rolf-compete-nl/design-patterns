using VisitorExample.Visitors;

namespace VisitorExample.BaseVisited
{
    public class Address : BaseVisitee
    {
        public string Street { get; set; }
        public string City { get; set; }
        public override void Accept(BaseVisiteeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}