using System;
using System.Collections.Generic;

namespace Broing2008Q1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<int> primes = new List<int> ();
			primes.Add (2);
			for (int i = 3; i < 10000; i++) {
				int counter = 0;
				bool prime = true;
				while(i >= primes[counter] * primes[counter])
					{
						if(i%primes[counter] == 0)
						{
							prime = false;
							break;
						}
						else{
							counter++;
								}
					}
					if(prime)
					{
					primes.Add (i);

						
					}
			}
			Console.WriteLine ("Enter Input");
			int input = Convert.ToInt32 (Console.ReadLine ());
			int countOfPossibilities = 0;
			for (int i = 0; primes [i] < input; i++) {
				int j = i;
				while (primes [i] + primes [j] <= input) {
					if (primes [i] + primes [j] == input) {
						countOfPossibilities++;
						j++;
					} else {
						j++;
					}
				}
			}
			Console.WriteLine (countOfPossibilities);
			Console.ReadLine ();

		}
	}
}
