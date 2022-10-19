using System;

class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Enter a, b, c for first equation through a space: ");
        double[] first = new double[3];
        int i = 0;
            foreach(string s in (Console.ReadLine().Split(" "))) 
        { 
            first[i] = Convert.ToDouble(s);
            i++;
        }
        i = 0;
        Console.WriteLine("Enter a, b, c for second equation through a space: ");
        double[] second = new double[3];
        foreach (string s in Console.ReadLine().Split(" "))
        {
            second[i] = Convert.ToDouble(s);
            i++;
        }
        
        Console.WriteLine($"X = {(first[2] * first[1] - second[2] * second[1]) / (first[0]* first[1] - second[0] * second[1])}");
    } 
} 