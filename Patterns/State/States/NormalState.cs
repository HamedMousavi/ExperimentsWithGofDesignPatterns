// -----------------------------------------------------------------------
// <copyright file="NormalState.cs" company="Microsoft">
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
    public class NormalState : IState
    {
        readonly IStateContext _context;

        public NormalState(IStateContext context)
        {
            _context = context;
        }

        public void ApplyForJob()
        {
            _context.SetState("Applied");
        }


        public void HowAreYou()
        {
            System.Diagnostics.Debug.WriteLine("I'm ok, need a job though. :)");
        }


        public void HandleRejection()
        {
            System.Diagnostics.Debug.WriteLine("Are you crazy? Rejection from what now?!!");
        }

        public void HandleSuccess()
        {
            System.Diagnostics.Debug.WriteLine("Success in what now?!!");
        }
    }
}
