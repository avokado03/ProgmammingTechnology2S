using System;

namespace UnpackingString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку для распаковки:");
            string expression;
            StringUnpacker unpacker;
            try
            {
                expression = Console.ReadLine();
                unpacker = new StringUnpacker();
                unpacker.Unpack(expression);
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
