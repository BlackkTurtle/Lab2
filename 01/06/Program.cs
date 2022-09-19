using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    internal class Program
    {
        static int num;
        static void Main(string[] args)
        {
            Console.WriteLine("array1:");
            string str;
            str = Console.ReadLine();
            string[] arraystr = str.Split(' ');
            int[] array = new int[arraystr.Length];
            for (int i = 0; i < arraystr.Length; i++)
            {
                array[i] = Convert.ToInt32(arraystr[i]);
            }
            var str1 = string.Join(" ", array);
            Console.WriteLine(str1);
            int a=0, count=0;
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (i == array[j])
                    {
                        count++;
                        if (a < count)
                        {

                            a = count;
                            num = i;
                        }
                    }
                    else
                    {
                        count = 0;
                    }
                }
            }
            for (int i = 0; i < a; i++)
            {
                Console.Write(num + " ");
            }
        }
    }
}
