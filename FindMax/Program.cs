using System;
using System.Linq;
using UtilsLibrary;

namespace FindMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, result;
            int[] X;
            MaxFinder finder;
            try
            {
                n = ArrayUtils.SetArrayLength();
                X = ArrayUtils.GetRandomArray(n);
                ArrayUtils.PrintArray(X);
                finder = new MaxFinder();
                result = finder.Find(X, n-1);
                Console.WriteLine("Max of array is {0}", result);
                Console.WriteLine("Result control with LINQ: {0}", X.OrderByDescending(x=>x).First());
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
