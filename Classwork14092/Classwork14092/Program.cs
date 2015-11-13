using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork14092
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers, one per line");
            int input1 = Convert.ToInt16(Console.ReadLine());
            int input2 = Convert.ToInt16(Console.ReadLine());
            int input3 = Convert.ToInt16(Console.ReadLine());
            if (input1 >= input2)
            {
                if (input3 >= input1) { Console.WriteLine(input3 + ", " + input1 + ", " + input2); }
                else if (input3 > input2) { Console.WriteLine(input1 + ", " + input3 + ", " + input2); }
                else { Console.WriteLine(input1 + ", " + input2 + ", " + input3); }
            }
            else if (input3 >= input2)
            {
                Console.WriteLine(input3 + ", " + input2 + ", " + input1);
            }
            else
            {
                if(input3 > input1) { Console.WriteLine(input2 + ", " + input3 + ", " + input1); }
                else { Console.WriteLine(input2 + ", " + input1 + ", " + input3); }
            }
            Console.ReadLine();
        }
    }
}
