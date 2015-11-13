using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuffonNeedle2
{
	class Program
	{
		static void Main(string[] args)
		{
			Random rnd = new Random();
			Console.WriteLine("How many points?");
			double input = Convert.ToDouble (Console.ReadLine ());
			int crossed = 0;
			double x1, x2;
			double angle;
			for (int i = 0; i < input; i++) {
				x1 = rnd.NextDouble() * 10;
				angle = rnd.NextDouble() * Math.PI;
				x2 = x1 + Math.Cos(angle);
				for(int j = 0; j<11; j++){
					if(((x1 < j) && (x2 > j)) || ((x1>j) && (x2<j))){crossed++;}
				}
			}
			double Pi = 2 / (crossed / input);
			Console.WriteLine(Pi);
			Console.ReadLine();
	}
	}
}