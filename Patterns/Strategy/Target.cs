using Patterns.Strategy.Strategies;


namespace Patterns.Strategy
{

    public class Target
    {
        public IStrategy Strategy { get; set; }


        public Target(IStrategy strategy)
        {
            this.Strategy = strategy;
        }


        public void Run()
        {
            this.Strategy.Run();
        }
    }
}
