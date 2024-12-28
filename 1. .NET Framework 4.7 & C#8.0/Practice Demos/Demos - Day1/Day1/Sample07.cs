using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    /// <summary>
    /// Program demonstates multi-dimensional array
    /// </summary>
    class Sample07
    {
        public static void Main()
        {
            int[,] arr = new int[3, 3];
            Console.WriteLine("Enter the Array Elements 1 by 1\n");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Given Matrix");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.Write("\n");
            }
            Console.WriteLine("Transpose Matrix");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[j, i] + "\t");
                }
                Console.Write("\n");
            }

            Console.ReadKey();
        }
    }
}
