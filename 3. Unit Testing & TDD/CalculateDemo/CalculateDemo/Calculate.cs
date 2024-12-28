using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateDemo
{
    public class Calculate
    {
        public int Addition(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Subtract(int num1, int num2)
        {
            int result;

            if (num1 > num2)
            {
                result = num1 - num2;
            }
            else
            {
                result = num2 - num1;
            }

            return result;
        }
        public int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }
        public int Divide(int num1, int num2)
        {
            int result = 0;

            try 
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException ex)
            {
                throw ex;
            }

            return result;
        }
    }
}
