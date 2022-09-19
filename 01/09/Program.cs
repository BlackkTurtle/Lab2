using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char[] charArray = str.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                char chara = Convert.ToChar(charArray[i]);
                int a = char.ToUpper(chara) - 64;
                Console.WriteLine("{0} -> {1}", charArray[i],a-1);
            }
        }
    }
}
