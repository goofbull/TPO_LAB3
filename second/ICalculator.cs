using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    internal interface ICalculator
    {
        // Метод для выполнения сложения двух чисел
        double Add(double a, double b);

        // Метод для выполнения вычитания одного числа из другого
        double Subtract(double a, double b);

        // Метод для выполнения умножения двух чисел
        double Multiply(double a, double b);

        // Метод для выполнения деления одного числа на другое
        double Divide(double a, double b);
    }
}
