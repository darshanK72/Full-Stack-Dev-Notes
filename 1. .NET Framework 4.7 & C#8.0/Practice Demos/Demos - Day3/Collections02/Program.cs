using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

/*
 * Program demonstraing storing Reference type in ArrayList
 */ 

namespace Collections02
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public int EmployeeSalary { get; set; }
    }

    class EmployeeTest
    {
        static void Main(string[] args)
        {
            int numberOfEmployees;

            ArrayList employeeList = new ArrayList();

            Console.WriteLine("How many Employees?:");
            numberOfEmployees = Convert.ToInt32(Console.ReadLine());

            for (int counter = 1; counter <= numberOfEmployees; counter++)
            {
                Employee employee = new Employee();
                Console.WriteLine("Enter ID:");
                employee.EmployeeID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name:");
                employee.EmployeeName = Console.ReadLine();
                Console.WriteLine("Enter Salary:");
                employee.EmployeeSalary = Convert.ToInt32(Console.ReadLine());
                employeeList.Add(employee);
            }

            //Printing the employees
            PrintEmployees(employeeList);

            Console.ReadKey();
        }

        //Printing Employees
        private static void PrintEmployees(ArrayList employeeList)
        {
            Console.WriteLine("No of employees - {0}", employeeList.Count);
            foreach (object obj in employeeList)
            {
                Employee employee = (Employee)obj;
                Console.WriteLine("{0} {1} {2}", employee.EmployeeID, employee.EmployeeName, employee.EmployeeSalary);
            }
        }
    }
}
