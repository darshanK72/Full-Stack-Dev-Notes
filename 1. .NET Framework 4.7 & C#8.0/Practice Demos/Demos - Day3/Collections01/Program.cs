using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

/*
 * Program demonstraing working with Arraylist
 */ 


namespace Collections01
{
    public class Sample
    {
        static void Main(string[] args)
        {
            int numberOfElements;
            ArrayList arrList = new ArrayList();

            Console.WriteLine("How many numbers ?:");
            numberOfElements = Convert.ToInt32(Console.ReadLine());

            //Adding elements in ArrayList
            for (int counter = 1; counter <= numberOfElements; counter++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                arrList.Add(number);
            }

            //Displaying elements in ArrayList
            Console.WriteLine("Elements in List are...");
            DisplayElements(arrList);

            //Inserting elements in ArrayList at the given position
            Console.WriteLine("Enter the number to get insert:");
            int insertNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the position to get insert:");
            int position = Convert.ToInt32(Console.ReadLine());
            arrList.Insert(position, insertNumber);

            //Displaying elements in ArrayList after insertion
            Console.WriteLine("Elements in List after insert are...");
            DisplayElements(arrList);


            //Deleting element in ArrayList
            Console.WriteLine("Enter the data to get delete:");
            int delnum = Convert.ToInt32(Console.ReadLine());

            arrList.RemoveAt(arrList.IndexOf(delnum));

            //Displaying elements in ArrayList after deletion
            Console.WriteLine("Elements in List after deleting are...");
            DisplayElements(arrList);

            //Creating another ArrayList 
            ArrayList arrList01 = new ArrayList();
            arrList01.Add(110);
            arrList01.Add(120);
            arrList01.Add(130);

            ICollection collection = arrList01;

            Console.WriteLine("Enter the position to get insert the list of numbers:");
            int poslist = Convert.ToInt32(Console.ReadLine());

            //Inserting a range(Collection) in to Arraylist
            arrList.InsertRange(poslist, collection);

            Console.WriteLine("Elements in List after inserting range...");
            DisplayElements(arrList);

            Console.ReadKey();
        }


        //Displaying elements in ArrayList
        private static void DisplayElements(ArrayList arrList)
        {
            foreach (object obj in arrList)
            {
                int number = (int)obj;
                Console.WriteLine(number);
            }
        }
    }

}
