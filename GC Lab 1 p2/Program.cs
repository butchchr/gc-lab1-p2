using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Lab_1_p2
{
    class Program
        //The instructions did not specify what date should be subtracted from the other 
        //so I decided that date 2 would be subtracted from date 1. Also it didn't specify what format
        //the date should be so I chose yyyy-mm-dd.
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! I am a duration calculator, please enter a date in the format: yyyy-mm-dd: ");
            string x = Console.ReadLine();

            Console.WriteLine("Please enter a second date in the format: yyyy-mm-dd: ");
            string y = Console.ReadLine();

            DateTime d1;
            DateTime d2;
            bool num1 = DateTime.TryParse(x, out d1);
            bool num2 = DateTime.TryParse(y, out d2);

            if (num1 && num2)
            {
                TimeSpan duration = d1 - d2;
                string time = string.Format("There are {0} days or {1} hours or {2} minutes beween the dates you entered", duration.TotalDays, duration.TotalHours, duration.TotalMinutes);
                
                Console.WriteLine(time);
            }
            else
            {
                Console.WriteLine("You did not enter properly formatted dates!");
            }
            Console.ReadKey();

        }
    }
}