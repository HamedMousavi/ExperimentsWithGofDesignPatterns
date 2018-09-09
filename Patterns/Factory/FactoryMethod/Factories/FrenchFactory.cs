using System;

namespace Patterns.Factory.AbstractMethod
{
    public class FrenchFactory : FlowerFactory
    {
        public override IFlower CreateFlower(string name)
        {
            return string.Equals(name, "Rose", StringComparison.InvariantCultureIgnoreCase) ? new Flowers.FrenchRose() : null;
        }
    }
}
