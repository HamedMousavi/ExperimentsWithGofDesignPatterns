namespace Patterns.Visitor
{
    public interface IVisitor
    {
        void VisitElectronicBookReader(ElectronicBookReader electronicBookReader);

        void VisitBook(Book book);
    }
}
