using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilsLibrary
{
    public static class ArrayUtils
    {
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine();
        }

        public static void PrintArray(int[] array, int from, int to)
        {
            for (int i = from; i <= to; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine();
        }

        public static int[] SetArray(int length = 10)
        {
            int[] array = new int[length];
            for(int i = 0; i<length; i++)
            {
                Console.WriteLine("Введите {0} элемент массива: ", i);
                int parseResult;
                string item = Console.ReadLine();
                if (Int32.TryParse(item, out parseResult))
                    array[i] = parseResult;
                else
                    throw new FormatException("Введенное значение не может быть преобразовано в Int32");
            }
            Console.WriteLine("Ввод окончен");
            return array;
        }

        public static int SetArrayLength()
        {
            Console.WriteLine("Введите длину массива: ");
            int arrLength;
            string length = Console.ReadLine();
            if (Int32.TryParse(length, out arrLength))
            {
                return arrLength;
            }
            else
            {
                throw new FormatException("Введенное значение не может быть преобразовано в Int32");
            }
        }

        public static int[] GetRandomArray(int lenght)
        {
            
            Random random = new Random();
            int[] arr = new int[lenght];
            for (int i = 0; i < lenght; i++)
            {
                arr[i] = random.Next(-9, 9);
            }
            return arr;
        }
    }
}
