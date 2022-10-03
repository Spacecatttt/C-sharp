using System;
class HelloWorld
{
    static void Main()
    {
        int minimal = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 3; i++)
            {
            int a = Convert.ToInt32(Console.ReadLine());
            if (minimal > a){
                minimal = a;
            }
            }
            Console.WriteLine(minimal);
    }
}
