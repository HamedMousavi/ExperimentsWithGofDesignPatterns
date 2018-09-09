// -----------------------------------------------------------------------
// <copyright file="IStateContext.cs" company="Microsoft">
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
    public interface IStateContext
    {
        void ApplyForAJob();

        void HandleRejection();

        void HandleSuccess();

        void HowAreYou();

        void SetState(string key);
    }
}
