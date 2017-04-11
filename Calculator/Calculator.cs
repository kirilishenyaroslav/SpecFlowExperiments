using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.AbstractInterface;

namespace Calculator.CalculatorBackEndComponent
{
    public class Calculator: ICalculator
    {
        public decimal Sum(params decimal[] values)
        {
            return values.Sum();
        }

        public decimal Minus(decimal a, decimal b)
        {
            return a - b;
        }

        public decimal Sin(decimal a)
        {
            return (decimal)Math.Sin(Convert.ToDouble(a));
        }

        public decimal Multiply(params decimal[] values)
        {
            decimal result = 1;
            foreach (var m in values)
            {
                result = result * m;
            }

            return result;
        }

        public decimal Divide(decimal a, decimal b)
        {
            try
            {
                return a / b;
            }
            catch(DivideByZeroException exc)
            {
                return 0;
            }
        }
    }
}
