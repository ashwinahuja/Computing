using System;

namespace LastOneLoses
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter how many counters to play with");
			int board = Convert.ToInt32 (Console.ReadLine ());
			while (!checkWin(board)) {
				int inputone = askPlayer (1);
				changeBoard (ref board, inputone);
				if (checkWin (board)) {
					returnWinner (1);
					while (1 == 1) {
					}
				}
				printBoard (board);
				int inputtwo = askPlayer (2);
				changeBoard (ref board, inputtwo);
				if (checkWin (board)) {
					returnWinner (2);
					while (1 == 1) {
					}
			}
				printBoard (board);
		}
			Console.WriteLine ();
		}

		static int askPlayer (int player)
		{
			Console.WriteLine ("Enter your input for player " + player + "");
			int inputone = Convert.ToInt32 (Console.ReadLine ());
			return inputone;
			}
		static void changeBoard(ref int board, int player){
			board = board - player;
		}
		static bool checkWin (int board)
		{
			if (board < 1) {
				return true;
			} else {
				return false;
			}
		}
		static void printBoard(int board)
		{
			Console.WriteLine ("Number of pieces still existing = " + board + "");
		}
		static void returnWinner(int player)
		{
			Console.WriteLine ("Well done player " + player + " you have won");
		}
	}
}
