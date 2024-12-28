using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * The program demonstrates the use of method overloading.
 */

namespace OOP04
{
    /// <summary>
    /// Class Supplier accepts and displays the details of the supplier. 
    /// </summary>
    public class Supplier
    {
        /// <summary>
        /// Integer field to store the ID of the supplier.
        /// </summary>
        private int supplierID;

        /// <summary>
        /// Property to retrieve supplierID.
        /// </summary>
        public int SupplierID
        {
            get { return supplierID; }
        }

        /// <summary>
        /// String field to store the name of the supplier.
        /// </summary>
        private string supplierName;


        /// <summary>
        /// Property to retrieve supplierName.
        /// </summary>
        public string SupplierName
        {
            get { return supplierName; }
        }

        /// <summary>
        /// String field to store the city of the supplier.
        /// </summary>
        private string city;

        /// <summary>
        /// Property to retrieve city.
        /// </summary>
        public string City
        {
            get { return city; }
        }

        /// <summary>
        /// String field to store the phone number of the supplier.
        /// </summary>
        private string phoneNo;

        /// <summary>
        /// Property to retrieve phoneNo.
        /// </summary>
        public string PhoneNo
        {
            get { return phoneNo; }
        }

        /// <summary>
        /// String field to store the email address of the supplier.
        /// </summary>
        private string email;

        /// <summary>
        /// Property to retrieve email.
        /// </summary>
        public string Email
        {
            get { return email; }
        }

        /// <summary>
        /// Method to accept the details of the supplier.
        /// </summary>
        public void AcceptDetails(int supplierID, string supplierName, string city, string phoneNo, string email)
        {
            this.supplierID = supplierID;
            this.supplierName = supplierName;
            this.city = city;
            this.phoneNo = phoneNo;
            this.email = email;
        }


        /// <summary>
        /// Method to return the ID of the supplier.
        /// </summary>
        /// <param name="supplierID">Accepts id of the supplier</param>
        public int DisplayDetails(int supplierID)
        {
            return supplierID;
        }

        /// <summary>
        /// Method to return the name of the supplier.
        /// </summary>
        /// <param name="supplierName">Accepts name of the supplier</param> 
        public string DisplayDetails(string supplierName)
        {
            return supplierName;
        }


        /// <summary>
        /// Method to return the city of the supplier.
        /// </summary>
        /// <param name="supplierID">Accepts id of the supplier</param> 
        /// <param name="supplierName">Accepts name of the supplier</param>
        public string DisplayDetails(int supplierID, string supplierName)
        {
            return String.Format("Supplier {0} with ID {1} lives in city {2}", supplierName, supplierID, city);
        }
    }

    /// <summary>
    /// Class SupplierTest is used to instantiate the Supplier class.
    /// </summary>
    class SupplierTest
    {
        /// <summary>
        /// The entry point for the application.
        /// </summary>
        /// <param name="args"> A list of command line arguments</param>
        static void Main(string[] args)
        {
            // Creating an object of the Supplier class
            Supplier objSupplier = new Supplier();


            Console.Write("Enter the ID of supplier : ");
            int supplierID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the name of supplier : ");
            string supplierName = Console.ReadLine();
            Console.Write("Enter the name of city : ");
            string city = Console.ReadLine();
            Console.Write("Enter phone No. : ");
            string phoneNo = Console.ReadLine();
            Console.Write("Enter email address : ");
            string email = Console.ReadLine();

            // Invoking the AcceptDetails method of the Supplier class 
            // to accept the details of the supplier           
            objSupplier.AcceptDetails(supplierID, supplierName, city, phoneNo, email);


            // Integer variable to accept the id of the supplier
            int id = 0;

            // String variable to accept the name of the supplier
            string name = "";

            // Accepting the id of the supplier
            Console.Write("\nEnter the id of the supplier : ");
            id = Convert.ToInt32(Console.ReadLine());

            // Invoking the DisplayDetails method of the Supplier class 
            // to display the details of the supplier by passing id as a parameter
            objSupplier.DisplayDetails(id);

            // Accepting the name of the supplier
            Console.Write("\nEnter the name of the supplier : ");
            name = Console.ReadLine();

            // Invoking the DisplayDetails method of the Supplier class 
            // to display the details of the supplier by passing name as a parameter
            Console.WriteLine("\n" + objSupplier.DisplayDetails(name));

            // Invoking the DisplayDetails method of the Supplier class 
            // to display the city of the supplier by passing id and name as parameters           
            Console.WriteLine("\n" + objSupplier.DisplayDetails(id, name));

            Console.ReadKey();
        }
    }
}
