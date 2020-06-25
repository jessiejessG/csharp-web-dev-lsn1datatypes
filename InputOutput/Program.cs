using System;

namespace InputOutput
{
    class MainClass {
		static void Main (string[] args)
		{
			//Declare all variables at the top
			//Put our prompt in to a variable and use the variable in the WriteLine
			//Let's declare our name variable at the top, but assign it with the ReadLine
			//Let's create a variable to hold our greeting;
			string prompt = "What is your name?";
			string name;
			string greeting = "Hello";



			Console.WriteLine(prompt);

			name = Console.ReadLine();

			Console.WriteLine(greeting + ", " + name);
		}
	}
};
