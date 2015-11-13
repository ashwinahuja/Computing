using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter input");
			string strInput = Console.ReadLine();
			Console.WriteLine("Enter what you wish to find");
			string strFind = Console.ReadLine();
			Console.WriteLine("Enter what you wish to replace it with");
			string strReplace = Console.ReadLine();
			strInput = strInput.Replace(strFind, strReplace);
			Console.WriteLine(strInput);
			Console.ReadLine();
		}
	}
}
