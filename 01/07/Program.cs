using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 1;
            int Bigger = 0;
            int[] arr = { 1 };
            int FirstNumber = int.MaxValue;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == (numbers[i + 1] - arr[0]))
                {
                    counter++;
                    if (counter > Bigger)
                    {
                        Bigger = counter;
                        FirstNumber = numbers[i + 1];
                    }
                }
                else
                {
                    counter = 1;
                }
            }
            int[] LastArr = new int[Bigger];
            for (int i = Bigger - 1; i >= 0; i--)
            {
                LastArr[i] = FirstNumber;
                FirstNumber--;
            }
            Console.WriteLine(string.Join(" ", LastArr));
        }
    }
}
