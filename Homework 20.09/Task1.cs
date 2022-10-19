using System;

class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Enter number of day");
        double num = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Hours: " + 24*num );
        Console.WriteLine("Minutes: " + 24 *60 *num);
        Console.WriteLine("Seconds: " + 24 * 3600 *num);

    }
}