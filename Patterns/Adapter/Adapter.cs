// -----------------------------------------------------------------------
// <copyright file="Adapter.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Patterns.Adopter
{
    using System;
    using System.Collections.Generic;
    
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Adapter : ITarget
    {
        private IAdaptee _adaptee;


        public Adapter(IAdaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public void DoSomething()
        {
            System.Diagnostics.Debug.WriteLine("Adapter asked to do something...");
            _adaptee.DoSomeOtherThing();
        }
    }
}
