
namespace Patterns.Factory.RealWorld
{
    public abstract class Document
    {
        protected IPageList _pages;

        protected Document()
        {
            Create();
        }

        public abstract void Create();
        public void Print()
        {
            _pages.Print();
        }
    }
}
