using System;
using UtilsLibrary;

namespace ConsoleApp2
{
    class Program
    {
        static void RunFinder(SubsetsFinder finder)
        {
            Console.WriteLine("Count of subsets: {0} ", finder.subsetsCount);
            var subsets = finder.GetAllSubsets();
            foreach (var subset in subsets)
                Console.WriteLine(subset);
        }

        static void Main(string[] args)
        {
            int[] mas = ArrayUtils.GetRandomArray(4);
            ArrayUtils.PrintArray(mas);
            SubsetsFinder bFinder, rFinder;
            Console.WriteLine();
            try
            {
                bFinder = new BinarySubsetsFinder(mas);
                RunFinder(bFinder);
                Console.WriteLine("\n ----------------------------------- \n");
                rFinder = new RecursiveSubsetsFinder(mas);
                RunFinder(rFinder);
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
