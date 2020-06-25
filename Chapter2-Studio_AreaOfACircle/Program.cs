using System;

namespace Chapter2_Studio_AreaOfACircle
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            string input;
            double area;
            //double pi = 3.14;
            
            
            Console.WriteLine("Please enter the radius of the circle: ");
            input = Console.ReadLine();
            radius = double.Parse(input);
            area = Math.PI * Math.Pow(radius,2);
            Console.WriteLine("The area of a circle of radius " + radius + " is: " + area);

            double circumference = 2 * Math.PI * radius;
            double diameter = 2 * radius;
            Console.WriteLine("The circumference of a circle of radius " + radius + " is: " + circumference);
            Console.WriteLine("The diameter of a circle of radius " + radius + " is: " + diameter);

            Console.WriteLine("Please enter the miles per gallon consumption of your car: ");
            input = Console.ReadLine();
            double milesPerGallon = double.Parse(input);
            double aroundTheCircle = milesPerGallon / radius;
            Console.WriteLine("You'll use " + aroundTheCircle + "gallons of gas to drive around this circle.");
        }
    }
}
