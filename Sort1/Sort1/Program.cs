using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace Sort1
{
    class Program
    {
        static bool checkSort(double[] d)
        {
            for (int i = 0; i<d.Length;i++)
            {
                if(i+1 == d.Length) { return true; }
                else if(d[i] <= d[i + 1]) { }
                else { return false; }
            }
            return false;
        }
        static double[] sort(double[] d)
        {
            for (int i = 0; i<d.Length; i++)
            {
                if (i+1 == d.Length) { return d; }
                else if (d[i] < d[i + 1]) { }
                else { double temp = d[i]; d[i] = d[i + 1];d[i + 1] = temp; }
            }
            return d;
        }

        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            Console.WriteLine("Enter your inputs to be sourted");
            char[] delimiterChars = { ' ', ',', ';' };
            string[] inputs = Console.ReadLine().Split(delimiterChars);
            timer.Start();
            double[] dinputs = new double[inputs.Length];
            for(int i = 0; i<inputs.Length; i++){dinputs[i] = Convert.ToDouble(inputs[i]);}
            double[] ddinputs = sort(dinputs);
            while (!checkSort(ddinputs))
            {
                ddinputs = sort(dinputs);
            }
            Thread.Sleep(2000);
            timer.Stop();
            for (int j = 0; j<ddinputs.Length; j++)
            {
                Console.WriteLine(ddinputs[j]);
            }
            Console.Write("Time was " + timer.Elapsed);
            Console.ReadLine();
        }
    }
}
