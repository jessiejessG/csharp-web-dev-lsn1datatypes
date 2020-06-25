using System;

namespace MoreOnNumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles;
            double gasInGallons;
            double milesPerGallon;
            string input;

            Console.WriteLine("Please enter the number of miles you've driven: ");
            input = Console.ReadLine();
            miles = double.Parse(input);

            Console.WriteLine("Please enter the gallons of gas consumed: ");
            input = Console.ReadLine();
            gasInGallons = double.Parse(input);

            milesPerGallon = gasInGallons / miles;
            Console.WriteLine("Your miles per gallon = " + milesPerGallon);
        }
    }
}
