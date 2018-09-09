// -----------------------------------------------------------------------
// <copyright file="Airbus.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Patterns.TemplateMethod
{
    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class AirbusAutoPilot : PlaneAutoPilot
    {
        protected override double GetTakeoffSpeed()
        {
            return 120.85;
        }

        protected override void EgniteEngine()
        {
            System.Diagnostics.Debug.WriteLine("Airbus engines started!");
        }

        protected override string GetPlaneName()
        {
            return "AIRBUS C130";
        }
    }
}
