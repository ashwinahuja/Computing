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
        static int[] sort(int[] d)
        {
            for (int i = 0; i < d.Length; i++)
            {
                if (i + 1 == d.Length) { return d; }
                else if (d[i] < d[i + 1]) { }
                else { int temp = d[i]; d[i] = d[i + 1]; d[i + 1] = temp; }
            }
            return d;
        }
        static void sort1(int[] dinputs)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            int[] ddinputs = sort(dinputs);
            while (!checkSort(ddinputs))
            {
                ddinputs = sort(dinputs);
            }
            timer.Stop();
            Console.WriteLine("Time taken for method 1 was " + timer.Elapsed);
        }
        static void sort2(int[] dinputs) {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            int[] sort = new int[dinputs.Max() + 1];
            for (int k = 0; k < sort.Length; k++) { sort[k] = 0; }
            for (int j = 0; j < dinputs.Length; j++)
            {
                sort[dinputs[j]]++;
            }
            for (int m = 0; m < sort.Length; m++)
            {
                if (sort[m] > 0)
                {
                    for (int n = 0; n < sort[m]; n++)
                    {
                        
                    }
                }
            }
            timer.Stop();
            Console.WriteLine("Time taken for method 2 was " + timer.Elapsed);
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo info;
            do
            {
                Console.WriteLine("Enter number of random numbers");
                int input = Convert.ToInt32(Console.ReadLine());
                Random r = new Random();
                int[] dinputs = new int[input];
                for (int i = 0; i < dinputs.Length; i++) { dinputs[i] = r.Next(10000); }
                sort1(dinputs);
                sort2(dinputs);
                Console.WriteLine("To start again, enter 'y', otherwise to exit enter another character");
                info = Console.ReadKey();
            }
            while (info.KeyChar == 'y');
        }
    }
}
