namespace Patterns.Visitor
{
    public interface IAccountingData
    {
        int TotalCount { get; set; }

        int TotalPrice { get; set; }
    }
}
