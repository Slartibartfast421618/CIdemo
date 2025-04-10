using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIdemo1
{

        public class CalculatorImplementation : ICalculator
        {
            public int Add(int a, int b) => a + b;
            public int Subtract(int a, int b) => a - b;
            public int Multiply(int a, int b) => a * b;
            public int Divide(int a, int b)
            {
                if (b == 0)
                    throw new DivideByZeroException();
                return a / b;
            }

            public double Power(double a, double b) => Math.Pow(a, b);
            public double SquareRoot(double a) => Math.Sqrt(a);
        }
    }

