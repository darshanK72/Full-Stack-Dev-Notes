using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Program to demonstrates Mutlilevel inheritance
 */


namespace OOP07
{
    public class First
    {
        protected int firstNumber;
        public void ShowFirstNumber()
        {
            firstNumber = 5;
            Console.WriteLine("FirstNumber = {0}", firstNumber);
        }
    }

    public class Second : First
    {
        protected int secondNumber;
        public void ShowSecondNumber()
        {
            secondNumber = 6;
            Console.WriteLine("SecondNumber = {0}", secondNumber);
        }

    }

    public class Third : Second
    {
        int result;
        public void ShowResult()
        {
            result = firstNumber + secondNumber;
            Console.WriteLine("Result = {0}", result);
        }

    }

    class MultiLevelInheritanceTest
    {
        static void Main(string[] args)
        {
            Third thirdObject = new Third();
            thirdObject.ShowFirstNumber();
            thirdObject.ShowSecondNumber();
            thirdObject.ShowResult();
            
            Console.ReadKey();
        }
    }
}
