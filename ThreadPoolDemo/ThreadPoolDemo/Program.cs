using System;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPoolDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            WaitCallback waitCallback = ShowMyText;

            Task[] taskArray = new Task[10];
            for (int i = 0; i < taskArray.Length; i++)
            {
                taskArray[i] = Task.Factory.StartNew((Object state) => waitCallback(state), $"lol{i}: ");
            }
            Task.WaitAll(taskArray);

        }


        static void ShowMyText(Object state)
        {
            string str = state as string;
            str += Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine(str);
        }
    }
}
