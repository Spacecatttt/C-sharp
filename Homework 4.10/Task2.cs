using System;

class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Enter the water temperature: ");
        double t = Convert.ToDouble(Console.ReadLine());
        if (t <= 0)
        {
            Console.WriteLine("Solid");
        }
        else if( t >= 100){
            Console.WriteLine("Gaseous");
        }
        else
        {
            Console.WriteLine("Liquid");
        }
    } 
} 