using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

/*
 * Program to demonstrate yield Statement
 */

namespace Collections06
{
    /* 
      class Program
     {
         static void Main(string[] args)
         {
             foreach (int i in GetInt())
                 Console.WriteLine("Got " + i.ToString());
         }

         public static IEnumerable<int> GetInt()
         {
             for (int i = 0; i < 5; i++)
                 yield return i;
         }
    
     */


    class TestClass : IEnumerable<int>
    {
        #region IEnumerable<int> Members

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 5; i++)
                yield return i;
        }

        #endregion

        #region IEnumerable Members

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion

    }


    class Program
    {
        static void Main(string[] args)
        {
            TestClass obj = new TestClass();
            IEnumerator enumerator = obj.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.ToString());
            }
            Console.ReadKey();
        }
    }
}
