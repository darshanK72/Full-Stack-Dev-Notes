using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Program to demonstrates try .. catch ... finally
 */ 

namespace OOP15
{
    class Program
    {
        static void Main(string[] args)
        {
            int dividend, divisor, result;
        err:
            try
            {
                Console.WriteLine("Enter the Dividend:");
                dividend = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Divisor:");
                divisor = Convert.ToInt32(Console.ReadLine());
                result = dividend / divisor;
                Console.WriteLine("Result = {0}", result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                goto err;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                goto err;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto err;
            }
            finally
            {
                Console.WriteLine("Finally Block Surely Executed");
            }
            Console.WriteLine("End of the program");
            Console.ReadKey();

        }
    }
}
