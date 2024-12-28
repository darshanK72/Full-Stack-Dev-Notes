using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Program to demonstrates Operator Overloading
 */

namespace OOP05
{
    public class Operation
    {
        private int number;

        public Operation(int number)
        {
            this.number = number;
        }

        public static bool operator >(Operation firstNumber, Operation secondNumber)
        {
            return firstNumber.number > secondNumber.number;
        }


        public static bool operator <(Operation firstNumber, Operation secondNumber)
        {
            //  return firstNumber.number > secondNumber.number;
            return true;
        }

    }


    class OperationTest
    {
        static void Main(string[] args)
        {
            Operation obj1 = new Operation(21);
            Operation obj2 = new Operation(3);

            bool res = obj1 > obj2;
            if (res)
            {
                Console.WriteLine("Object obj1 is Greatest");
            }
            else
            {
                Console.WriteLine("Object obj2 is Greatest");
            }

            Console.ReadKey();
        }
    }


    /*
     * Operators cannot be overloded: =, ., ?:, ->, new, is, sizeof, typeof
     * When relational operator is overloaded is pair operator must be compulsorily overloaded.
     */
}
