using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TPL.Ex
{
    public class Program
    {
        public static int Factorial(int num) 
        {
            int result = 1;
            for(int i=1; i<=num; i++)
            {
                result *= i;
                Thread.Sleep(50);
            }
            return result;
        }
        public static int SumFactCon(int[] nums)
        {
            List<Task<int>> tasks = new List<Task<int>>();      
            foreach(var num in nums)
            {
                tasks.Add(Task.Run(() => Factorial(num)));
            }
            Task.WhenAll(tasks).Wait();
            int totalSum = 0;
            foreach(var task in tasks)
            {
                totalSum += task.Result;
            }
            return totalSum;

        }
        static void Main(string[] args)
        //{
        //    int[] nums = { 3, 6, 9, 12, 15, };
        //    Console.WriteLine("Concurrent Ex:");
        //    var starttime = DateTime.Now;
        //    int cSum = SumFactCon(nums);
        //    var endTime = DateTime.Now;
        //    Console.WriteLine("Start time " + starttime + " end time " + endTime);
        //    Console.WriteLine("Result: " + cSum);

        //    Console.ReadKey();


        {             
            int[] numbers = { 5, 6, 7, 8, 9, 10, 23, 34, 45, };
            Console.WriteLine("Sequential Example");
            var starttime = DateTime.Now;
            int seqSum = 0;
            foreach(var number in numbers)
            {
                seqSum+=Factorial(number);
            }
            var endTime = DateTime.Now;
            Console.WriteLine("Start Time " + starttime.ToLongTimeString() + " End Time " + endTime.ToLongTimeString());
            Console.WriteLine("Result : " + seqSum);
            Console.WriteLine("\nConcurrent Example");
             starttime = DateTime.Now;
            int cSum = SumFactCon(numbers);
            endTime = DateTime.Now;
            Console.WriteLine("Start Time " + starttime + " End Time " + endTime);
            Console.WriteLine("Result : " + cSum);
            Console.ReadKey();


        }
    }
}


