using System;
using System.Collections.Generic;

namespace BIOQ1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter Input");
			int input = Convert.ToInt32 (Console.ReadLine ());
			List<int> primes = new List<int> ();
			primes.Add (2);
			for (int i = 3; i <= input; i = i + 2) {
				bool isItPrime = true;
				int counter = 0;
				while (primes [counter] * primes [counter] <= i) {
					if (i % primes [counter] == 0) {
						isItPrime = false;
						break;
					} else {
						counter++;
					}
				}
				if (isItPrime) {
					primes.Add (i);
				}
			
			}
			int answer = 1;
			List<int> used = new List<int> ();
			while (input != 1) {
				for (int j = 0; j < primes.Count; j++) {
					if (input % primes [j] == 0) {
						///TEST IF IT EXISTS ALREADY
						bool exists = false;
						for (int k = 0; k < used.Count; k++) {
							if (primes [j] == used [k]) {
								exists = true;
								break;
							}
						}
						if (!exists) {
							answer = answer * primes [j];
							used.Add (primes [j]);
						}
						input = input / primes [j];
						break;
					}

				}
			}
			Console.WriteLine (answer);
			Console.ReadLine ();
		}
	}
}
