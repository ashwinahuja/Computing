using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork1409
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age");
            int input = Convert.ToInt16(Console.ReadLine());
            if (input < 13) { Console.WriteLine("You are a child"); }
            else if (input > 18) { Console.WriteLine("You are an adult"); }
            else { Console.WriteLine("You are a teenager"); }
            Console.ReadLine();
        }
    }
}
