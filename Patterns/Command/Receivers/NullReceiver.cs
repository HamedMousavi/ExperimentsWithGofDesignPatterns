
namespace Patterns.Command.Receivers
{
    public class NullReceiver : IReceiver
    {
        public void Execute()
        {
            System.Diagnostics.Debug.WriteLine("No receiver to handle this command");
        }
    }
}
