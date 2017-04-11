using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorBackEndComponentBDD
{
    
    public class CalculatorTestStepBase
    {
        protected CalculationTestContext Context;

        public CalculatorTestStepBase(CalculationTestContext context)
        {
            Context = context;
        }
    }
}
