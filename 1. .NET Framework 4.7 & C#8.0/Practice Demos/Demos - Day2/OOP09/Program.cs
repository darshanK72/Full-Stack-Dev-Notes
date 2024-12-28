using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * program demonstrates base,new and method Overriding
 */

namespace OOP09
{
    public class Foo
    {
        private int employeeID;
        private string employeeName;
        public Foo()
        {
            employeeID = 0;
            employeeName = string.Empty;
        }
        public void ProvideEmployeeInfo()
        {
            Console.WriteLine("Enter ID :");
            employeeID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name :");
            employeeName = Console.ReadLine();
        }

        public void ShowEmployeeInfo()
        {
            Console.WriteLine("ID = {0}", employeeID);
            Console.WriteLine("Name = {0}", employeeName);
        }
    }

    public class Bar : Foo
    {
        private string region;
        public new void ProvideEmployeeInfo()
        {
            base.ProvideEmployeeInfo();
            Console.WriteLine("Enter Region :");
            region = Console.ReadLine();
        }

        public new void ShowEmployeeInfo()
        {
            base.ShowEmployeeInfo();
            Console.WriteLine("Region = {0}", region);
        }

    }
    class Test
    {
        static void Main(string[] args)
        {
            Bar employee = new Bar();
            employee.ProvideEmployeeInfo();
            employee.ShowEmployeeInfo();

            Console.ReadKey();
        }
    }
}
