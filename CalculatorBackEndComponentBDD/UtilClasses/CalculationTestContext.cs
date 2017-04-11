using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.AbstractInterface;
using Calculator.CalculatorBackEndComponent;

namespace CalculatorBackEndComponentBDD
{
    public class CalculationTestContext
    {
        private readonly List<decimal> _values = new List<decimal>();

        public ICalculator Calculator { get; private set; }

        public decimal Result { get; set; }

        public Exception Exception { get; set; }

        public List<decimal> Values
        {
            get { return _values; }
        }

        public CalculationTestContext()
        {
            Calculator = new Calculator.CalculatorBackEndComponent.Calculator();
        }
    }
}
