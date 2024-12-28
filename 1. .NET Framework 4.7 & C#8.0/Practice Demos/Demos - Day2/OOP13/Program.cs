using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Program demonstrates implicit and explicit interface implementation
 */ 

namespace OOP13
{
    public interface ITerrestrial
    {
        void Eat();
        void Walk();

    }

    public interface IAquatic
    {
        void Eat();
        void Swim();
    }

    class Crocodile : ITerrestrial, IAquatic
    {
        //Implicit interface implementation
        public void Walk()
        {
            Console.WriteLine("It walks....");
        }

        public void Swim()
        {
            Console.WriteLine("It swims....");
        }

        //Explicit Interface implementation
        void ITerrestrial.Eat()
        {
            Console.WriteLine("Eats Flesh");
        }

        void IAquatic.Eat()
        {
            Console.WriteLine("Eats Fish");
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            IAquatic crocodile1 = new Crocodile();
            crocodile1.Eat();
            crocodile1.Swim();


            ITerrestrial crocodile2 = new Crocodile();
            crocodile2.Eat();
            crocodile2.Walk();

            Console.ReadKey();
        }
    }
}
