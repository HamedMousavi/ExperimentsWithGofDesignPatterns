// -----------------------------------------------------------------------
// <copyright file="ConcreeteTarget.cs" company="Microsoft">
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
    public class ConcreeteTarget : ITarget
    {
        public void DoSomething()
        {
            System.Diagnostics.Debug.WriteLine("ConcreeteTarget doing something...");
        }
    }
}
