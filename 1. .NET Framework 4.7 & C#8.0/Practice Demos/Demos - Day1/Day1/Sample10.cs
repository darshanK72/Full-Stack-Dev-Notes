using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    [Flags]//Flags Attribute to use Multiple Enumeration members
    public enum Corners
    {
        None = 0,
        TopLeft = 1,
        TopRight = 2,
        BottomLeft = 4,
        BottomRight = 8
    }

    class Sample10
    {
        static void Main(string[] args)
        {
            Corners cornerIt = Corners.TopLeft | Corners.BottomRight;
            //print Enumeration Members
            Console.WriteLine(cornerIt);

            //Retriving the Value
            int cornersValue = (int)cornerIt;


            if (cornersValue == 9)
                Console.WriteLine("Corner Topleft and BottomRight");

            //Get all Enum members
            string[] corners = Enum.GetNames(typeof(Corners));

            Console.WriteLine("\nPrinting Enum Members ... ");
            foreach (string item in corners)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
