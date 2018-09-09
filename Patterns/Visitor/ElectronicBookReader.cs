namespace Patterns.Visitor
{
    public class ElectronicBookReader : Element
    {

        public int Price
        {
            get { return 200; }
        }

        public string ModelName
        {
            get { return "Prs-T1"; }
        }

        public string BrandName
        {
            get { return "Sony"; }
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitElectronicBookReader(this);
        }
    }
}
