namespace Patterns.Visitor
{
    public class AccountatntVisitor : IVisitor, IAccountingData
    {
        public int TotalCount { get; set; }

        public int TotalPrice { get; set; }


        public void VisitElectronicBookReader(ElectronicBookReader electronicBookReader)
        {
            TotalCount++;
            TotalPrice += electronicBookReader.Price;
        }

        public void VisitBook(Book book)
        {
            TotalCount++;
            TotalPrice += book.Price;
        }
    }
}
