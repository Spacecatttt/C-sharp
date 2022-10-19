using System;

class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        double num = Convert.ToDouble(Console.ReadLine());
        int sum = 0;
        if (num < 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            for (int i = 0; i < num; i++)
            {
                if (i % 3 == 0)
                {
                    sum += i;
                }else if ( i % 5 == 0){
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    }
} 