using System;
using System.Text.RegularExpressions;

class HelloWorld
{
    static void Main()
    {
        int unique_m(int[] arr)
        {
            int[] dis = arr.Distinct().ToArray();
            int counter = 0;
            
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == dis[0])
                    {
                        counter++;
                    }

                }
            if (counter == 1)  return dis[0];
            else return dis[1];
            
         }
        Console.WriteLine("Enter array: ");
        string str  = Console.ReadLine();
        Regex regex = new Regex(@"\d+");
        int[] arr = regex.Matches(str).Select(x => Int32.Parse(x.Value)).ToArray();

        Console.WriteLine($"Qnique element ==> {unique_m(arr)}");


    }
}