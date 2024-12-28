using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Program demonstrates  Static variable, Static Method,
 * Static Constructor and Default Constructor
 */
namespace OOP03
{
    public class FooStatic
    {
        private string firstVariable;

        public string FirstVariable
        {
            get { return firstVariable; }
            set { firstVariable = value; }
        }
        private string secondVariable;

        public string SecondVariable
        {
            get { return secondVariable; }
            set { secondVariable = value; }
        }

        private static string staticVariable;

        public static string StaticVariable
        {
            get { return FooStatic.staticVariable; }
            set { FooStatic.staticVariable = value; }
        }
        public FooStatic()
        {
            FirstVariable = string.Empty;
            SecondVariable = string.Empty;
        }

        //Static Constructor
        static FooStatic()
        {
            StaticVariable = "Initial Static Data";
        }

        public static string StaticMethod()
        {
            return string.Format("I am a Static Method i need to be called using My Class Name");
        }


    }
    class StudentTest
    {
        static void Main(string[] args)
        {
            FooStatic firstObj = new FooStatic();
            firstObj.FirstVariable = "Foo01";
            firstObj.SecondVariable = "Foo02";
            Console.WriteLine("FirstVariable = {0},SecondVariable = {1}, StaticVariable = {2}", firstObj.FirstVariable, firstObj.SecondVariable, FooStatic.StaticVariable);

            FooStatic.StaticVariable = "Static Data Changed";
            FooStatic secondObj = new FooStatic();
            secondObj.FirstVariable = "Foo03";
            secondObj.SecondVariable = "Foo04";

            Console.WriteLine("FirstVariable = {0},SecondVariable = {1}, StaticVariable = {2}", secondObj.FirstVariable, secondObj.SecondVariable, FooStatic.StaticVariable);

            FooStatic.StaticMethod();

            //Default Constructor will gets invoke if Constructor is not Specified in the class and assign the calss varaibles with thier default Values
            FooStatic thirdObj = new FooStatic();
            Console.WriteLine("FirstVariable = {0},SecondVariable = {1}, Institute = {2}", thirdObj.FirstVariable, thirdObj.SecondVariable, FooStatic.StaticVariable);

            Console.ReadKey();
        }

    }
}
