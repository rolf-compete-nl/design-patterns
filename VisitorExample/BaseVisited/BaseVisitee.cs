using VisitorExample.Visitors;

namespace VisitorExample.BaseVisited
{
    public abstract class BaseVisitee
    {
        public abstract void Accept(BaseVisiteeVisitor visitor);
    }
}