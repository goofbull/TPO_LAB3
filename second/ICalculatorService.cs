using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    internal interface ICalculatorService
    {
        // Метод для выполнения операции по переданному типу
        double ExecuteOperation(string operation, double a, double b);
    }
}
