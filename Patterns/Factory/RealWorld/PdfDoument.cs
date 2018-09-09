using System;
using System.Collections.Generic;

using System.Text;

namespace Patterns.Factory.RealWorld
{
    public class PdfDoument : Document
    {
        public override void Create()
        {
            _pages = new PdfPageList();
        }
    }
}
