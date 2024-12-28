using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
namespace NewRangeswithIndices
{
    class WeekPrg
    {
        static string[] weeks = new string[] 
        {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            
        };

        public static void ExecuteOldRangeIndicesHandling()
        {
            Console.WriteLine($"Third element of an array is: {weeks[2]}");
            Console.WriteLine($"Second last element of an array is:{weeks[weeks.Length - 2]}");  
            var midWeeks = weeks.ToList().GetRange(2, 3); 
            Console.WriteLine("Elements of midWeeks array are:"); foreach(var week in midWeeks) {  
                Console.WriteLine(week);  
            }
    var endofWeeks = weeks.ToList().GetRange(5, 2); 
            Console.WriteLine("Elements of endofWeeks array are:"); foreach(var week in endofWeeks) {  
                Console.WriteLine(week);  
            }  
        }  
    }

    class Program
    {
        static void Main(string[] args)
        {

            WeekPrg.ExecuteOldRangeIndicesHandling();
        }
    }
}
