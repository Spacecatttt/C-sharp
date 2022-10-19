using System;

class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Enter 3 number - lenght the triange: ");
            double a = Convert.ToDouble(Console.ReadLine()) ,b = Convert.ToDouble(Console.ReadLine()),c = Convert.ToDouble(Console.ReadLine());
        double p = (a + b + c) / 2;
        Console.WriteLine(Math.Sqrt(p*(p-a)*(p-b)*(p-c) ));
    }
}