using System;
using System.Text.RegularExpressions;

class HelloWorld
{
    static void Main()
    {
        void sum_array(int[] arr)
        {
            int sum = arr.Sum();
            if (sum % 2 == 0) Console.WriteLine("Парне");
            else Console.WriteLine("Непарне");
        }
        Console.WriteLine("Enter array: ");
        string str = Console.ReadLine();
        Regex regex = new Regex(@"\d+");
        int[] arr = regex.Matches(str).Select(x => Int32.Parse(x.Value)).ToArray();
        sum_array(arr);

    }
} 