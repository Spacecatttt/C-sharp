using System;

class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Enter the number of rows: ");
        int num = Int32.Parse(Console.ReadLine());
        for(int i = 1; i <= num; i++)
        {
            Console.Write(new String(' ', (num - i)));
            Console.WriteLine(new String('#', i));
        }
    }
} 