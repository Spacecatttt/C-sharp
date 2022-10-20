using System;

class HelloWorld
{
    static void Main()
    {
        
		Console.WriteLine("Enter the number: ");
		int num = Convert.ToInt32(100 * Double.Parse(Console.ReadLine()));
		int quantity = 0;
		int[] coins = { 25, 10, 5, 1 };
		foreach (var i in coins)
		{

			quantity += num / i;
			num -= (num / i) * i;
		}
		Console.WriteLine(quantity);
	}
}