using System;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleThreadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Task task = new Task(() => Counting());
            Task task2 = new Task(() => Counting());

            task.Start();
            task2.Start();
            task.Wait();
            task2.Wait();


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
