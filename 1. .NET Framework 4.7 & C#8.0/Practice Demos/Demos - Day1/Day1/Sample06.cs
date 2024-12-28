using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    /// <summary>
    /// Program Demonstrates Single Dimensional Array
    /// </summary>
    class Sample06
    {
        public static void Main()
        {
            int[] arr = new int[5];
            int sum = 0;
            Console.WriteLine("Enter the Elements 1 by 1\n");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Elements in the Array are");
            foreach (int j in arr)
            {
                Console.WriteLine(j);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine("Result = {0}", sum);

            Console.ReadKey();
        }
    }
}
