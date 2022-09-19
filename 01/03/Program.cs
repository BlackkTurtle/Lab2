using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int a = arr.Length / 4;
            int b = a + arr.Length / 2;

            int c = a - 1;

            for (int i = a; i < b; i++)
            {
                int sum = arr[i] + arr[c];
                Console.Write($"{sum} ");
                c--;
                if (c < 0)
                {
                    c = arr.Length - 1;
                }
            }
        }
    }
}
