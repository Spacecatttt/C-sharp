using System;

class HelloWorld
{
    static void Main()
    {
        
        Console.WriteLine("Enter initial and final indicators of consumed electricity: ");
        double num  = Math.Abs(Convert.ToDouble(Console.ReadLine()) - Convert.ToDouble(Console.ReadLine()));
        Console.Write($"You consumed {num} kw*h electricity and payable: ");
        if (num <= 250)
        {
            Console.WriteLine(Math.Round(num * 1.44 ,2) + " грн");
        }
        else
        {
            Console.WriteLine(Math.Round((num * 1.44 + (num - 250) * 1.68 ), 2) + " грн");
        }
    } 
} 