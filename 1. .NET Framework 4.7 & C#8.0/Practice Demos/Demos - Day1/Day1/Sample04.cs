using System;
using System.Text;

namespace Day1
{
    class Sample04
    {
        static void Main(string[] args)
        {
            string format;

            // Currency:
            format = "Currency";
            Console.WriteLine("{0} Format:", format);
            Console.WriteLine("{0:C}", 1.2);
            Console.WriteLine("{0:C}", -1.2);

            // Decimal:
            format = "Decimal";
            Console.WriteLine("\n{0} Format:", format);
            Console.WriteLine("{0:D5}", 123);

            // Fixed-point:
            format = "Fixed-point";
            Console.WriteLine("\n{0} Format:", format);
            Console.WriteLine("{0:F2}", 12);
            Console.WriteLine("{0:F0}", 12);
            Console.WriteLine("{0:F0}", 12.3);
            Console.WriteLine("{0:F2}", 12.3);

            // General:
            format = "General";
            Console.WriteLine("\n{0} Format:", format);
            Console.WriteLine("{0:G}", 1.2);
            Console.WriteLine("{0}", 1.23);

            // Numeric:
            format = "Numeric";
            Console.WriteLine("\n{0} Format:", format);
            Console.WriteLine("{0:N}", 12300);

            // Hexadecimal:
            format = "Hexadecimal";
            Console.WriteLine("\n{0} Format:", format);
            Console.WriteLine("{0:X}", 123);
            Console.WriteLine("{0:X}", 65535);

            Console.ReadKey();
        }
    }
}
