
namespace Patterns.Decorator
{
    public class ExtendedClass1 : ExistingDecorator
    {

        public ExtendedClass1(ExistingClass existing) :
            base(existing)
        {
        }

        public override void Functionality()
        {
            System.Diagnostics.Debug.WriteLine("ExtendedClass1 Functionality AND ");

            base.Functionality();
        }
    }
}
