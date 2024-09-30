using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    internal class CalculatorService : ICalculatorService
    {
        private readonly ICalculator _calculator;

        public CalculatorService(ICalculator calculator)
        {
            _calculator = calculator;
        }

        public double ExecuteOperation(string operation, double a, double b)
        {
            switch (operation)
            {
                case "+":
                    return _calculator.Add(a, b);
                case "-":
                    return _calculator.Subtract(a, b);
                case "*":
                    return _calculator.Multiply(a, b);
                case "/":
                    return _calculator.Divide(a, b);
                default:
                    throw new InvalidOperationException("Неизвестная операция.");
            }
        }
    }
}
