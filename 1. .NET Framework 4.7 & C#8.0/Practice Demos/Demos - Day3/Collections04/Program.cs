using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

/*
 * Program to demonstrate the usage of Hastable
 */ 

namespace Collections04
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public int EmployeeSalary { get; set; }
    }


    class Sample
    {
        static void Main(string[] args)
        {
            //Storing Computer Department Employees in Arraylist
            ArrayList csEmpList = new ArrayList();
            csEmpList.Add(new Employee { EmployeeID = 101, EmployeeName = "Karthik", EmployeeSalary = 3900 });
            csEmpList.Add(new Employee { EmployeeID = 102, EmployeeName = "Ganesh", EmployeeSalary = 2900 });
            csEmpList.Add(new Employee { EmployeeID = 103, EmployeeName = "Ajit", EmployeeSalary = 4900 });

            //Storing Account Department Employees in Arraylist
            ArrayList acEmpList = new ArrayList();
            acEmpList.Add(new Employee { EmployeeID = 104, EmployeeName = "Shilpa", EmployeeSalary = 2500 });
            acEmpList.Add(new Employee { EmployeeID = 105, EmployeeName = "Anu", EmployeeSalary = 5800 });
            acEmpList.Add(new Employee { EmployeeID = 106, EmployeeName = "Uma", EmployeeSalary = 2900 });

            //Storing Account Department and Computer department Employees in hashtable
            Hashtable employeeList = new Hashtable();
            employeeList.Add("Computer", csEmpList);
            employeeList.Add("Accounts", acEmpList);

            //Retriving employees from each department
            foreach (string department in employeeList.Keys)
            {
                ArrayList employees = (ArrayList)employeeList[department];

                Console.WriteLine("Employees in {0} department", department);
                for (int counter = 0; counter < employees.Count; counter++)
                {
                    Employee emp = (Employee)employees[counter];
                    Console.WriteLine("{0} {1} {2}", emp.EmployeeID, emp.EmployeeName, emp.EmployeeSalary);
                }
                Console.Write(Environment.NewLine);
            }

            Console.ReadKey();
        }
    }
}
