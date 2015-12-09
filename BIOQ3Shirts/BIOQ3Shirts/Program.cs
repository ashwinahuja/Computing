using System;

namespace BIOQ3Shirts
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			char[] shirtsPositionNow = {'1','2','3','4','5','6','7'};
			operationOne (ref shirtsPositionNow);
			for (int i = 0; i < shirtsPositionNow.Length; i++) {
				Console.WriteLine (shirtsPositionNow[i]);
			}
			Console.ReadLine ();
		}
		public static void operationOne (ref char[] shirtsPositionNow)
		{
			char temp = shirtsPositionNow [0];
			shirtsPositionNow [0] = shirtsPositionNow [1];
			shirtsPositionNow [1] = shirtsPositionNow [2];
			shirtsPositionNow [2] = shirtsPositionNow [3];
			shirtsPositionNow [3] = temp;
		}
		public static void operationTwo (ref char[] shirtsPositionNow)
		{
		}
		public static void operationThree (ref char[] shirtsPositionNow)
		{
		}
		public static void operationFour (ref char[] shirtsPositionNow)
		{
		}
	
	}
}
