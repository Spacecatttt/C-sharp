 using System;

class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Enter a non-negative integer number: ");
        string num_str = Console.ReadLine();
        while (Convert.ToInt32(num_str) < 0)
        {
            Console.WriteLine("Please, enter a non-negative integer number: ");
            num_str = Console.ReadLine();
        }
        int[] numbers = num_str.Select(x => int.Parse(x.ToString())).ToArray(); // do array
        for (int i = 0; i < (Convert.ToString(num_str)).Length; i++) // find length num_str 
        {
            int max = numbers.Max();
            Console.Write(max);
            numbers[Array.IndexOf(numbers, max)] = 0; // find position max element and  = 0
        }

    }
}