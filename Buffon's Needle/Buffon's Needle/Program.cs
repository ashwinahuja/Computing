using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buffon_s_Needle
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("How many points?");
            double[][] xcoordinate = new double[Convert.ToInt32(Console.ReadLine())][];
            double[][] ycoordinate = new double[xcoordinate.Length][];
            double crossed = 0;
            double notcrossed = 0;
            for (int i = 0; i < xcoordinate.Length; i++)
            {
                xcoordinate[i] = new double[2];
                xcoordinate[i][0] = rnd.NextDouble() * 10;
                double angle = rnd.NextDouble() * 360;
                double length = Math.Cos(angle);
                double height = Math.Sin(angle);
                ycoordinate[i] = new double[2];
                ycoordinate[i][0] = xcoordinate[i][0] + length;
                ycoordinate[i][1] = xcoordinate[i][1] + height;
                for (int j = 0; j < 11; j++)
                {
                    if(xcoordinate[i][0] < j && ycoordinate[i][0] > j) { crossed++; }
                    else if (xcoordinate[i][0] > j && ycoordinate[i][0] < j) { crossed++; }
                    else { notcrossed++; }
                }
            }
            double Probability = crossed / (crossed + notcrossed);
            double pi = 2 / Probability;
            Console.WriteLine(pi);
            Console.ReadLine();
        }
    }
}
