using System;

namespace Demo
{
    public class Calculadora
    {
        public double Somar(double v1, double v2)
        {
            return v1 + v2;
        }

        public double Dividir(double v1, double v2)
        {
            var result = v1 / v2;

            //Dividing a floating-point value by zero doesn't throw an exception; it results in positive infinity, negative infinity, or not a number (NaN)
            //https://docs.microsoft.com/en-us/dotnet/api/system.dividebyzeroexception?redirectedfrom=MSDN&view=net-5.0
            if (double.IsInfinity(result)) throw new DivideByZeroException();

            return v1 / v2;
        }
    }
}