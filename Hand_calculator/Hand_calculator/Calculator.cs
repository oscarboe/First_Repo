using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Hand_calculator
{
    public class Calculator
    {
        public double Accumulator{get; private set;}=0;

        public double Add(double a, double b)
        {
            Accumulator+=a+b;

            return a + b;
        }
        public double Subtract(double a, double b)
        {
            Accumulator+= a-b;
            return(a - b);
        }
        public double Multiply(double a, double b)
        {
            Accumulator+=a*b;
            return (a * b);
        }

        public double Power(double x, double exp)
        {
            Accumulator+=Math.Pow(x,exp);
            
            //var Hand_calculator new Accumulator(); 
            return Math.Pow(x,exp);
    
        }

        public double Divide(double dividend, double divison)
        {
            // Dividend er den øverste
            // Devision må ikke være 0!

            double answer;

            if (divison == 0)
                throw new DivideByZeroException();
            answer = dividend / divison;
            return answer;

        }
    }
}
