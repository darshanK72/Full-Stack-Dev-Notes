using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * The program demonstrates the use of Polymorphism.
 */

namespace OOP12
{
    /// <summary>
    /// Class Invoice accepts the customer name and displays the invoice details. 
    /// </summary>
    public class Invoice
    {
        /// <summary>
        /// Integer field to store invoice number.
        /// </summary>
        private int invoiceNumber;

        /// <summary>
        /// String field to store customer name.
        /// </summary>
        private string customerName;

        /// <summary>
        /// DateTime type field to store current date.
        /// </summary>
        private DateTime invoiceDate;

        /// <summary>
        /// Method to set the invoice date.
        /// </summary>
        public virtual void SetDetails()
        {
            invoiceDate = DateTime.Now;
        }

        /// <summary>
        /// Method to set invoice number and customer name.
        /// This method overloads the earlier defined method that has the same name.
        /// </summary>
        /// <param name="number">Accepts the invoice number</param>
        /// <param name="name">Accepts the customer name</param>
        public void SetDetails(int number, string name)
        {
            this.invoiceNumber = number;
            this.customerName = name;
        }

        /// <summary>
        /// Method to display the invoice details.
        /// </summary>
        public virtual string Display()
        {
            return string.Format("Invoice Number = {0}, InvoiceDate = {1}, CustomerName={2}", this.invoiceNumber, this.invoiceDate, this.customerName);
        }
    }


    /// <summary>
    /// Class Product inherits the Invoice class and stores and displays product information.
    /// </summary>
    public class ProductInvoice : Invoice
    {
        /// <summary>
        /// String field to store the product name.
        /// </summary>
        private string productName;

        /// <summary>
        /// Integer field to store the quantity sold.
        /// </summary>
        private int quantity;

        /// <summary>
        /// Double field to store the price of the product.
        /// </summary>
        private double price;

        /// <summary>
        /// Double field to store the total value of products sold.
        /// </summary>
        private double totalValue;

        /// <summary>
        /// Method to set the details of product.
        /// </summary>
        public void SetDetails(string productName, int quantity, double price)
        {
            base.SetDetails();
            this.productName = productName;
            this.quantity = quantity;
            this.price = price;
            this.totalValue = quantity * price;
        }

        /// <summary>
        /// Method to display the product details.
        /// This method overrides the base class method
        /// </summary>
        public override string Display()
        {
            base.Display();
            return string.Format("Product Name = {0},Quantity = {1},Price = {2}, totalValue={3}", this.productName, this.quantity, this.price, this.totalValue);
        }
    }

    /// <summary>
    /// Class ProductTest is used to test the Product class
    /// </summary>
    class ProductTest
    {
        /// <summary>
        /// The entry point for the application.
        /// </summary>
        /// <param name="args"> A list of command line arguments</param>
        static void Main(string[] args)
        {
            // Instantiating the Product class
            ProductInvoice objProduct = new ProductInvoice();

            Console.Write("Enter the invoice number: ");
            int invoiceNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the customer Name: ");
            string customerName = Console.ReadLine();
            Console.Write("Enter the product Name: ");
            string productName = Console.ReadLine();
            Console.Write("Enter the quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            // Invokes the SetDetails method of Invoice class            
            objProduct.SetDetails(invoiceNumber, customerName);


            // Invokes the overridden SetDetails method of Product class
            objProduct.SetDetails(productName, quantity, price);

            // Invokes the Display method of Product class
            Console.WriteLine(objProduct.Display());

            Console.ReadKey();
        }
    }
}
