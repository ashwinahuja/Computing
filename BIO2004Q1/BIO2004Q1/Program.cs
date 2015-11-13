using System;

namespace BIO2004Q1
{
	class MainClass
	{
		static int[][] board
		static void printBoard(){
		}
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter input");
			string useless = Console.ReadLine ();
			string input = Console.ReadLine ();
			char[] playerOne = new int[Convert.ToInt16(useless)/2];
			char[] playerTwo = new int[Convert.ToInt16 (useless) / 2];
			counter = 0;
			for (int i = 0; i < useless; i = i + 2) {
				playerOne [counter] = input [i];
				counter++;
			}
			counter = 0;
			for (int i = 1; i < useless; i = i + 2) {
				playerTwo [counter] = input [i];
				counter++;
			}
			generateBoard ()
		}
	}
}
