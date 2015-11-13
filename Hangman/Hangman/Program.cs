using System;

namespace Hangman
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter word");
			string input = Console.ReadLine ();
			string revealing = "";
			for (int i = 0; i < input.Length; i++) {
				revealing = revealing + "-";
			}
			Console.Clear ();
			bool terminate = false;
			int lives = 10;
			bool success = false;
			while(!terminate)
			{

					success = false;
					Console.WriteLine ("\n\nEnter letter");
					char usrin = Convert.ToChar (Console.ReadLine ());
					for (int i = 0; i < input.Length; i++) {
						if (input [i] == usrin) {
							string temp = input [i].ToString();
							revealing = revealing.Remove(i, 1).Insert(i, temp);
							success = true;
						}
					}
					int counter = 0;
					for (int i = 0; i < input.Length; i++) {
						if (revealing [i] == '-')
							counter++;
						else {
						}		
					}
					if (counter == 0)
						terminate = true;
					if (!terminate) {
						if (!success) {
							lives--;
							Console.WriteLine ("Nope, here's the board as it stands");
						} else {
							Console.WriteLine ("Got it, here's the board");
						}
						Console.WriteLine ("Lives = " + lives);
						for(int j = 0; j < revealing.Length; j++){
							Console.Write(revealing[j]);}
					}
					if (lives <= 0) {
						terminate = true;
				}
		}
			if (lives != 0) {
				Console.WriteLine ("\n\nYou won, well done!");
			} else {
				Console.WriteLine ("\n\nUnfortunately you ran out of lives - the word was " + input + ". Better luck next time");
			}
			Console.ReadLine();
	}
}
}