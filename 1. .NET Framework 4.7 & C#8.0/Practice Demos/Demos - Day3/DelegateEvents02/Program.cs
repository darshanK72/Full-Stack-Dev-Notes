using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Program demonstrates working with Event
 */

namespace DelegateEvents02
{
    public delegate void ArithmeticHandler(int firstNumber, int secondNumber);

    public class Sample
    {
        public static event ArithmeticHandler Operation = null;

        public void Addition(int firstNumber, int secondNumber)
        {
            Console.WriteLine("Addition of {0} and {1} is  {2}", firstNumber, secondNumber, firstNumber + secondNumber);
        }

        public static void OnOperation(int firstNumber, int secondNumber)
        {
            if (Operation != null)
                Operation(firstNumber, secondNumber);
        }
    }

    class SampleTest
    {
        static void Main(string[] args)
        {
            Sample sampleObj = new Sample();
            Sample.Operation += new ArithmeticHandler(sampleObj.Addition);
            Sample.OnOperation(4, 5);

            Console.ReadKey();
        }
    }
}
