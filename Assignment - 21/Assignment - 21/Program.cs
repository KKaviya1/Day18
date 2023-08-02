using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Assignment21
{
    internal class Program
    {
        static List<string> fruits = new List<string>
        {
          "Pineapple", "custardApple", "Banana", "Fig", "Grapes", "Watermelon", "Strawberry", "Mango", "Jackfruit", "Raspberries"
        };

        static List<string> days = new List<string>
        {
            "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"
        };

        static List<string> months = new List<string>
        {
            "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"
        };

        static Dictionary<string, string> wordsAndMeanings = new Dictionary<string, string>
        {
            { "Snow", "Frozen precipitation in the form of white or translucent hexagonal ice crystals that fall in soft, white flakes." },
            { "Chill", "A calm and relaxed state of mind or atmosphere." },
            { "Travel", "The action of traveling or the journey itself." },
            { "Food", "Any nourishing substance that is eaten, drunk, or otherwise taken into the body to sustain life, provide energy, and promote growth." },
            { "Kindness", " The quality of being friendly, generous, and considerate towards others; showing goodwill and compassion." }
        };
         static void DisplayDays()
        {
            Console.WriteLine("I. Displaying Name of Days:");
            foreach (var day in days)
            {
                Console.WriteLine(day);
                Thread.Sleep(2000); 
            }
            Console.WriteLine();
        }

        static void DisplayMonths()
        {
            Console.WriteLine("II. Displaying All Months of Year:");
            foreach (var month in months)
            {
                Console.WriteLine(month);
                Thread.Sleep(2000); 
            }
            Console.WriteLine();
        }

        static void DisplayFruitsAndWords()
        {
            Console.WriteLine("III. Displaying Fruits and Words with Meanings Simultaneously:");
            Thread fruitThread = new Thread(() =>
            {
                foreach (var fruit in fruits)
                {
                    Console.WriteLine("Fruit: " + fruit);
                    Thread.Sleep(1000); 
                }
            });

            Thread wordsThread = new Thread(() =>
            {
                foreach (var word in wordsAndMeanings)
                {
                    Console.WriteLine("Word: " + word.Key + " - Meaning: " + word.Value);
                    Thread.Sleep(1000); 
                }
            });

            fruitThread.Start();
            wordsThread.Start();

            fruitThread.Join();
            wordsThread.Join(); 
        }

        static void Main(string[] args)
        {
            Console.WriteLine("--------Welcome to Learning---------\n");

            Thread dayThread = new Thread(DisplayDays);
            Thread monthThread = new Thread(DisplayMonths);

            dayThread.Start();
            dayThread.Join(); 

            Thread.Sleep(5000); 

            monthThread.Start();
            monthThread.Join(); 

            DisplayFruitsAndWords();

            Console.ReadLine();
        }
    }
}

