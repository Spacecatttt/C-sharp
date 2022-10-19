using System;
class HelloWorld
{
    static void Main()
    {
    Console.WriteLine("Please input sides of the triangle");
    double a = Double.Parse(Console.ReadLine());
    double b = Double.Parse(Console.ReadLine());
    double c = Double.Parse(Console.ReadLine());
    double p = (a + b + c) / 2;
    double square = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    Console.WriteLine("Square: " + square);
  }
}
