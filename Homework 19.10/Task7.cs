using System;

class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Enter the number: ");
        Double num = Double.Parse(Console.ReadLine());
        int quantity = 0;
        double[] coins = {0.25 , 0.10 , 0.05, 0.01 };
       foreach( var i in coins)
        {
       
            quantity +=  Convert.ToInt32(Math.Floor( num / i));
            num = Math.Round( num - (Math.Floor((num / i)) * i), 2);
        }
       Console.WriteLine(quantity);
             
    }
}