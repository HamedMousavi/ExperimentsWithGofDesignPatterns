using System.Collections.Generic;


namespace Patterns.Command.Invokers
{

    public class SimpleInvoker : IInvoker
    {

        public ICommand Command { get; set; }
        private readonly List<ICommand> _transaction;


        public SimpleInvoker()
        {
            Command = new BaseCommand();
            _transaction = new List<ICommand>();
        }

        public void ExecuteCommands()
        {
            _transaction.Add(Command);
            Command.Execute();
        }

        public  void Undo()
        {
            var lastCmd = _transaction[_transaction.Count - 1];
            Undo(lastCmd);
        }

        private static void Undo(ICommand lastCmd)
        {
            System.Diagnostics.Debug.WriteLine("Invoker Undoying last execution...");
        }


        public  void Redo()
        {
            System.Diagnostics.Debug.WriteLine("Invoker Redoying last execution...");
            var lastCmd = _transaction[_transaction.Count - 1];
            lastCmd.Execute();
        }
    }
}