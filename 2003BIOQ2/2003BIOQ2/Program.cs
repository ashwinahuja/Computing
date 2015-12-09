using System;

namespace BIOQ2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter Inputs");
			int numberOfPebbles = Convert.ToInt16 (Console.ReadLine ());
			int[][] pebbles = new int[numberOfPebbles][];
			for (int i = 0; i < numberOfPebbles; i++) {
				pebbles [i] = new int[3];
				string[] temp = Console.ReadLine ().Split (' ');
				for (int j = 0; j < temp.Length; j++) {
					pebbles [i] [j] = Convert.ToInt32 (temp [j]);
				}
			}
			string[] tempForRiverBanks = Console.ReadLine ().Split (' ');
			int[] riverBanks = new int[tempForRiverBanks.Length];
			for (int k = 0; k < tempForRiverBanks.Length; k++) {
				riverBanks [k] = Convert.ToInt32 (tempForRiverBanks [k]);
			}
			int timeForFinish = Convert.ToInt32 (Console.ReadLine ());
			setUpBoard ();
			for (int l = 0; l < timeForFinish; l++) {
				//CHECK FOR NEW PEBBLES
				for (int m = 0; m < pebbles.Length; m++) {
					if(pebbles[m][2]
				}
			}
		}
	}
}
