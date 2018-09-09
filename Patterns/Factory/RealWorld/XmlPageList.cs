using System;
using System.Collections.Generic;

using System.Text;

namespace Patterns.Factory.RealWorld
{
    class XmlPageList : IPageList
    {
        public void Print()
        {
            System.Diagnostics.Debug.WriteLine(("Priintiinig xml pages"));
        }
    }
}
