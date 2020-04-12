using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackingString
{
    class Program
    {
        static void Main(string[] args)
        {
            StringPacker packer;
            string output = string.Empty;
            Console.WriteLine("Введите строку");
            string input = Console.ReadLine();
            Console.WriteLine("Запаковываем...");
            try
            {
                packer = new StringPacker();
                output = packer.Pack(input);
                Console.WriteLine(output);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
