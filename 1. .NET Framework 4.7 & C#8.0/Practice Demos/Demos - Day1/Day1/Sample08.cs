using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    public struct Employee
    {
        public int EmployeeID;
        public string EmployeeName;
    }
    
    class Sample08
    {
        static void Main(string[] args)
        {
            Employee employee;
            employee.EmployeeID = 101;
            employee.EmployeeName = "Ganesh";
            PrintEmployeeDetails(employee);

            Console.ReadKey();
        }

        private static void PrintEmployeeDetails(Employee employee)
        {
            Console.WriteLine("Employee ID = {0}, Name = {1}", employee.EmployeeID, employee.EmployeeName);
        }
    }
}
