
namespace Patterns.Decorator
{
    internal class ExtendedClass2 : ExistingDecorator
    {

        public ExtendedClass2(ExistingClass existing) :
            base(existing)
        {
        }

        public override void Functionality()
        {
            System.Diagnostics.Debug.WriteLine("ExtendedClass2 Functionality AND ");

            base.Functionality();
        } 
    }
}
