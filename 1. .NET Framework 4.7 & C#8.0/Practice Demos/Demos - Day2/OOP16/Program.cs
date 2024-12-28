using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP16
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Enter your name:");
            name = Console.ReadLine();
            try
            {
                string result = ChangeNameInCapital(name);
                Console.WriteLine("Given Name in Capitals : {0} ", result);
            }
            catch (CustomException ex)
            {
                //Handling Custom Exception
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

        private static string ChangeNameInCapital(string name)
        {
            string res;
            try
            {
                if (name.Trim().Equals(string.Empty))

                    //Throwing Custom Exception
                    throw new CustomException("Name is Must");
                else
                    res = name.ToUpper();
            }
            catch (CustomException ex)
            {
                //Rethrowing it
                throw ex;
            }
            return res;
        }
    }
}
