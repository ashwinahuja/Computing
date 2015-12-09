using System;

namespace BIOQ1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter Input");
			string input = Console.ReadLine ();
			int multiplier = 1;
			int counter = 0;
			for (int i = 0; i < input.Length; i++) {
				if (input [i] == 'X') {
					counter = counter + 10;
				}
				else if (input [i] == '?') {
					multiplier = 10 - i;
				} else {
					int temp = (int)Char.GetNumericValue(input[i]);
					temp = (10 - i) * temp;
					counter = counter + temp;
				}

			}
			int finalNumber = 11 - (counter % 11);
			if (finalNumber == 11)
				finalNumber = 0;
			finalNumber = finalNumber / multiplier;
			string toOutput = finalNumber.ToString ();
			if(toOutput=="10")
			{
				toOutput="X";
			}
			Console.WriteLine (toOutput);
			Console.ReadLine ();
		}
	}
}
