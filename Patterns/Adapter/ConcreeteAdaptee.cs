// -----------------------------------------------------------------------
// <copyright file="ConcreeteAdaptee.cs" company="Microsoft">
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
    public class ConcreeteAdaptee : IAdaptee
    {
        public void DoSomeOtherThing()
        {
            System.Diagnostics.Debug.WriteLine("Adaptee doing some other thing...");
        }
    }
}
