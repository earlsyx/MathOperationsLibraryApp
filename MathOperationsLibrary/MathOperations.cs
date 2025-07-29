using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperationsLibrary
{
    public class MathOperations
    {
        //Addition
        public  double Addition(double x, double y)
        {
            return x + y;
        }


        //Subtraction
        public  double Subtraction(double x, double y)
        {
            return x - y;
        }
        //Multiplication
        public  double Multiplication(double x, double y)
        {
            return x * y;
        }
        //Division
        public  decimal Division(decimal x, decimal y)
        {
            return (x / y);
        }
    }
}
