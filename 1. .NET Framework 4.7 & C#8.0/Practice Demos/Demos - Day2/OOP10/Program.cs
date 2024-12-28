using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Program demonstrates usage of virtual, new and override keyword
 */
namespace OOP10
{
    class First
    {
        public virtual void Show1()
        {
            Console.WriteLine("First Show 1");
        }

        public virtual void Show2()
        {
            Console.WriteLine("First Show 2");
        }

    }

    class Second : First
    {
        public override void Show1()
        {
            Console.WriteLine("Second Show 1");
        }

        public new void Show2()
        {
            Console.WriteLine("Second Show 2");
        }

    }

    class Test
    {
        static void Main(string[] args)
        {
            First obj = new Second();
            obj.Show1();
            obj.Show2();

            Console.ReadKey();
        }
    }
}
