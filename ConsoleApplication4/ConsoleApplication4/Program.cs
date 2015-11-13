using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QuickSort
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the numbers that you intend to sort (using QuickSort)");
            string input = Console.ReadLine();
            string[] arrin = input.Split(' ');
            int[] numbers = new int[arrin.Length];
            int counter = 0;
            for (int i = 0; i < arrin.Length; i++)
            {
                int temp = int.Parse(arrin[i]);
                numbers[counter] = temp;
                counter++;
            }

        }
        private void quicksort(int[] input, int low, int high)
        {
            int pivot_loc = 0;

            if (low < high)
            {
                pivot_loc = partition(input, low, high);
                quicksort(input, low, pivot_loc - 1);
                quicksort(input, pivot_loc + 1, high);
            }
        }

        private int partition(int[] input, int low, int high)
        {
            int pivot = input[high];
            int i = low - 1;

            for (int j = low; j < high - 1; j++)
            {
                if (input[j] <= pivot)
                {
                    i++;
                    swap(input, i, j);
                }
            }
            swap(input, i + 1, high);
            return i + 1;
        }



        private void swap(int[] ar, int a, int b)
        {
            int temp = ar[a];
            ar[a] = ar[b];
            ar[b] = temp;
        }

    }
}

