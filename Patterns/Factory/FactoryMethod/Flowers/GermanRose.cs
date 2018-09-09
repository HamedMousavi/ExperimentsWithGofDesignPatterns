using System;
using System.Collections.Generic;

using System.Text;

namespace Patterns.Factory.AbstractMethod.Flowers
{
    public class GermanRose : IFlower
    {
        public void Display()
        {
            System.Diagnostics.Debug.WriteLine("This is a German Rose.");
        }
    }
}
