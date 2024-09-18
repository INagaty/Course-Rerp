using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    public delegate void MathOperationHandler(double result);

    public class MathOperations
    {
        public event MathOperationHandler Additon;
        public event MathOperationHandler Subtraction;
        public event MathOperationHandler Multiply;
        public event MathOperationHandler Divide;


        public void Add(double x, double y)
        {
            double result = x + y;
            Additon?.Invoke(result);
        }

        public void Subtract(double x, double y)
        {
            double result = x - y;
            Subtraction?.Invoke(result);
        }

        public void Mul(double x, double y)
        {
            double result = x * y;
            Multiply?.Invoke(result);
        }

        public void Div(double x, double y)
        {
            if (y != 0)
            {
                double result = x / y;
                Divide?.Invoke(result);
            }
            else
            {
                Console.WriteLine("Error, Cannot divide by 0");
            }
        }


    }
    internal class Delegates
    {
    }
}
