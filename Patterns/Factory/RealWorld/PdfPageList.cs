using System;
using System.Collections.Generic;

using System.Text;

namespace Patterns.Factory.RealWorld
{
    public class PdfPageList : IPageList
    {
        public void Print()
        {
            System.Diagnostics.Debug.WriteLine(("Priintiinig PDF pagees"));
        }
    }
}
