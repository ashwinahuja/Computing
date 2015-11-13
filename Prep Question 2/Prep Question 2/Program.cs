using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prep_Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of pounds ");
            string input = Console.ReadLine();
            int iinput = Convert.ToInt16(input);
            int[] poundValues = new int[] { 10, 7, 6, 2, 1 };
            int[] outputValues = new int[poundValues.Length];
            for (int i = 0; i < poundValues.Length; i++)
            {
                outputValues[i] = iinput / poundValues[i];
                iinput = iinput % poundValues[i];
            }
           /// Console.Clear();
            for (int j = 0; j < poundValues.Length; j++)
            {
                if (outputValues[j] != 0)
                {
                    Console.Write(outputValues[j] + " x £" + poundValues[j]);
                    if (poundValues[j] > 4)
                    {
                        if (outputValues[j] > 1) { Console.WriteLine(" notes");}
                        else { Console.WriteLine(" note"); }
                    }
                    else
                    {
                        if (outputValues[j] > 1) { Console.WriteLine(" coins"); }
                        else { Console.WriteLine(" coin"); }
                    }
                }
            }
            Console.ReadLine();
         }
    }
}
