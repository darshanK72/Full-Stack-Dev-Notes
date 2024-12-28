using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Program demonstrates usage of this keyword
 */ 

namespace OOP06
{
    public class Sample
    {
        private int i;
        public Sample()
        {
            i = 7;
        }
        public void ShowIValue(int i)
        {
            //Class instance Variable i not Accessed Here, because a local variable is declared

            Console.WriteLine("Method i  Value is {0}", i);
            //this keyword  used to access Current class instance 
            Console.WriteLine("Class i  Value is {0}", this.i);
            i = this.i + i;
            Console.WriteLine("Result i  Value is {0}", i);

        }
    }
    class SampleTest
    {
        static void Main(string[] args)
        {
            Sample s = new Sample();
            s.ShowIValue(3);

            Console.ReadKey();
        }
    }
}
