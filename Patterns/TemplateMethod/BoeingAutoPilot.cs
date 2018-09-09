// -----------------------------------------------------------------------
// <copyright file="BoeingAutoPilot.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Patterns.TemplateMethod
{
    using System;
    using System.Collections.Generic;
    
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class BoeingAutoPilot : PlaneAutoPilot
    {
        protected override double GetTakeoffSpeed()
        {
            return 98.85;
        }

        protected override void EgniteEngine()
        {
            System.Diagnostics.Debug.WriteLine("Boeing engines started!");
        }

        protected override string GetPlaneName()
        {
            return "Boeing 777";
        }
    }
}
