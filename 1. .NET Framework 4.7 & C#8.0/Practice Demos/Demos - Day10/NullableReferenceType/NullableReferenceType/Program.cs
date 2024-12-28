using System;

namespace NullableReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "kamal ";
            string? middleName = null;
            string lastName = " Prathap";
            PrintFullName(firstName, middleName, lastName);

        }
        static void PrintFullName(string first, string? middle, string last)
        {
            Console.WriteLine(middle?.Length);
            Console.WriteLine(first + middle + last);
        }


    }
}
