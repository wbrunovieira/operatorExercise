using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = 17;
            var b = 4;

            var div = a / b;
            var mod = a % b;

            Console.WriteLine($"{a}/{b} is {div} remander {mod} ");


            //Allow the user input the radius

            Console.WriteLine("Give me a radius, I calculate the area for you !");
            double realRadius;
            var radius = double.TryParse(Console.ReadLine(), out realRadius);
             
            //Calculate area of the circle
            var areaOfCircle = CalculateArea(realRadius); 

            Console.WriteLine($"The area of circle with radius of {realRadius} is {areaOfCircle}");

        }

        public static double CalculateArea(double radius)
        {
            return Math.PI * (radius * radius);
        }
    }
}
