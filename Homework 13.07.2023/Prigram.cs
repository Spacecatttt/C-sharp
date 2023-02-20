using System;
using System.Collections.Immutable;
using System.Data;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;

class Program
{
    //your paths
    static string  from_path = @"C:\Users\T480\source\repos\Op_practice\Homework 13.07.2023\from_path.txt"; 
    static string to_path = @"C:\Users\T480\source\repos\Op_practice\Homework 13.07.2023\to_path.txt";
    static void Main(string[] args)
    {
        WriteAll("some text");
        Console.WriteLine(ReadAll());
        WriteLines(new string[]{"First line","Second line"});
        ReadLines();
        WriteSymbol("Writing text".ToCharArray());
        ReadSybol();

    }

   
    public static void WriteAll(string str)
    {
        File.WriteAllText(to_path, str);
    }
    public static string ReadAll()
    {
       return File.ReadAllText(from_path);
    }
    public static void WriteLines(string[] str)
    {
        to_path = @"C:\Users\T480\source\repos\Op_practice\Homework 13.07.2023\to_path2.txt";
        int count = 1;
        foreach (string line in str)
        {
            File.AppendAllText(to_path, line + "\n");
            Console.WriteLine($"Recorded number {count} in the foul line");
        }
        
    }
    public static void ReadLines()
    {
        int count = 0;
        foreach(var line in File.ReadAllLines(from_path))
        {
            Console.WriteLine($"Line number {count}: {line}");
            count++;
        }
    }
    public static void WriteSymbol(char[] chars)
    {
        to_path = @"C:\Users\T480\source\repos\Op_practice\Homework 13.07.2023\to_path3.txt";
        using(StreamWriter file = new StreamWriter(to_path,true)) { 
            foreach(var ch in chars){
             file.Write(ch);
            }
        }

    }
    public static void ReadSybol()
    {
        Console.Write("\nReading the file character by character: ");
        using (StreamReader file = new StreamReader(from_path))
        {
            int now = file.Read();
            while (now != -1) {
                Console.Write((char)now  + " ");
                now = file.Read();
            }
        }

    }
}