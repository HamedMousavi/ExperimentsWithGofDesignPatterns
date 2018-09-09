// -----------------------------------------------------------------------
// <copyright file="PlaneAutoPilot.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Patterns.TemplateMethod
{
    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public abstract class PlaneAutoPilot
    {
        private double _altitude;


        public void Takeoff()
        {
            _altitude = 0.0;

            System.Diagnostics.Debug.WriteLine($"{GetPlaneName()} auto pilot started takeoff process...");
            EgniteEngine();
            LooseBreaks();
            TakeoffAt(GetTakeoffSpeed());
            PullInLandingGears();
            System.Diagnostics.Debug.WriteLine($"{GetPlaneName()} auto pilot completed takeoff process.");
        }


        private static void PullInLandingGears()
        {
            System.Diagnostics.Debug.WriteLine("Pulling lading gears in...");
        }


        private static void TakeoffAt(double speed)
        {
            PullHandleStick(speed);
        }


        private static void PullHandleStick(double degrees)
        {
            System.Diagnostics.Debug.WriteLine(
                $"HandleStick {degrees} degreese");
        }


        private static void LooseBreaks()
        {
            System.Diagnostics.Debug.WriteLine("Breaks released...");
        }


        protected abstract double GetTakeoffSpeed();
        protected abstract void EgniteEngine();
        protected abstract string GetPlaneName();
    }
}
