using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework20092015
{
    class Program
    {
        static void ask()
        {
            Console.WriteLine("\nEnter your numbers - with any other character to stop");
            List<double> iinputs = new List<double>();
            bool terminate = false;
            while (!terminate)
            {
                double temp;
                if (double.TryParse(Console.ReadLine(), out temp))
                {
                    if (temp > 100 || temp < 0) { terminate = true; }
                    else {
                        iinputs.Add(temp);
                        terminate = false;
                        }
                }
                else { terminate = true; }
            }
            if (iinputs.Count() > 0) { Console.WriteLine("Max: " + iinputs.Max() + "\nMin: " + iinputs.Min() + "\nAverage: " + iinputs.Average()); }
            else { Console.WriteLine("No numbers have been entered"); }
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo info;
            do
            {
                ask();
                Console.WriteLine("To start again, enter 'y', otherwise to exit enter another character");
                info = Console.ReadKey();
            }
            while (info.KeyChar == 'y');

            
        }
    }
}
