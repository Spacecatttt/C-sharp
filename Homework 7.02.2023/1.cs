using System;
using System.Collections.Immutable;
using System.Data;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;

class Program
{
	static string path = @"C:\Users\T480\source\repos\Op_practice\Homework 7.02.2023\numbers.txt"; //your path
	static void Main(string[] args)
	{
		init(); //write some numbers in the file

		sort(path);

	}
	public static void init()
	{
		Random rd = new Random();
		string nums = string.Empty;
		for (int i = 0; i < 100; i++)
		{
			nums += rd.Next(1000) + ",";
		}
		nums = nums.Remove(nums.Length - 1);
		File.WriteAllText(path, nums);
	}
	public static void sort(string path)
	{
		string path_of_new_file = @"C:\Users\T480\source\repos\Op_practice\Homework 7.02.2023\SortedNumbers.txt";
		var coll = File.ReadAllText(path).Split(",")
			.Select(x => Convert.ToInt16(x))
			.OrderBy(x => x);
		File.WriteAllText(path_of_new_file, String.Join(',', coll));
	}
}