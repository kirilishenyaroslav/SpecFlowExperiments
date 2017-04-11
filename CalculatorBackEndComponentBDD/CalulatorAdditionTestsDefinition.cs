using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace CalculatorBackEndComponentBDD
{    
    [Binding]
    public sealed class CalulatorAdditionTestsDefinition: CalculatorTestStepBase
    {        
        public CalulatorAdditionTestsDefinition(CalculationTestContext context):base(context)
        {
            Context = context;
        }

        [Given("I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredSomethingIntoTheCalculator(int number)
        {
            Context.Values.Add(number);
        }
                
        [When("I press (.*)")]
        public void Press(string action)
        {
            switch (action.ToLower())
            {
                case "add":
                case "plus":
                    Context.Result = Context.Calculator.Sum(Context.Values.ToArray());
                    break;
                case "minus":
                    Context.Result = Context.Calculator.Minus(Context.Values[0], Context.Values[1]);
                    break;
                case "multiply":
                    Context.Result = Context.Calculator.Multiply(Context.Values.ToArray());
                    break;
                case "sin":
                    Context.Result = Context.Calculator.Sin(Context.Values[0]);
                    break;
                default: throw new InconclusiveException(string.Format("Action \"{0}\" is not implemented", action));
            }
        }

        [Then("the result should be (.*) on the screen")]
        [Then("the (.*) should be on the screen")]
        public void Result(decimal expected)
        {
            Assert.AreEqual(expected, Context.Result);
        }
        
    }    
}
