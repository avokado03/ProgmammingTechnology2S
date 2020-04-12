using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilsLibrary;

namespace SignSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray;
            int arrLength;
            SequenceFinder finder;
            try
            {
                arrLength = ArrayUtils.SetArrayLength();
                testArray = /*ArrayUtils.SetArray(arrLength);*/ ArrayUtils.GetRandomArray(arrLength);
                ArrayUtils.PrintArray(testArray);
                finder = new SequenceFinder();
                var result = finder.FindSameSignSequence(testArray);
                Console.Write("The largest sequence is: ");
                ArrayUtils.PrintArray(result);
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
