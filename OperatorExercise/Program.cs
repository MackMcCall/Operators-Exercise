using System.Security.Cryptography.X509Certificates;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Create a simple program to write out the results of addition, subtraction, multiplication, division, and modulus operations.
             * For division, create two integer variables called a and b.
             * Create a third integer variable and name it quotient (the result of a division) that stores the result of the division of a and b, and another integer variable named remainder that stores the remainder (using the % operator). 
             * Write out the results using Console.WriteLine or Console.Write to write out the results in the following form: if a = 17 and b = 4, print the following:
             * The result should say: 17/4 is 4 remainder 1
             */

            int addition = 24 + 6;
            Console.WriteLine(addition);

            int subtraction = 24 - 6;
            Console.WriteLine(subtraction);

            int multiplication = 4 * 6;
            Console.WriteLine(multiplication);

            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;


            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}\n");

            //End of Excersice 1

            AreaOfCircle();
        }
        public static double AreaOfCircle()
        {
            /* Create a method that will Calculate the area of a circle based on its radius - you can name the method AreaOfCircle.
             * This method will use this formula Math.PI * Math.Pow(radius, 2) and return the area of type double
             * The method will also accept radius as a parameter
             * Allow a user to input a value for radius in the console using the following code:
             */
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());

            double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"The area of a circle with radius of 20 is {radius}");

            return area;
        }
    }
}
