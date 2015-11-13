using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter Input");
			string strInput = Console.ReadLine();
			char[] delimiterChars = { ' ', ',', '.', ':', '\t' }; 
			string[] input = strInput.Split(delimiterChars);
			Console.WriteLine("Number of words is: " + input.Length);
			Console.ReadLine();
		}
	}
}
