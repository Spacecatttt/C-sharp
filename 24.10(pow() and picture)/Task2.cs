using System;

class HelloWorld
{
    
    static void Main(string[] args)
    {
		Console.WriteLine("Enter a mirror size: ");
		int size = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine($"A mirror of size {size}:");
		Console.WriteLine("#" + new string('=', size * 4) + "#");
		for (int i = 0; i < size; i++)
		{
			if (i != size - 1) { Console.WriteLine(new string(' ', ((size - i - 1) * 2)) + "| <>" + new string('.', i * 4) + "<> |"); }
			else { Console.WriteLine(new string(' ', ((size - i - 1) * 2)) + " |<>" + new string('.', i * 4) + "<>|"); }
		}
		for (int i = size - 1; i >= 0; i--)
		{
			if (i != size - 1) { Console.WriteLine(new string(' ', ((size - i - 1) * 2)) + "| <>" + new string('.', i * 4) + "<> |"); }
			else { Console.WriteLine(new string(' ', ((size - i - 1) * 2)) + " |<>" + new string('.', i * 4) + "<>|"); }
		}
		Console.WriteLine("#" + new string('=', size * 4) + "#");
	}
}