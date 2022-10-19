using System;

class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Enter month number:");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num == 1 || num == 2 || num == 12)
        {
            Console.WriteLine("Winter");
        }
        else if (num <= 5 && num >= 3)
        {
            Console.WriteLine("Spring");
        }
        else if (num <= 8 && num >= 6)
        {
            Console.WriteLine("Summer");
        }
        else
        {
            Console.WriteLine("Autumn");
        }
    }
} 