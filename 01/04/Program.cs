using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input:");
            int a=int.Parse(Console.ReadLine());
            string str="";
            for (int i=2; i<=a; i++)
            {
                int b = 0;
                for (int j=2; j<=a; j++)
                {
                    if (i % j == 0) { b++; }
                }
                if (b > 1)
                {

                }else
                {
                    str=str+i.ToString()+" ";
                }
            }
            Console.WriteLine(str);
        }
    }
}
