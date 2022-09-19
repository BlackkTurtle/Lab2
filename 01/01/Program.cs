using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("array1:");
            string str;
            str = Console.ReadLine();
            string[] array1 = str.Split(' ');
            Console.WriteLine("array2:");
            str = Console.ReadLine();
            string[] array2 = str.Split(' ');
            int n = 0, m = 0 ;
            string comments = "";
            if (array1.Length <= array2.Length)
            {
                for(int i = 0; i < array1.Length; i++)
                    if (array1[i] == array2[i])
                    {
                        n++;
                    }
                for (int i = 0; i < array1.Length; i++)
                    if (array1[array1.Length-i-1] == array2[array2.Length-i-1])
                    {
                        m++;
                    }
                if (n == 0 && m == 0)
                {
                    Console.WriteLine("Output:0");
                    Console.WriteLine("No common words at the left and right");
                }
                else if (n >= m)
                {
                    Console.WriteLine("Output:"+n);
                    for (int j = 0; j < n; j++)
                    {
                        comments+=array1[j]+" ";
                    }
                    Console.WriteLine("The largest common end is at the left: "+comments);
                }
                else
                {
                    Console.WriteLine("Output:", m);
                    for (int j = 0; j < m; j++)
                    {
                        comments = comments + array1[array1.Length-m+j]+" ";
                    }
                    Console.WriteLine("The largest common end is at the right: "+comments);
                }
            }
            else
            {
                for (int i = 0; i < array2.Length; i++)
                    if (array1[i] == array2[i])
                    {
                        n++;
                    }
                for (int i = 0; i < array2.Length; i++)
                    if (array1[array1.Length - i - 1] == array2[array2.Length - i-1])
                    {
                        m++;
                    }
                if (n == 0 && m == 0)
                {
                    Console.WriteLine("Output:0");
                    Console.WriteLine("No common words at the left and right");
                }
                else if (n >= m)
                {
                    Console.WriteLine("Output:"+n);
                    for (int j = 0; j < n; j++)
                    {
                        comments = comments + array1[j]+" ";
                    }
                    Console.WriteLine("The largest common end is at the left: "+comments);
                }
                else
                {
                    Console.WriteLine("Output:"+m);
                    for (int j = 0; j < m; j++)
                    {
                        comments = comments + array1[array1.Length -m+ j]+" ";
                    }
                    Console.WriteLine("The largest common end is at the right: "+comments);
                }
            }
        }
    }
}
