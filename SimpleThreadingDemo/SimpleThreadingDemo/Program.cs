using System;
using System.Threading;

namespace SimpleThreadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ThreadStart threadStart = new ThreadStart(Counting);
            Thread thread = new Thread(threadStart);
            Thread thread2 = new Thread(threadStart);
            thread.Start();
            thread2.Start();
            thread.Join();
            thread2.Join();
        }

        static void Counting()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i} {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(10);
            }
        }
    }
}
