using System;
using System.Linq;
using UtilsLibrary;

namespace ThreeMinNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = ArrayUtils.SetArrayLength();
            int[] array = ArrayUtils.GetRandomArray(size);
            ArrayUtils.PrintArray(array);
            int[] result;
            try
            {
                IThreeMinFinder linqFinder = new LINQThreeMinFinder();
                result = linqFinder.Find(array).ToArray();
                Console.WriteLine("LINQFinder result:");
                ArrayUtils.PrintArray(result);
                IThreeMinFinder defaultFinder = new DefaultThreeMinFinder();
                result = defaultFinder.Find(array).ToArray();
                Console.WriteLine("DefaultFinder result:");
                ArrayUtils.PrintArray(result);
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
