//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace threading
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Welcome to threading in C#");
//            Console.ReadKey();
//        }
//    }
//}


//example - 02

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace threading
//{
//    internal class Program
//    {
//        public static void MethodOne()
//        {
//            for (int i = 0; i < 10; i++)
//            {
//                //Console.WriteLine("MethodOne: " + i);
//                //Console.WriteLine("\n");
//                Console.WriteLine("MethodOne" );
//                Console.Write(i + "\t");
//            }

//        }

//            public static void MethodTwo()
//            {
//                for (int i = 50; i < 65; i++)
//                {
//                //    Console.WriteLine("MethodTwo: " + i);
//                //    Console.WriteLine("\n");
//                Console.WriteLine("MethodTwo");
//                 Console.Write(i + "\t");

//                }

//            }
//            public static void MethodThree()
//            {
//                for (int i =11; i < 30; i++)
//                {
//                //Console.WriteLine("MethodThree: " + i);
//                //Console.WriteLine("\n");
//                Console.WriteLine("MethodThree");
//                Console.Write(i + "\t");
//                Thread.Sleep(500);
//            }

//            }
//            static void Main(string[] args)
//        {
//            Console.WriteLine("Welcome to threading in C#");
//            MethodOne();
//            MethodTwo();
//            MethodThree();
//            Console.ReadKey();
//        }
//    }
//}



//example - 03

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace threading
{
    internal class Program
    {
        public static void MethodOne()
        {
            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine("MethodOne: " + i);
                //Console.WriteLine("\n");
                Console.WriteLine("MethodOne");
                Console.Write(i + "\t");
                Thread.Sleep(500);
            }

        }

        public static void MethodTwo()
        {
            for (int i = 50; i < 65; i++)
            {
                //    Console.WriteLine("MethodTwo: " + i);
                //    Console.WriteLine("\n");
                Console.WriteLine("MethodTwo");
                Console.Write(i + "\t");
                Thread.Sleep(500);

            }

        }
        public static void MethodThree()
        {
            for (int i = 11; i < 30; i++)
            {
                //Console.WriteLine("MethodThree: " + i);
                //Console.WriteLine("\n");
                Console.WriteLine("MethodThree");
                Console.Write(i + "\t");
                Thread.Sleep(500);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to threading in C#");
            Thread thread1 = new Thread(MethodOne);
            Thread thread2 = new Thread(MethodTwo);
            Thread thread3 = new Thread(MethodThree);
            thread1.Start();
            thread2.Start();
            thread3.Start();
            MethodOne();
            MethodTwo();
            MethodThree();
            Console.ReadKey();
        }
    }
}