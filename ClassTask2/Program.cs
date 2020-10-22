using System;

namespace ClassTask2
{
    class Program
    {
        static void Main(string[] args)
            {
                double number1 = 0.1;
                double number2 = 0.3;
                double number3 = 0.8;

                Console.Write("Enter first floating point value");
                double number1= float.Parse(Console.ReadLine());

                Console.Write("Enter second floating point value");
                double number2= float.Parse(Console.ReadLine());

                Console.Write("Enter third floating point value");
                double number3= float.Parse(Console.ReadLine());

            double result = Math.Min (Math.Min(number1, number2),Math.Min (number3));
            Console.WriteLine(float.Parse($"The minimum number is: {Math.Min(result)}"));
            }
    }
}
