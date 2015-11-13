using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
	class Program
	{
		static List<int> primes = new List<int>();
		static bool checkPrime(int input)
		{
			for (int i = 0; i<primes.Count(); i++)
			{
				if (input % primes[i] == 0)
				{
					return false;
				}
				else { }
			}
			return true;
		}
		static void Main(string[] args)
		{
			primes.Add(2);
			int temp = 1;
			int i = 3;
			while(temp == 1)
			{
				if (checkPrime(i))
				{
					primes.Add(i);
					Console.Write (i + "\t");
				}
				else { }
				i++;
			}
			Console.ReadLine();
		}
	}
}
