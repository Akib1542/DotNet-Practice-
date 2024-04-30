using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Math
{
    public class Calculator
    {
        public double Add (double firstNum, double secondNum)
        {
            return (firstNum+secondNum);
        }

        public double Substract( double firstNum, double secondNum)
        {  
            return (firstNum-secondNum);
        }

        public double Multiply (double firstNum, double secondNum)
        {
            return (firstNum*secondNum);
        }

        public int Division (double firstNum, double secondNum)
        {
            if(firstNum == 0)
            {
                Console.WriteLine("Sorry Math Error!");
            }
            return ((int)firstNum/(int)secondNum);
        }
    }
}
