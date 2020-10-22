using System;
namespace Exponent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a base: ");
            var baseNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter an exponent: ");
            var powervalue = Convert.ToInt32(Console.ReadLine());
            var resultOfCalc = IntegerPower(baseNumber, exponent);
            Console.WriteLine("{0} to the power of {1} is {2}", baseNumber, exponent, resultOfCalc);
        }
        private static int Calculatepower(double baseNum, int powervalue)
        {
            double result = 1;
            for (int i = 0; i < powervalue; i++)
            {
                result *= baseNum;
            }
            return result;
        }
    }
}


