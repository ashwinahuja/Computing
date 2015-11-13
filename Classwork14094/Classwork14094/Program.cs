using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork14094
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which Year");
            /// 4 years, doesn't 100, 400
            int input = Convert.ToInt16(Console.ReadLine());
            if (input % 4 == 0)
            {
                if (input % 100 == 0)
                {
                    if (input % 400 == 0)
                    {
                        Console.WriteLine("Leap year");
                    }
                    else
                    {
                        Console.WriteLine("Not a leap year");
                    }
                }
                else
                {
                    Console.WriteLine("Leap year");
                }
            }
            else { Console.WriteLine("Not a leap year"); }
            Console.ReadLine();
        }
        
    }
}
