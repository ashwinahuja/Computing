using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort2
{
    class Program
    {
        static bool checkSort(int[] d)
        {
            for (int i = 0; i < d.Length; i++)
            {
                if (i + 1 == d.Length) { return true; }
                else if (d[i] <= d[i + 1]) { }
                else { return false; }
            }
            return false;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter your inputs to be sourted");
            char[] delimiterChars = { ' ', ',', ';' };
            string[] inputs = Console.ReadLine().Split(delimiterChars);
            int[] dinputs = new int[inputs.Length];
            for (int i = 0; i < inputs.Length; i++) { dinputs[i] = Convert.ToInt16(inputs[i]); }
            int[] sort = new int[dinputs.Max() + 1];
            for (int k=0;k<sort.Length;k++){sort[k] = 0;}
            for (int j = 0; j<dinputs.Length; j++)
            {
                sort[dinputs[j]]++;
            }
            for (int m = 0; m<sort.Length; m++)
            {
                if (sort[m] > 0)
                {
                    for (int n = 0; n<sort[m]; n++)
                    {
                        Console.WriteLine(m);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
