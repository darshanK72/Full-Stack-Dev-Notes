using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Program to demonstrate Generic Class
 */ 

namespace Collections05
{
    //Addition class can take any type
    public class Addition<T>
    {
        private T firstNumber;

        public T FirstNumber
        {
            get { return firstNumber; }
            set { firstNumber = value; }
        }
        private T secondNumber;

        public T SecondNumber
        {
            get { return secondNumber; }
            set { secondNumber = value; }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Addition<float> addition = new Addition<float>();
            addition.FirstNumber = 5.6f;
            addition.SecondNumber = 6.7f;

            float firstNO = addition.FirstNumber;
            float secondNO = addition.SecondNumber;
            float result = firstNO + secondNO;
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
