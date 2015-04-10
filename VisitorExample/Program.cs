using System.Collections.Generic;
using VisitorExample.BaseVisited;
using VisitorExample.Visitors;

namespace VisitorExample
{
    class Program
    {
        private BaseVisitee Target;
    
        static void Main(string[] args)
        {
            var list = new List<BaseVisitee>
            {
                new Person("Rolf", "Toorn"),
                new Address() {City = "Middelburg", Street = "Generaal Eisenhowerlaan"},
                new Email() {EmailAddress = "rolf@compete.nl"},
                new Person("Iris", "Gouka"),
                new Address() {City = "Vlaardingen", Street = "Generaal Eisenhowerlaan"},
                new Email() {EmailAddress = "rolf@compete.nl"},
                new Person("Piet", "Water"),
                new Address() {City = "Schiedam", Street = "Generaal Eisenhowerlaan"},
                new Email() {EmailAddress = "rolf@compete.nl"}
            };

            var csv = new ToCsvVisitor();
            list.ForEach(a => a.Accept(csv));

            var html = new ToHtmlVisitor();
            list.ForEach(a => a.Accept(html));
        }
    }
}
