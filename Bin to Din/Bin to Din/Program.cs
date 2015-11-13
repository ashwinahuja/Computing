using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bin_to_Din
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter input in denary");
            string input = Console.ReadLine();
            int iinput = System.Convert.ToInt16(input);
            string output = Convert.ToString(iinput, 2);

            if (output.Length == 1)
            {
                Console.WriteLine("Binary output is: 000" + output + ".");
                Console.ReadLine();
            }
            else if (output.Length == 2)
            {
                Console.WriteLine("Binary output is: 00" + output + ".");
                Console.ReadLine();
            }
            else if (output.Length == 3)
            {
                Console.WriteLine("Binary output is: 0" + output + ".");
                Console.ReadLine();
            }
            else if (output.Length == 4)
            {
                Console.WriteLine("Binary output is: " + output + ".");
                Console.ReadLine();
            }
            else if (output.Length == 0)
            {
                Console.WriteLine("Binary output is: 0000" + output + ".");
                Console.ReadLine();
            }
            }
    }
}
