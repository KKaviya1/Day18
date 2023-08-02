using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Task_Parallel_Library_TPL
{
    internal class Program
    {
        public static async Task<string> DownloadPage(string url)
        {
            using (var httpClient = new HttpClient())
            {
                return await httpClient.GetStringAsync(url);
            };
        }
        public static void ProcessPages(List<string> urls)
        {
            Parallel.ForEach(urls, url =>
            {
                string page = DownloadPage(url).Result;
                Console.WriteLine($"Downloaded {url}.web page length is {page.Length} chars");

            });
           
        }

        static void Main(string[] args)
        {
            List<string> urls = new List<string>()
            {
                "https://wallpapersafari.com/cute-baby-photos-wallpapers/",
                "https://www.eatthis.com/most-sodium-restaurant-foods/",
                "https://traveltriangle.com/blog/waterfalls-in-thailand/",

            };
            Console.WriteLine("download urls are processing");
            var startTime = DateTime.Now;
            ProcessPages(urls);
            var endTime = DateTime.Now;
            Console.WriteLine($"Time taken : start time was {startTime} and end time was {endTime}");

            Console.ReadKey();  
        }
    }
}
