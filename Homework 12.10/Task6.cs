using System;
using System.Text.RegularExpressions;

class HelloWorld
{
    static void Main()
    {
        //while (true) { //to check
        Console.Write("Enter PIN: ");
        string str = Console.ReadLine();
        Console.CursorTop--;
        Console.CursorLeft = str.Length + "Enter PIN: ".Length;
        Regex regex = new Regex(@"^((\d{4})|(\d{6}))$");
        if (regex.IsMatch(str) ) Console.WriteLine(" --> true");
        else Console.WriteLine(" --> false");
    //}
    }
} 