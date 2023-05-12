using System;

namespace ConsoleApplication
{
	class Factorial
	{
		static int factorial(int x)
		{
			int r = 1;

			for(int i = 1; i <= x; i++)
			{
				//r *= factorial(i);

				//r = r * i;

				r *= i;
			}

			return r;


		}
		static void Main(string[] args)
		{

			int d = 5;

			Console.WriteLine("Hello, the Factorial of D ."+" " + factorial(d));
		}

	}
}