using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n=int.Parse(Console.ReadLine());
            string result = "";
            Array.Sort(array);
            array = array.Distinct().ToArray();
            int b=0;
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[j] - array[i] == n)
                    {
                        result = result + ", [ "+array[i]+" , " + array[j]+" ] ";
                        b++;
                    }
                }
            }
            if (b == 0)
            {
                Console.WriteLine(b);
                Console.WriteLine("No pairs with difference "+n);
            }
            else
            {
                Console.WriteLine(b);
                Console.WriteLine("Pairs of elements with difference "+n+"->"+result);
            }
        }
    }
}