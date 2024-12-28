using System;
using System.Text;

namespace Day1
{
    class Sample03
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber, result;

            Console.WriteLine("Enter FirstNumber:");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter SecondNumber:");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            result = firstNumber + secondNumber;

            Console.WriteLine("Addition of " + firstNumber + " and " + secondNumber + " is " + result);
            Console.WriteLine("Addition of {0} and {1} is {2}", firstNumber, secondNumber, result);
            Console.ReadKey();
        }
    }
}


/*
	Datatype	Conversion
	========	==========
	byte		Convert.ToByte()
	sbyte		Convert.ToSByte()
	short		Convert.ToInt16()
	ushort		Convert.ToUInt16()
	int			Convert.ToInt32()
	uint		Convert.ToUInt32()
	long		Convert.ToInt64()
	ulong		Convert.ToUInt64()
	float		Convert.ToSingle()
	double		Convert.ToDouble()
	decimal		Convert.ToDecimal()
	bool		Convert.ToBoolean()
	char		Convert.ToChar()
	DateTime	Convert.ToDateTime()
*/