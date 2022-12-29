using System.Security.Cryptography.X509Certificates;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            int x, y, z;
            x = 10;
            y = 5;
            z = -5;

            //addition
            int addTotal = x + y;

            //subtraction
            int subtractTotal = x - y;

            //multiplication
            int multiplyTotal = x * z;

            //division
            int divTotal = x / y;

            //modulus
            int modTotal = x % y;

            Console.WriteLine($"x + y = {addTotal}");
            Console.WriteLine($"x - y = {subtractTotal}");
            Console.WriteLine($"x * z = {multiplyTotal}");
            Console.WriteLine($"x / y = {divTotal}");
            Console.WriteLine($"x % y = {modTotal}\n\n");

            int a, b;
            int quotient;
            int remainder;
            a = 17;
            b = 4;
            quotient = a / b;
            remainder = a % b;

            Console.WriteLine($"17/4 is {quotient} remainder {remainder}.\n");

            Console.Write("Please enter the radius of your circle:  ");
            string userInput = Console.ReadLine();
           

            double radius = double.Parse(userInput);
            
            AreaOfCircle(radius);
        }


        public static void AreaOfCircle (double radius)
        {

            double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"The area of a circle with radius of {radius} is {area}.\n");
                
        }

    }
}
