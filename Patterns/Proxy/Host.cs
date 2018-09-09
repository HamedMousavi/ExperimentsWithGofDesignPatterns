// -----------------------------------------------------------------------
// <copyright file="Host.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Patterns.Proxy
{
    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Host : ISubject
    {
        public void Function()
        {
            System.Diagnostics.Debug.WriteLine("Host does the real job!");
        }
    }
}
