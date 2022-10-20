using System;
using System.Text.RegularExpressions;

class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Enter numbers: ");
        string str = Console.ReadLine();
        Console.CursorTop--;
        Console.CursorLeft = str.Length;
        Regex regex = new Regex(@"\d+");
        int[] arr = regex.Matches(str).Select(x => Int32.Parse(x.Value)).ToArray();
        int sum = 0;
        for(int  i = arr[0]; i <= arr[1]; i += arr[2])
        {
            sum += i;
        }
        Console.WriteLine($" --> {sum}");
    }
} 