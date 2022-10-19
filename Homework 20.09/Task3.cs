using System;

class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Enter number - radius: ");
        double r = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"The area of the sphere: {4 * Math.PI * Math.Pow(r, 2)}");
        Console.WriteLine($"The volume of the sphere: {(4 * Math.PI * Math.Pow(r, 3)) / 3}");
    } 
}