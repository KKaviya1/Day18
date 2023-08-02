//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace threadingEx
//{
//    internal class Program
//    {
//        private static object lockObject;
//        public static class Counter
//        {
//            public static int CounterValue { get; set; }
//        }
//        public static void IncrementCounter()
//        {
//            for(int i =0; i<10000; i++)
//            {
//                lock(lockObject)
//                {
//                    Counter.CounterValue++;
//                }
//            }
//        }
//        static void Main(string[] args)
//        {
//            lockObject = new object();
//            Thread Thread1 = new Thread(IncrementCounter);
//            Thread Thread2 = new Thread(IncrementCounter);

//            Thread1.Start();
//            Thread2.Start();
//            Thread1.Join();
//            Thread2.Join();
//            Console.WriteLine("Final counter value: " + Counter.CounterValue);
//            Console.ReadKey();
//        }
//    }
//}

//Without Sync


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace threadingEx
{
    internal class Program
    {
        public static void PrintNumbers(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} : {i}");
                Thread.Sleep(100);
            }
        }
        static void Main(string[] args) 
        {
            Thread thread1 = new Thread(() => PrintNumbers(10));
            Thread thread2 = new Thread(() => PrintNumbers(12));
            thread1.Start();
            thread2.Start();
            //thread1.Join();
            //thread2.Join();

            Console.ReadKey();
        }



    }

}