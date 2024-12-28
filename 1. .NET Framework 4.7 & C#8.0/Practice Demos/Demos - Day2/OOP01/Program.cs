using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Accessing Private Variable of a Class using Properties and Methods
 */
namespace OOP01
{
    public class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private char gender;

        public char Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        private float height;

        public float Height
        {
            get { return height; }
            set { height = value; }
        }

        public void FillInformation(string name, int age, char gender, float height)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Height = height;
        }

        public string ShowPersonDetails()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Name  = {0}{1}", name, Environment.NewLine);
            sb.AppendFormat("Age  = {0}{1}", age, Environment.NewLine);
            sb.AppendFormat("Gender  = {0}{1}", gender, Environment.NewLine);
            sb.AppendFormat("Height  = {0}{1}", height, Environment.NewLine);
            return sb.ToString();
        }
    }

    class PersonTest
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Name = "John";
            person1.Age = 31;
            person1.Gender = 'M';
            person1.Height = 5.6f;
            Console.WriteLine("{0} {1} {2} {3}", person1.Name, person1.Age, person1.Gender, person1.Height);

            Person person2 = new Person();
            person2.FillInformation("Sandra", 22, 'F', 5.2f);
            Console.WriteLine(person2.ShowPersonDetails());

            Console.ReadKey();
        }
    }
}
