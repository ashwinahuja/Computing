using System;

namespace BIO2011q1
{
	class MainClass
	{
		public static char numberOne = 'A';
		public static char numberTwo = 'A';
		public static char nextNumber = 'A';
		static void findNext()
		{
			int number1 = ConvertToNumber (numberOne);
			int number2 = ConvertToNumber (numberTwo);
			int temp = number1 + number2;
			char replacement = ConvertToCharacter (temp);
			numberOne = numberTwo;
			numberTwo = replacement;
		}
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter Input");
			string togetherI = Console.ReadLine ();
			string[] input = togetherI.Split(' ');
			numberOne = Convert.ToChar(input[0]);
			numberTwo = Convert.ToChar (input [1]);
			int counter = 2;
			int targetNumber = Convert.ToInt32 (input [2]);
			if (targetNumber == 1) {
				numberTwo = numberOne;
			}
			else
			{
				while (counter != targetNumber) {
				findNext ();
				counter++;
				}
			}
			Console.WriteLine (numberTwo);
			Console.ReadLine ();
		}
		static int ConvertToNumber(char input)
		{
			string definition = "0ABCDEFGHIJKLMNOPQRSTUVWXYZ";
			for (int i = 0; i < definition.Length; i++) {
				if (input == definition [i]) {
					return i;
				}
			}
			return 0;
		}
		static char ConvertToCharacter(int temp)
		{
			string definition = "0ABCDEFGHIJKLMNOPQRSTUVWXYZ";
			if (temp > 26) {
				temp = temp - 26;
			}
			return definition [temp];
		}
	}
}
