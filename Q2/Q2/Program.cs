using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shuffling
{
	class Program
	{
		static List<int> cards= new List<int>();
		static List<string> inp = new List<string>();
		static void printAnswers()
		{
			for (int i = 0; i<cards.Count(); i++)
			{
				Console.Write(cards[i] + "\t");
			}
			Console.WriteLine();
		}
		static void mostOfProgram()
		{
			for (int i = 1; i < 9; i++) { cards.Add(i); }

			Console.WriteLine("\nEnter shuffles");
			string input = Console.ReadLine();
			for (int i = 0; i < input.Length; i++)
			{ inp.Add(Convert.ToString(input[i])); }
			do
			{
				expandBrackets();
				resolveNumbers();
			} while (checkBrackets() == 1);
			solve();
			printAnswers();
		}
		static void solve()
		{
			for (int i = 0; i < inp.Count(); i++)
			{
				for (int j = 0; j < inp[i].Length; j++)
				{
					if (inp[i][j] == 'i') { io();}
					else if (inp[i][j] == 'b') { b();}
					else { o();}
				}

			}
		}
		static void resolveNumbers()
		{
			for (int j = 0; j < inp.Count(); j++)
			{
				int outp = 0;
				if (Int32.TryParse(inp[j], out outp))
				{
					if (inp[j + 1] != "(")
					{
						string temp = inp[j + 1];
						for (int k = 0; k < outp - 1; k++)
						{
							inp[j + 1] = inp[j + 1] + temp;
						}
						inp.RemoveAt(j);
					}
				}
			}
		}
		static void expandBrackets()
		{
			int a = 0;
			Start:
			int startBrackets = 0;
			int endBrackets = 0;
			for (int i=a; i < inp.Count(); i++)
			{
				if (inp[i] == "(")
				{

					startBrackets = i;
					int countBrackets = 1;
					for (int j = i + 1; j < inp.Count(); j++)
					{
						if (inp[j] == "(") { a = j;
							goto Start;
						}
						else if (inp[j] == ")") { countBrackets--; }
						if (countBrackets == 0)
						{
							endBrackets = j;
							for (int k = i + 2; k < j; k++)
							{
								inp[i + 1] = inp[i + 1] + inp[k];
							}
							for (int l = 1; l < (endBrackets - startBrackets - 1); l++)
							{
								inp.RemoveAt(i + 2);
							}
							inp.RemoveAt(i + 2);
							inp.RemoveAt(i);
							break;
						}
					}
				}
			}
		}

		static int checkBrackets()
		{
			for (int i = 0; i<inp.Count(); i++)
			{
				if (inp[i] == "(") { return 1; }
			}
			return 0;
		}
		static void Swap(int a, int b)
		{
			int temp = cards[a];
			cards[a] = cards[b];
			cards[b] = temp; }
		static void io()
		{   Swap(0, 1);
			Swap(0, 3);
			Swap(2, 5);
			Swap(0, 7);
			Swap(6, 0);
			Swap(0, 4);}
		static void b()
		{   int temp = cards[0];
			cards.RemoveAt(0);
			cards.Add(temp);}
		static void o()
		{   Swap(1, 2);
			Swap(2, 4);
			Swap(3, 6);
			Swap(2, 1);
			Swap(5, 3);
			Swap(2, 4);}
		static void Main(string[] args)
		{ConsoleKeyInfo info;
			do
			{   mostOfProgram();
				cards.Clear();
				inp.Clear();
				Console.WriteLine("To start again, enter 'y', otherwise to exit enter another character");
				info = Console.ReadKey();}
			while (info.KeyChar == 'y'); }
	}
}
