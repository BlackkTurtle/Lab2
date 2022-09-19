using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
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
            if (array1.Length <= array2.Length)
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    char chara = Convert.ToChar(array1[i]);
                    int a = char.ToUpper(chara) - 64;
                    char charb = Convert.ToChar(array2[i]);
                    int b = char.ToUpper(charb) - 64;
                    if (a < b)
                    {
                        var str1 = string.Join("", array1);
                        Console.WriteLine(str1);
                        var str2 = string.Join("", array2);
                        Console.WriteLine(str2);
                        break;
                    }
                    else if(i==array1.Length-1)
                    {
                        var str1 = string.Join("", array1);
                        Console.WriteLine(str1);
                        var str2 = string.Join("", array2);
                        Console.WriteLine(str2);
                    }else if (b < a)
                    {
                        var str2 = string.Join("", array2);
                        Console.WriteLine(str2);
                        var str1 = string.Join("", array1);
                        Console.WriteLine(str1);
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < array2.Length; i++)
                {
                    char chara = Convert.ToChar(array1[i]);
                    int a = char.ToUpper(chara) - 64;
                    char charb = Convert.ToChar(array2[i]);
                    int b = char.ToUpper(charb) - 64;
                    if (a > b)
                    {
                        var str2 = string.Join("", array2);
                        Console.WriteLine(str2);
                        var str1 = string.Join("", array1);
                        Console.WriteLine(str1);
                        break;
                    }
                    else if (i == array2.Length - 1)
                    {
                        var str2 = string.Join("", array2);
                        Console.WriteLine(str2);
                        var str1 = string.Join("", array1);
                        Console.WriteLine(str1);
                    }
                    else if (b > a)
                    {
                        var str1 = string.Join("", array1);
                        Console.WriteLine(str1);
                        var str2 = string.Join("", array2);
                        Console.WriteLine(str2);
                        break;
                    }
                }
            }
        }
    }
}
