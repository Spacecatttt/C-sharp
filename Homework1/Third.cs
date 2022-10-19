using System;
class HelloWorld
{
    static void Main()
    {
		Console.WriteLine("Input coordinates of the first point:");
		int x1 = Convert.ToInt32(Console.ReadLine()), y1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Input coordinates of the second point:");
		int x2 = Convert.ToInt32(Console.ReadLine()), y2 = Convert.ToInt32(Console.ReadLine());
		double res = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
		Console.WriteLine("Vector modulus: " + res);

	}
}
