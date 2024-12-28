using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

/*
 * Program Demonstrates working with Hashtable
 */ 

namespace Collections03
{
    public class Sample
    {
        static void Main(string[] args)
        {

            Hashtable departmentList = new Hashtable();
            departmentList.Add(101, "HR");
            departmentList.Add(102, "Finance");
            departmentList.Add(103, "Admin");

            //To Print all the Keys(Department ID)
            ICollection keys = departmentList.Keys;

            Console.WriteLine("Department ID's");
            foreach (object obj in keys)
            {
                int departmentID = (int)obj;
                Console.WriteLine(departmentID);
            }

            if (departmentList.ContainsKey(103))
            {
                departmentList[103] = "Training";
            }

            //To Print all the DepartmentID and Names
            Console.WriteLine("Printing Department ID and Name");
            foreach (object obj in keys)
            {
                int departmentID = (int)obj;
                string departmentName = (string)departmentList[departmentID];
                Console.WriteLine("DepartmentID = {0} Name = {1}", departmentID, departmentName);
            }

            Console.ReadKey();
        }
    }
}
