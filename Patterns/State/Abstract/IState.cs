﻿// -----------------------------------------------------------------------
// <copyright file="IState.cs" company="Microsoft">
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
    public interface IState
    {
        void ApplyForJob();
        void HandleRejection();
        void HandleSuccess();
        void HowAreYou();
    }
}
