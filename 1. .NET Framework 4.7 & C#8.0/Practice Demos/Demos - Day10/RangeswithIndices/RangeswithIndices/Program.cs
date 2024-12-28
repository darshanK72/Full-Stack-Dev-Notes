using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace RangeswithIndices
{

       class WeeksPrg
            {

            static string[] weeks = new string[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
             "Sunday"
             };
        public static void OldRangeIndicesHandling()
        {
            Console.WriteLine($"Firth element of an array is: {weeks[3]}");
            Console.WriteLine($"Third last element of an array is: {weeks[weeks.Length - 3]}");
            var midWeeks = weeks.ToList().GetRange(2, 4);
            
            Console.WriteLine("Elements of midWeeks array are:"); 
            foreach (var week in midWeeks)
            {
                Console.WriteLine(week);
            }

            var endofWeeks = weeks.ToList().GetRange(5, 2);
            Console.WriteLine("Elements of endofWeeks array are:");
            foreach (var week in endofWeeks)
            {
                Console.WriteLine(week);
            }
        }
        

}
    class Program
    {
        static void Main(string[] args)
        {
            WeeksPrg.OldRangeIndicesHandling();
           
        }
    }
}
