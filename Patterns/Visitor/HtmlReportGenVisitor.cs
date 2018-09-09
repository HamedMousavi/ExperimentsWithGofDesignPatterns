namespace Patterns.Visitor
{
    public class HtmlReportGenVisitor : IVisitor
    {
        private int _index;
        private readonly IAccountingData _accounting;
        private string _report;


        public HtmlReportGenVisitor(IAccountingData accounting)
        {
            _accounting = accounting;
            _index = 1;
        }


        public string Report
        {
            get
            {
                _report += System.Environment.NewLine;
                _report += "------------------------------------";
                _report += System.Environment.NewLine;

                _report += string.Format("Items: {0}", _accounting.TotalCount);
                _report += System.Environment.NewLine;
                _report += string.Format("Total cost: {0}", _accounting.TotalPrice);
                _report += System.Environment.NewLine;

                return _report;
            }
        }


        public void VisitElectronicBookReader(ElectronicBookReader electronicBookReader)
        {
            _report += string.Format("{0}.Reader: {1} {2}\t\t\t{3}", 
                _index,
                electronicBookReader.BrandName, 
                electronicBookReader.ModelName,
                electronicBookReader.Price);

            _report += System.Environment.NewLine;
            _index++;
        }

        public void VisitBook(Book book)
        {
            _report += string.Format("{0}.Book: {1}\t\t\t{2}", 
                _index,
                book.Title,
                book.Price);

            _report += System.Environment.NewLine;
            _index++;
        }
    }
}
