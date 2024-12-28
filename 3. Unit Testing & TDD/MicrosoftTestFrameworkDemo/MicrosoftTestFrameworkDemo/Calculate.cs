using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftTestFrameworkDemo
{
    public class Calculate
    {
        public int Addition(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Divide(int num1, int num2)
        {
            int result =0 ;

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
