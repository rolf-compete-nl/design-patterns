using VisitorExample.Visitors;

namespace VisitorExample.BaseVisited
{
    public class Email : BaseVisitee
    {
        public string EmailAddress { get; set; }
        public override void Accept(BaseVisiteeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}