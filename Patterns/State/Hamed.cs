// -----------------------------------------------------------------------
// <copyright file="Hamed.cs" company="Microsoft">
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
    public class Hamed : IStateContext
    {
        private Dictionary<string, IState> _states;

        public Hamed()
        {
            CreateStates();
        }

        private void CreateStates()
        {
            _states = new Dictionary<string, IState>();
            _states.Add("Normal", new NormalState(this));
            _states.Add("Interview", new InterviewState(this));
            _states.Add("Success", new SuccessState(this));
            _states.Add("Applied", new AppliedState(this));

            State = _states["Normal"];
        }

        public IState State { get; set; }

        public IState GetState(string stateName)
        {
            return _states[stateName];
        }

        public void ApplyForAJob()
        {
            State.ApplyForJob();
        }

        public void HandleRejection()
        {
            State.HandleRejection();
        }

        public void HandleSuccess()
        {
            State.HandleSuccess();
        }

        public void HowAreYou()
        {
            State.HowAreYou();
        }

        public void SetState(string key)
        {
            State = GetState(key);
        }
    }
}
