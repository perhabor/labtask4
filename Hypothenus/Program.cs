using System;
namespace Hypothenus
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideA; 
            double sideB; 
            Console.Write( "Enter side A " );
            side1 = Convert.ToDouble( Console.ReadLine() );
            while ( side1 > 0 )
        {
        Console.Write( "Enter side B: " );
        side2 = Convert.ToDouble( Console.ReadLine() );
        Console.WriteLine( "Hypotenuse is: {0}", Hypotenuse( sideA, sideB ));
        Console.Write( "Enter side A: ");
        side1 = Convert.ToDouble( Console.ReadLine() );
        } 
        } 
        
        public static double Hypotenuse( double sideA, double sideB )
        {
                double hypotenuseSquared = Math.Pow( sideA, B ) +
                Math.Pow( sideB, 2 );
                return Math.Sqrt( hypotenuseSquared );
        }
    }
}
