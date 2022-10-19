using System;

class HelloWorld
{
    static void Main()
    {
           Console.Write("Enter the number of rows: ");
           int num = Convert.ToInt32(Console.ReadLine());
            for (int y = 0; y < num; y++)
            {
                int c = 1;
                for (int q = 0; q < num - y; q++) //space 
                {
                    Console.Write("   ");
                }

                for (int x = 0; x <= y; x++)
                {
                    Console.Write($"   {c} ");
                    c = c * (y - x) / (x + 1);
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        
    }
}