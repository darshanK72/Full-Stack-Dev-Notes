using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * The program demonstrates the use of abstract classes.
 */

namespace OOP11
{
    /// <summary>
    /// Class Account is an abstract class that stores the common properties of a bank account.
    /// </summary>
    public abstract class Account
    {
        /// <summary>
        /// Long field to store the account number.
        /// </summary>
        private long accountNumber;

        /// <summary>
        /// String field to store the customer name.
        /// </summary>
        private string customerName;

        /// <summary>
        /// Double field to store the balance.
        /// </summary>
        protected double balance = 500;

        public double Balance
        {
            get { return balance; }
        }

        /// <summary>
        /// Method to set the details of the customer.
        /// </summary>
        /// <param name="name">Accepts the customer name</param>
        /// <param name="number">Accepts the account number</param>
        public virtual void SetDetails(string name, long number)
        {
            this.customerName = name;
            this.accountNumber = number;
        }

        /// <summary>
        /// Method to withdraw money from the account.
        /// </summary>
        /// <param name="amount">Accepts the amount to be withdrawn</param>
        public virtual string Withdraw(double amount)
        {
            balance -= amount;
            return string.Empty;
        }

        /// <summary>
        /// Method to deposit the amount into the account.
        /// </summary>
        /// <param name="amount">Accepts the amount to be deposited</param>
        public virtual void Deposit(double amount)
        {
            balance += amount;
        }

        /// <summary>
        /// Method to display the account details.
        /// </summary>
        public virtual string Display()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n\nA/C No. \tCustomer Name \t Balance\n");
            sb.Append(accountNumber + " \t\t " + customerName + " \t " + balance);
            return sb.ToString();
        }

        /// <summary>
        /// Abstract method to calculate the bank charges.
        /// </summary>
        /// <returns>Returns the bank charges applicable</returns>
        protected abstract double BankCharges();
    }

    /// <summary>
    /// Class SavingsAccount inherits the abstract base class Account.
    /// The class accepts the details of the customer
    /// and also performs withdrawal and deposit traansactions and displays 
    /// the balance in the account.
    /// </summary>
    public class SavingsAccount : Account
    {
        /// <summary>
        /// Float field to store the minimum balance required in the account.
        /// </summary>
        private float minBalance;

        public float MinBalance
        {
            get { return minBalance; }
        }

        /// <summary>
        /// Float field to store the bank charges.
        /// </summary>
        private float bankCharge;

        /// <summary>
        /// Method to set the details of the customer.
        /// </summary>
        /// <param name="name">Accepts the name of the customer</param>
        /// <param name="number">Accepts the account number of the customer</param>
        public override void SetDetails(string name, long number)
        {
            base.SetDetails(name, number);
            minBalance = 500;
        }

        /// <summary>
        /// Method to calculate the bank charges.
        /// </summary>
        /// <returns>Returns the bank charge</returns>
        protected override double BankCharges()
        {
            if (Balance < minBalance)
            {
                bankCharge = 200;
            }
            return bankCharge;
        }

        /// <summary>
        /// Method to deposit the money in the account.
        /// </summary>
        /// <param name="amount">Accepts the amount to be deposited</param>
        public override void Deposit(double amount)
        {
            base.Deposit(amount);
        }

        /// <summary>
        /// Method to withdraw money from the account.
        /// </summary>
        /// <param name="amount">Accepts the amount to be withdrawn</param>
        public override string Withdraw(double amount)
        {
            // Checking whether the amount to be withdrawn is less than the balance available.
            if (amount <= Balance)
            {
                base.Withdraw(amount);
                return string.Empty;
            }
            else
            {
                return "You do not have sufficient balance in your account";
            }
        }

        /// <summary>
        /// Method to display the account details.
        /// </summary>
        public override string Display()
        {


            if (Balance <= 500)
            {
                return "\nBank Charges for less than minimum balance: " + BankCharges();
            }
            else
            {
                return base.Display();
            }
        }
    }


    /// <summary>
    /// Class SavingsTest is used to test the SavingsAccount class.
    /// </summary>
    class SavingsTest
    {
        /// <summary>
        /// The entry point for the application.
        /// </summary>
        /// <param name="args">A list of command line arguments</param>
        static void Main(string[] args)
        {
            // Creating an object of the SavingsAccount class.
            SavingsAccount objSavings = new SavingsAccount();

            // String variable to store the customer name.
            string name;

            // Long variable to store the account number.
            long number;

            // Double variable to store the amount to be deposited or withdrawn.
            double amount;

            Console.Write("Enter the customer name: ");
            name = Console.ReadLine();

            Console.Write("Enter the account number: ");
            number = Convert.ToInt64(Console.ReadLine());

            // Invoking the overriden SetDetails method.
            objSavings.SetDetails(name, number);

            Console.WriteLine("\nInitial balance available: " + objSavings.Balance + "\n\n");

            Console.WriteLine("Select the type of transaction: ");
            Console.WriteLine(" 1. Withdraw \n 2. Deposit");
            Console.Write("Select your choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Minimum balance to be maintained: Rs." + objSavings.MinBalance);
                    Console.Write("Enter the amount to be withdrawn: ");
                    amount = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(objSavings.Withdraw(amount));
                    break;
                case 2:
                    Console.Write("Enter the amount to be deposited: ");
                    amount = Convert.ToDouble(Console.ReadLine());
                    objSavings.Deposit(amount);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

            Console.WriteLine(objSavings.Display());

            Console.ReadKey();
        }
    }
}
