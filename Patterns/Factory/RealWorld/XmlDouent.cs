﻿using System;
using System.Collections.Generic;

using System.Text;

namespace Patterns.Factory.RealWorld
{
    class XmlDouent : Document
    {
        public override void Create()
        {
            _pages = new XmlPageList();
        }
    }
}
