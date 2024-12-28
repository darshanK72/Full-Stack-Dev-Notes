/*
 * Sample.cs
 * This program is used to print Hello World in Console Window
 */

namespace Day1
{
    /// <summary>
    /// Sample class prints Hello World when it gets executes
    /// </summary>
    class Sample01
    {
        /// <summary>
        /// The entry point for the application.
        /// </summary>
        /// <param name="args"> A list of command line arguments</param>
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World");
            System.Console.ReadKey();
        }
    }
}

/* 
To Compile the program using Visual Studio Command Prompt
> CSC <FileName>.cs

To execute the program
> <FileName>

*/