using System.Threading;

namespace Patterns.Singleton
{
    public sealed class MySingleClass
    {

        private static volatile MySingleClass _instance;
        private static readonly object InstLock = new object();


        private MySingleClass()
        {   
        }


        public static MySingleClass Instance
        {
            get
            {
                if (_instance == null)
                {
                    var block = false;

                    try
                    {
                        Monitor.TryEnter(InstLock, 2000, ref block);
                        if (block)
                        {
                            if (_instance == null) _instance = new MySingleClass();
                        }
                    }
                    finally
                    {
                        if (block)
                        {
                            Monitor.Exit(InstLock);
                        }
                    }
                }


                return _instance;
            }
        }


        internal void SomeFunc()
        {
            System.Diagnostics.Debug.WriteLine("This is a function in a singleton class...");
        }
    }
}
