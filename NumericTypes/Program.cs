using System;

namespace NumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            double length;  // or, you can declare multiple variables on one line:  double length, width;
            double width;
            string input;
            double area;

            Console.WriteLine("Please enter the length of the rectangle: ");
            input = Console.ReadLine();
            length = double.Parse(input);
            
            Console.WriteLine("Please enter the width fo the rectangle: ");
            input = Console.ReadLine();
            width = double.Parse(input);

            area = length * width;
            Console.WriteLine("The area of the rectangle is: " + area);
        }
    }
}
