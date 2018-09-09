using System;

namespace Patterns.Factory.AbstractMethod
{
    public class GermanFactory : FlowerFactory
    {
        public override IFlower CreateFlower(string name)
        {
            return string.Equals(name, "Rose", StringComparison.InvariantCultureIgnoreCase) ? new Flowers.GermanRose() : null;
        }
    }
}
