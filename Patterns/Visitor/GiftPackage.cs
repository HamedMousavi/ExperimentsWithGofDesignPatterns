namespace Patterns.Visitor
{

    using System.Collections.Generic;


    public class GiftPackage : Element
    {

        public GiftPackage()
        {
            Items = new List<Element>();
        }


        public override void Accept(IVisitor visitor)
        {
            foreach (var item in Items)
            {
                item.Accept(visitor);
            }
        }


        public IList<Element> Items { get; private set; }
    }
}
