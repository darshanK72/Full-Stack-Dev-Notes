using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * The program demonstrates the creation and use of sealed class.
 */

namespace OOP08
{
    /// <summary>
    /// Class Appraisal calculates the bonus of the employee
    /// depending on the designation, tenure, and salary.
    /// </summary>
    public sealed class Appraisal
    {
        /// <summary>
        /// Double field to store the bonus.
        /// </summary>
        private double bonus;

        /// <summary>
        /// Property to store and retrieve the bonus.
        /// </summary>
        public double Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }

        /// <summary>
        /// Method to calculate the bonus.
        /// </summary>
        /// <param name="designation">Accepts the designation of the employee</param>
        /// <param name="tenure">Accepts the tenure of the employee</param>
        /// <param name="salary">Accepts the salary of the employee</param>
        /// <returns>Returns the bonus </returns>
        public double CalculateBonus(string designation, int tenure, double salary)
        {
            if (designation == "Manager")
            {
                if (tenure <= 5)
                {
                    bonus = salary * 1.5;
                }
                else
                {
                    bonus = salary * 2;
                }
            }
            if (designation == "Engineer")
            {
                if (tenure <= 5)
                {
                    bonus = salary;
                }
                else
                {
                    bonus = salary * 2;
                }
            }
            if (designation == "Technician")
            {
                if (tenure <= 3)
                {
                    bonus = salary * 0.25;
                }
                else if (tenure > 3 && tenure <= 5)
                {
                    bonus = salary * 0.5;
                }
                else
                {
                    bonus = salary * 2;
                }
            }
            return bonus;
        }
    }

    /// <summary>
    /// Class Worker accepts and displays the details of workers.
    /// </summary>
    public class Worker
    {
        /// <summary>
        /// Integer field to store the worker ID.
        /// </summary>
        private int workerID;

        /// <summary>
        /// Property to retrieve workerID.
        /// </summary>
        public int WorkerID
        {
            get { return workerID; }
        }

        /// <summary>
        /// String field to store the worker name.
        /// </summary>
        private string workerName;

        /// <summary>
        /// Property to retrieve workerName.
        /// </summary>
        public string WorkerName
        {
            get { return workerName; }
        }

        /// <summary>
        /// String field to store the designation.
        /// </summary>
        private string designation;

        /// <summary>
        /// Property to store designation.
        /// </summary>
        public string Designation
        {
            get { return designation; }
        }

        /// <summary>
        /// Double field to store the salary.
        /// </summary>
        private double salary;

        /// <summary>
        /// Property to retrieve salary.
        /// </summary>
        public double Salary
        {
            get { return salary; }
        }

        /// <summary>
        /// Double field to store the amount.
        /// </summary>
        private double amount;

        /// <summary>
        /// Property to retrieve amount.
        /// </summary>
        public double Amount
        {
            get { return amount; }
        }

        /// <summary>
        /// Integer field to store the number of years of service.
        /// </summary>
        private int yearsOfService;

        /// <summary>
        /// Property to retrieve yearsOfService.
        /// </summary>
        public int YearsOfService
        {
            get { return yearsOfService; }
        }

        /// <summary>
        /// Creating an object of the Appraisal class
        /// </summary>
        Appraisal objAppraisal = new Appraisal();

        /// <summary>
        /// Method to accept the details of worker.
        /// </summary>
        public void InputDetails(int workerID, string workerName, int designationValue, int yearsOfService)
        {
            this.workerID = workerID;
            this.workerName = workerName;

            switch (designationValue)
            {
                case 1:
                    this.designation = "Manager";
                    this.salary = 5000;
                    break;
                case 2:
                    this.designation = "Engineer";
                    this.salary = 4000;
                    break;
                case 3:
                    this.designation = "Technician";
                    this.salary = 3000;
                    break;
            }

            this.yearsOfService = yearsOfService;
        }

        /// <summary>
        /// Method to display the details of worker.
        /// <returns>Returns Worker</returns>
        /// </summary>
        public Worker DisplayDetails()
        {
            this.amount = objAppraisal.CalculateBonus(designation, yearsOfService, salary);
            Worker worker = new Worker();
            worker.workerName = this.workerName;
            worker.workerID = this.workerID;
            worker.designation = this.designation;
            worker.salary = this.salary;
            worker.amount = this.amount;
            return worker;
        }
    }

    /// <summary>
    /// Class WorkerTest is used to test the Worker class.
    /// </summary>
    class WorkerTest
    {
        /// <summary>
        /// The entry point for the application.
        /// </summary>
        /// <param name="args"> A list of command line arguments</param>
        static void Main(string[] args)
        {
            // Creating an object of the Worker class
            Worker objWorkers = new Worker();

            Console.Write("Enter the worker id : ");
            int workerID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the worker name : ");
            string workerName = Console.ReadLine();

            Console.WriteLine("\nSelect the designation (1-3) : ");
            Console.WriteLine("1 - Manager");
            Console.WriteLine("2 - Engineer");
            Console.WriteLine("3 - Technician");
            Console.Write("Enter the choice : ");
            int desigValue = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter the years of service : ");
            int yearsOfService = Convert.ToInt32(Console.ReadLine());

            // Invoking the InputDetails method of the Worker
            // class to provide the input
            objWorkers.InputDetails(workerID, workerName, desigValue, yearsOfService);

            // Invoking the DisplayDetails method of the Worker
            // class to display the details 
            Worker workerDetails = objWorkers.DisplayDetails();

            Console.WriteLine("\n\nEmployee Name :{0}", workerDetails.WorkerName);
            Console.WriteLine("Employee ID : {0}", workerDetails.WorkerID);
            Console.WriteLine("Designation :{0}", workerDetails.Designation);
            Console.WriteLine("Salary :{0}", workerDetails.Salary);
            Console.WriteLine("Bonus : {0}", workerDetails.Amount);
            Console.WriteLine("Total income earned : {0}", (workerDetails.Amount + workerDetails.Salary));

            Console.ReadKey();
        }
    }
}
