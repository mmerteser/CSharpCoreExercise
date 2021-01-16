using System;
using System.Threading.Tasks;

namespace AsyncDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Thread no: {System.Threading.Thread.CurrentThread.ManagedThreadId}");
            
            //Task taskOne = new Task(ProcessOne);
            //taskOne.Start();

            //Task taskOne = Task.Factory.StartNew(ProcessOne);

            //Task taskOne = Task.Run(ProcessOne);

            Task taskOne = Task.Run(() =>
            {
                ProcessOne();
                ProcessTwo();
            });
            
            //ProcessTwo();
            Console.ReadKey();
        }

        static void ProcessOne()
        {
            Console.WriteLine("1. işleme başladım");
            Console.WriteLine($"Thread no: {System.Threading.Thread.CurrentThread.ManagedThreadId}");
        }

        static void ProcessTwo()
        {
            Console.WriteLine("2. işleme başladım");
            Console.WriteLine($"Thread no: {System.Threading.Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
