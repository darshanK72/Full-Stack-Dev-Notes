using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Program demonstrates Anonymous Method and Lambda Expression
 */ 

namespace DelegateEvents03
{
    public delegate void ArithmeticHandler(int firstNumber, int secondNumber);

    public class Program
    {
        static void Main(string[] args)
        {
            //Using Anonymous Method
            ArithmeticHandler arithObj01 = delegate(int firstNumber, int secondNumber)
            {
                Console.WriteLine("Addition of {0} and {1} is {2}", firstNumber, secondNumber, firstNumber + secondNumber);
            };
            arithObj01(3, 4);

            //Using Lambda Expression
            ArithmeticHandler arithObj02 = (firstNumber, secondNumber) => { Console.WriteLine("Addition of {0} and {1} is {2}", firstNumber, secondNumber, firstNumber + secondNumber); };
            arithObj02(3, 4);

            Console.ReadKey();
        }
    }
}
