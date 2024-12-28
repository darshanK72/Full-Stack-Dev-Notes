using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Program to demonstrate the use of interface
 */ 

namespace OOP14
{
    public interface IObserver
    {
        void Update(int no);
    }

    public class SetNumber
    {
        IObserver observer;
        private int number;

        public SetNumber(Sample sample)
        {
            observer = sample;
        }

        public void SetNo(int number)
        {
            this.number = number;
            observer.Update(number);
        }

    }
    public class Sample : IObserver
    {

        private int number;
        public void Display()
        {
            Console.WriteLine("{0}", number);
        }
        public void Update(int number)
        {
            this.number = number;
            Display();
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Sample sampleObj = new Sample();
            SetNumber setNumber = new SetNumber(sampleObj);
            setNumber.SetNo(4);

            Console.ReadKey();
        }
    }
}
