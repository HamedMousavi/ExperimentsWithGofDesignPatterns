using System;
using System.Collections.Generic;

using System.Text;

namespace Patterns.Factory.AbstractMethod
{
    public abstract class FlowerFactory
    {
        public abstract IFlower CreateFlower(string name);
    }
}
