// -----------------------------------------------------------------------
// <copyright file="NervousState.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Patterns.State
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class InterviewState : IState
    {
        IStateContext _context;


        public InterviewState(IStateContext context)
        {
            _context = context;
        }


        public void ApplyForJob()
        {
            System.Diagnostics.Debug.WriteLine("I have an interview, no need to!!!!");
        }


        public void HowAreYou()
        {
            System.Diagnostics.Debug.WriteLine("VERY GOOD! I am seriously nervious but very good, I have an interview!!");
        }


        public void HandleRejection()
        {
            System.Diagnostics.Debug.WriteLine("Rejected from interview, alchol anyone?! :-(");
            _context.SetState("Normal"); _context.SetState("Normal");
        }

        public void HandleSuccess()
        {
            System.Diagnostics.Debug.WriteLine("Are you serious?! It's the best day of my life!!!! :-D LET'S PARTY!!!");
            _context.SetState("Success");
        }
    }
}
