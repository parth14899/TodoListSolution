//calling with the services
namespace CalculatorApi.Interfaces
{
    public interface ICalculatorService
    {
        double Add(double a, double b);
        double Subtract(double a, double b);
        double Multiply(double a, double b);
        double Divide(double a, double b);
    }
}
