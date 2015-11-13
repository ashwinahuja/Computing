using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;



namespace ConsoleApplication1

{

	class Program

	{

		/// Generate river 1
		/// Generate river 3
		/// Generate river 9
		/// Index them all into a boolean array, checking if it is in any of the arrays
		/// Get river n
		/// after every term, check the term against the index
		/// If it is found in the index - check against each array to find which river the number is in (this would return the lowest value of river if it meets multiple simultaneously)
		static int[] riverOne = new int[100000];
		static int[] riverThree = new int[100000];
		static int[] riverNine = new int[100000];
		static bool[] index;
		static int checkWhichRiver (int input)
		{
			for (int i = 0; i < riverOne.Length; i++) {
				if (riverOne [i] == input) {
					return 1;
				}
			}
			for (int i = 0; i < riverThree.Length; i++) {
				if (riverThree [i] == input) {
					return 3;
				}
			}
			for (int i = 0; i < riverNine.Length; i++) {
				if (riverNine [i] == input) {
					return 9;
				}
			}
			return 0;
		}


		static bool checkIndex(int input)

		{

			if (index[input] == true) { return true; }

			else { return false; }

		}

		static int findRiver(int input)

		{

			input = input + findSum(input);

			return input;

		}

		static int findSum(int input)

		{

			int total = 0;

			while(input!=0)
			{

				total += input % 10;
				input /= 10;

			}
			return total;

		}

		static void findRiverOne()

		{

			int counter = 1;

			riverOne[0] = 1;

			while (counter < riverOne.Length)

			{

				riverOne[counter] = riverOne[counter - 1] + findSum(riverOne[counter - 1]);

				counter++;

			}

		}

		static void findRiverThree()

		{

			int counter = 1;

			riverThree[0] = 3;

			while (counter < riverThree.Length)

			{

				riverThree[counter] = riverThree[counter - 1] + findSum(riverThree[counter - 1]);

				counter++;

			}

		}

		static void findRiverNine()

		{

			int counter = 1;

			riverNine[0] = 9;

			while (counter < riverNine.Length)

			{

				riverNine[counter] = riverNine[counter - 1] + findSum(riverNine[counter - 1]);

				counter++;

			}

		}

		static void indexAll()

		{

			int[] max = new int[3];

			max[0] = riverOne.Max();

			max[1] = riverThree.Max();

			max[2] = riverNine.Max();

			int actualMax = max.Max();

			index = new bool[actualMax];

			for (int i = 0; i < riverOne.Length-1; i++)

			{

				index[riverOne[i]] = true;

			}

			for (int i = 0; i < riverThree.Length-1; i++)

			{

				index[riverThree[i]] = true;

			}

			for (int i = 0; i < riverNine.Length-1; i++)

			{

				index[riverNine[i]] = true;

			}

		}

		static void Main(string[] args)

		{

			findRiverOne(); findRiverThree(); findRiverNine(); indexAll();

			Console.WriteLine("Enter input");

			int input = Convert.ToInt32(Console.ReadLine());

			while (!checkIndex(input))

			{

				input = findRiver(input);

			}
			int whichRiver = checkWhichRiver (input);

			Console.WriteLine("It meets river " + whichRiver + " at: " + input);
			Console.ReadLine ();
		}

	}

}