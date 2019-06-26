using System;
using System.Threading;

namespace SingleInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Mutex mutex = null;
            const string name = "RUNMEONLYONCE";
            while (true)
            {
                try
                {
                    mutex = Mutex.OpenExisting(name);
                    mutex.Close();
                    System.Environment.Exit(0);
                }
                catch (WaitHandleCannotBeOpenedException)
                {
                    mutex = new Mutex(true, name);
                }
            }
        }
    }
}
