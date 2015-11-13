using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication7
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] outputs =  new string[] {"no", "pa", "re", "ci", "vo", "mu", "xa", "ze", "bi", "so"};
			Console.WriteLine("Enter your input");
			string input = Console.ReadLine();
			for (int i = 0; i<input.Length; i=i+2)
			{ 
				for (int j = 0; j < 10; j++) {
					if (outputs [j] [0] == input [i]) {
						Console.Write (j);
					}
				}
			}
			Console.ReadLine();
		}
	}
}
