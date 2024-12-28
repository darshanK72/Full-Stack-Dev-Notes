using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvents01
{
    //Creating a Delegate
    public delegate void ArithmeticHandler(int firstNumber, int secondNumber);

    public class Operations
    {
        public void Addition(int firstNumber, int secondNumber)
        {
            Console.WriteLine("Addtion of {0} and {1} is {2}", firstNumber, secondNumber, firstNumber + secondNumber);

        }
        public void Subtraction(int firstNumber, int secondNumber)
        {
            Console.WriteLine("Subtraction of {0} and {1} is {2}", firstNumber, secondNumber, firstNumber - secondNumber);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Operations operationObj = new Operations();

            ArithmeticHandler arithObj1, arithObj2, arithObj3;
            arithObj1 = new ArithmeticHandler(operationObj.Addition);
            arithObj2 = new ArithmeticHandler(operationObj.Subtraction);

            //Multicasting a delegate
            arithObj3 = arithObj1 + arithObj2;

            arithObj1(2, 3);

            arithObj2(3, 2);

            arithObj3(6, 4);

            Console.ReadKey();
        }
    }
}
