// -----------------------------------------------------------------------
// <copyright file="Applied.cs" company="Microsoft">
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
    public class AppliedState : IState
    {
        private IStateContext _context;

        public AppliedState(IStateContext context)
        {
            _context = context;
        }


        public void ApplyForJob()
        {
            System.Diagnostics.Debug.WriteLine("I already did. Waiting for response now...");
        }

        public void HandleRejection()
        {
            _context.SetState("Normal");
        }

        public void HandleSuccess()
        {
            System.Diagnostics.Debug.WriteLine("YAY, got an interview!!");
            _context.SetState("Interview");
        }

        public void HowAreYou()
        {
            System.Diagnostics.Debug.WriteLine("I'm good, sent some resumes, hoping to get a replys. :)");

        }
    }
}
