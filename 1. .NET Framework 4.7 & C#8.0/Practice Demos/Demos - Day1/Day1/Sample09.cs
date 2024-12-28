using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Program to demonstrate enumeration 
 */ 

namespace Day1
{
    public enum Salutation
    {
        Mr = 0,
        Ms = 1,
        Mrs = 2,
        Dr = 3
    }

    //Consuming Enumeration
    class Sample09
    {
        static void Main(string[] args)
        {
            Salutation title;
            string name;
            Console.WriteLine("Enter the Salutation:");
            title = (Salutation)Enum.Parse(typeof(Salutation), Console.ReadLine());
            Console.WriteLine("Enter your Name:");
            name = Console.ReadLine();
            Console.WriteLine("Your name is :{0}", title.ToString() + "." + name);

            Console.ReadKey();
        }
    }
}
