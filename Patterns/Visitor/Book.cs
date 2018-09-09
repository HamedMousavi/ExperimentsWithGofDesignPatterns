namespace Patterns.Visitor
{
    public class Book : Element
    {

        public int Price { get; set; }

        public string Title { get; set; }


        public override void Accept(IVisitor visitor)
        {
            visitor.VisitBook(this);
        }
    }
}
