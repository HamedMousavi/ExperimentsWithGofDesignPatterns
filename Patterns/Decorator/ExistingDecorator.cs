namespace Patterns.Decorator
{
    public class ExistingDecorator : ExistingClass
    {
        private readonly ExistingClass _wrapped;

        public ExistingDecorator(ExistingClass existing)
        {
            _wrapped = existing;
        }
    
        public override void Functionality()
        {
            _wrapped.Functionality();
        }
    }
}
