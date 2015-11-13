using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Number of coordinates");
			int number = Convert.ToInt32(Console.ReadLine());
			double[][] coordinates = new double[number][];
			Random rnd = new Random();
			double counterYes = 0; double counterNo = 0;
			for (int i = 0; i < number; i++)
			{
				coordinates[i] = new double[2];
				coordinates[i][0] = rnd.NextDouble() * 2;
				coordinates[i][1] = rnd.NextDouble() * 2;
				double temp = ((coordinates[i][0]-1) * (coordinates[i][0]-1)) + ((coordinates[i][1]-1) * (coordinates[i][1]-1));
				if (temp > 1){counterNo++;}
				else {counterYes++;}
			}
			double Pi = counterYes / (counterNo+counterYes)*4;
			Console.WriteLine("Pi is " + Pi);
			Console.ReadLine();
		}
	}
}
