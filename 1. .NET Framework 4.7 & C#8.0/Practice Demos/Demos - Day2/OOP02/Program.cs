using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Demonstrates the usage of constructor and destructor
 */
namespace OOP02
{
    public class Book
    {
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }
        //Constructor
        public Book()
        {
            //Initializing Default Values
            this.Title = "CSharp";
            this.Price = 60.50f;
        }
        //Destructor
        ~Book()
        {
            title = null;
            price = 0.0f;
        }

        public string ShowDetails()
        {
            return string.Format("Book Title = {0} and Book Price = {1}", title, price);
        }

    }
    class BookTest
    {
        static void Main(string[] args)
        {
            Book bookObj = new Book();
            Console.WriteLine(bookObj.ShowDetails());

            Console.ReadKey();
        }

    }
}
