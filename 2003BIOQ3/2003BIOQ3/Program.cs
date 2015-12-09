using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _100thBinaryNumber
{
	class Program
	{
		static int factorial(int input)
		{
			int result = 1;
			for (int i = 1; i <= input; i++)
			{
				result = result * i;
			}
			return result;
		}
		static int choose(int top, int bottom)
		{
			int result = (factorial(top)) / ((factorial(bottom)) * (factorial(top-bottom)));
			return result;
		}
		static void Main(string[] args)
		{
			Console.WriteLine ("Enter Input");
			string[] seperated = Console.ReadLine ().Split (' ');
			int count = Convert.ToInt32 (seperated [0]);
			int numberOfOnes = Convert.ToInt32 (seperated [1]);
			int top = numberOfOnes - 1;
			int bottom = 0;
			int length = numberOfOnes-1;
			int temp = 0;
			while (count > temp)
			{
				temp = temp + choose(top, bottom);
				top++;
				bottom++;
				length++;
			}
			top--;
			bottom--;
			temp = temp - choose(top,bottom);
			int numOf0 = length - numberOfOnes;
			int[] answer = new int[length];
			for (int i = 0; i < answer.Length; i++) {
				answer [i] = 1;
				}
			answer[0] = 1;
			int counter = 1;
			while (numOf0 != 0)
			{
				int temp2 =  length - counter;
				numOf0--;
				if ((temp + choose(temp2, numOf0)) >= count)
				{
					answer[counter] = 0;
					counter++;
				}
				else
				{
					answer[counter] = 1;
					counter++;
					temp = temp + choose(temp2, numOf0);
					numOf0++;
				}
			}

			for (int j = 0; j < answer.Length; j++) {
				Console.Write(answer[j]);
			}

			Console.ReadLine();
		}
	}
}