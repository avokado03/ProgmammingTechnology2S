using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnpackingString;

namespace UnpackingString
{
    class Program
    {
        static void outMas(int[] mas, int num, string s)
        {
            if (num == mas.Length)
            {
                Console.WriteLine(s);
                return;
            }
            outMas(mas, num + 1, s);
            s = s + mas[num].ToString() + ' ';
            outMas(mas, num + 1, s);
        }

        static void Main(string[] args)
        {
            Console.ReadKey();
            //int[] mas = new int[] { 1, 2, 3 };
            //outMas(mas, 0, string.Empty);
            //Console.ReadKey();
        }
    }
}
