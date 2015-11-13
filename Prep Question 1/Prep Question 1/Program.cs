using System;
namespace Prep_Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int items = 3; ///Number of items defaults to 3 - as the question defines
            ///Console.WriteLine("Number of Items?");///Allows the user to set a number of items other than 3
            ///items = Convert.ToInt16(Console.ReadLine());
            char[] delimiterChars = { ' ', ',', '.', ':', '\t' }; /// Things people might use to seperate different parts of the lines (eg whitespace, commas, colons etc)
            Console.WriteLine("Enter all inputs, one item per line (with item name, quantity and unit cost)");
            string[] strLine = new string[items];/// creates an array to store all the inputs - one line per element
            for (int i = 0; i < items; i++)/// Takes the number of inputs that we expect to receive
            {
                strLine[i] = Console.ReadLine();
            }
            string[][] strSeperatedLine = new string[items][]; /// Creates 2D string array (effectively a 3D array)
            for (int j = 0; j< items;j++)
            {
                strSeperatedLine[j] = strLine[j].Split(delimiterChars); /// Splits the lines by finding the prior defined characters that split the different parts
            }
            int[][] intLines = new int[items][];/// Creates 2D integer array
            for (int q = 0; q< items;q++)
            {
                intLines[q] = new int[3]; /// defines each line as having 3 elements
            }
            for (int k = 0; k < items; k++)
            {
                for (int m = 1; m < 3; m++)
                {
                    intLines[k][m - 1] = Convert.ToInt16(strSeperatedLine[k][m]);///Converts relevant parts of the line into integers
                }
            }
            for (int n = 0; n< items; n++)
            {
                intLines[n][2] = intLines[n][0] * intLines[n][1]; ///Creates total for each line
            }
            int total = 0;
            for (int o = 0; o< items; o++)
            {
                total = total + intLines[o][2];///Sums all the totals for each line
            }
            Console.WriteLine("Item\t\tQuantity\tUnit Cost\tTotal");
            for (int p = 0; p< items; p++)
            {
                if (strSeperatedLine[p][0].Length > 7) ///If the name of the item is longer than 7 characters then one fewer tab is required
                {
                    strSeperatedLine[p][0] = strSeperatedLine[p][0] + '\t';
                }
                else
                {
                    strSeperatedLine[p][0] = strSeperatedLine[p][0] + '\t'; ///For some reason, the system did not let me add two tabs at the same time so I seperated it
                    strSeperatedLine[p][0] = strSeperatedLine[p][0] + '\t';
                }
                Console.WriteLine("" + strSeperatedLine[p][0] + strSeperatedLine[p][1] + "\t\t" + strSeperatedLine[p][2] + "\t\t" + intLines[p][2] + ""); /// Prints all the lines information
            }
            Console.WriteLine("TOTAL" + "\t\t\t\t\t\t" + total + "");
            Console.ReadLine(); /// Prevents the console from closing
        }
    }
}
