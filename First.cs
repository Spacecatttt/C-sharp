using System;
class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Input 4 numbers:");
        int minimal = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 3; i++)
            {
            int a = Convert.ToInt32(Console.ReadLine());
            if (minimal > a){
                minimal = a;
            }
            }
            Console.WriteLine("The min number: " + minimal);
    }
}
