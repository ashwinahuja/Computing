using System;

namespace UpsideDown
{
	class MainClass
	{
		public static double findNextUpsideDown(double lastUpsideDown)
		{
			bool gotOne = false;
			int counter = Convert.ToInt32 (lastUpsideDown);
			while (!gotOne) {
				counter++;
				gotOne = testCounter (counter);
			}
			return Convert.ToDouble (counter);
		}
		public static bool testCounter(int test)
		{
			string forUse = Convert.ToString (test);
			int length = forUse.Length;
			for (int i = 0; i < (length + 1) / 2; i++) {
				int test1 = int.Parse (forUse [i].ToString ());
				int temp = i + 1;
				temp = length - temp;
				int test2 = int.Parse (forUse [temp].ToString ());
				if (test1 + test2 != 10)
					return false;
			}
			return true;
		}

		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter Input");
			double lastUpsideDown = 0;
			int input = Convert.ToInt32 (Console.ReadLine ());
			for (int i = 0; i < input; i++) {
				lastUpsideDown = findNextUpsideDown (lastUpsideDown);
			}
			Console.WriteLine (lastUpsideDown);
			Console.ReadLine ();
		}
	}
}
