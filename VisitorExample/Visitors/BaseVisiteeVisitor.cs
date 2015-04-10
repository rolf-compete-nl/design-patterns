using VisitorExample.BaseVisited;

namespace VisitorExample.Visitors
{
    public abstract class BaseVisiteeVisitor
    {
        public abstract void Visit(BaseVisitee visited);
        public abstract void Visit(Person visited);
        public abstract void Visit(Address visited);
        public abstract void Visit(Email email);

    }
}