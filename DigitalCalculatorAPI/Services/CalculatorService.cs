//calling or coonrcting with the Calculator Interfaces
using CalculatorApi.Interfaces;

namespace CalculatorApi.Services
{
    //performing operation with the help of operators
    public class CalculatorService : ICalculatorService
    {
        public double Add(double a, double b) => a + b;

        public double Subtract(double a, double b) => a - b;

        public double Multiply(double a, double b) => a * b;

        public double Divide(double a, double b)
        {
            if (b == 0) throw new DivideByZeroException();
            return a / b;
        }
    }
}
