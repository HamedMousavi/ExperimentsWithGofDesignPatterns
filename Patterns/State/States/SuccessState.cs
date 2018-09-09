// -----------------------------------------------------------------------
// <copyright file="SuccessState.cs" company="Microsoft">
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
    public class SuccessState : IState
    {
        private IStateContext _context;

        public SuccessState(IStateContext context)
        {
            _context = context;
        }

        public void ApplyForJob()
        {
            System.Diagnostics.Debug.WriteLine("NO LONGER NEEDED, I HAVE A JOB!!");
        }

        public void HandleRejection()
        {
            System.Diagnostics.Debug.WriteLine("But I was told to have the job. What happened?!");
            _context.SetState("Normal");
        }

        public void HandleSuccess()
        {
            System.Diagnostics.Debug.WriteLine("What success more than this?! :-P");
            
        }

        public void HowAreYou()
        {
            System.Diagnostics.Debug.WriteLine("I'm PERFECT!! I got a job!!!!");
        }
    }
}
