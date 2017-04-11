using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.AbstractInterface
{
    public interface ICalculator
    {
        decimal Sum(params decimal[] values);

        decimal Minus(decimal a, decimal b);

        decimal Sin(decimal a);

        decimal Multiply(params decimal[] values);

        decimal Divide(decimal a, decimal b);
    }
}
