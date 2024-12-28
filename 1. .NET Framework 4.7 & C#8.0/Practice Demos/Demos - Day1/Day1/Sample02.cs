/*
 * Sample.cs
 * This program creates a Sample class to declare, 
 * intialize and display the variables.
 */

using System;
using System.Text;

namespace Day1
{
    /// <summary>
    /// Sample class stores and displays the details 
    /// using different data types.
    /// </summary>
    class Sample02
    {
        /// <summary>
        /// The entry point for the application.
        /// </summary>
        /// <param name="args"> A list of command line arguments</param>
        static void Main(string[] args)
        {
            //Declaring and intialising variables to store details
            int id = 714709;
            string name = "Ganesh";
            byte age = 32;
            char gender = 'M';
            float percent = 75.50F;

            //Displaying the details
            Console.WriteLine("ID : {0}", id);
            Console.WriteLine("Name : {0}", name);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Gender : " + gender);
            Console.WriteLine("Percentage : {0:F2}", percent);
            Console.ReadKey();
        }
    }
}
