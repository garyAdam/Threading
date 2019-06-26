using System;
using System.Threading;

namespace ThreadPoolDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            WaitCallback waitCallback = new WaitCallback(ShowMyText);
            ThreadPool.QueueUserWorkItem(waitCallback,"lol ");
            ThreadPool.QueueUserWorkItem(waitCallback,"lol2 ");
            ThreadPool.QueueUserWorkItem(waitCallback,"lol3 ");
            ThreadPool.QueueUserWorkItem(waitCallback,"lol4 ");
            Thread.Sleep(1000);
        }


        static void ShowMyText(Object state)
        {
            string str = state as string;
            str += Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine(str);
        }
    }
}
