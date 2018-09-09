
namespace Patterns.Command.Receivers
{
    public class SimpleReceiver : IReceiver
    {
        public void Execute()
        {
            System.Diagnostics.Debug.WriteLine("SimpleReceiver does the real job.");
        }
    }
}
