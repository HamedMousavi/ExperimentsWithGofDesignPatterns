using System;
using System.Collections.Generic;

using System.Text;

namespace Patterns.Factory.AbstractMethod.Flowers
{
    public class FrenchRose : IFlower
    {
        public void Display()
        {
            System.Diagnostics.Debug.WriteLine("This is a French Rose.");
        }
    }
}
