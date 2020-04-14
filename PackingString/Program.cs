using System;

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
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
