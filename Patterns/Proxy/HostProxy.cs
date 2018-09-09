// -----------------------------------------------------------------------
// <copyright file="Proxy.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Patterns.Proxy
{
    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class HostProxy : ISubject
    {
        ISubject _host;


        public void Function()
        {
            System.Diagnostics.Debug.WriteLine("Controlling access to Host...");
            if (_host == null)
            {
                System.Diagnostics.Debug.WriteLine("Host not ready yet, please try again later...");
                _host = new Host();
            }
            else
            {
                _host.Function();
            }
        }
    }
}
