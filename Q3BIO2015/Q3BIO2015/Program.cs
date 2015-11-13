using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
	class Program
	{
		static string arr;
		static void Main(string[] args)
		{
			List<string> permutations = new List<string>();
			Console.WriteLine("Enter Input");
			char[] delim = { ' ' };
			string strinput = Console.ReadLine();
			string[] splitInput = strinput.Split(delim);
			int counter = 0;
			int[] iinput = new int[splitInput.Length];
			for (int i = 0; i < splitInput.Length; i++)
			{
				iinput[counter] = Convert.ToInt32(splitInput[i]);
				counter++;
			}
			for (int j = 0; j < iinput[0]; j++)
			{
				arr = arr + "A";
			}
			for (int k = 0; k < iinput[1]; k++)
			{
				arr = arr + "B";
			}
			for (int l = 0; l < iinput[2]; l++)
			{
				arr = arr + "C";
			}
			for (int m = 0; m < iinput[3]; m++)
			{
				arr = arr + "D";
			}
			Console.WriteLine(arr);
			permutations.Add(arr);
			permute(ref permutations);
			Console.WriteLine("\n");
			permutations.Sort();
			Console.WriteLine(permutations[iinput[4] - 1]);
			Console.ReadLine();

		}
		static void permute(ref List<string> permutations)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				int counter = i +1;
				while (counter < arr.Length)
				{
					swap(i, counter);
					if(!checkIndex(ref permutations))
					{
						permutations.Add(arr);
						permute(ref permutations);
					}
					swap(i, counter);
					counter++;
				}
			}
		}

		static bool checkIndex(ref List<string> permutations)
		{
			for (int i = 0; i<permutations.Count(); i++)
			{
				if (permutations[i] == arr)
				{ return true; }
			}
			return false;
		}
		static void swap(int a, int b)
		{
			char[] temp = arr.ToCharArray();
			char temp2 = temp[a];
			temp[a] = temp[b];
			temp[b] = temp2;
			arr = new string (temp);
		}

	}
}
