using System;
using System.Collections.Generic;

namespace ThreeMinNumbers
{
    /// <summary>
    /// Найти 3 минимальных числа в массиве
    /// </summary>
    public class DefaultThreeMinFinder : IThreeMinFinder
    {
        public IEnumerable<int> Find(int[] array)
        {
            int first = Int32.MaxValue, second = Int32.MaxValue, third = Int32.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (first > array[i])
                {
                    third = second;
                    second = first;
                    first = array[i];
                }
                else if (second > array[i])
                {
                    third = second;
                    second = array[i];
                }
                else if (third > array[i])
                {
                    third = array[i];
                }
            }
            return new int[] { first, second, third };
        }
    }
}
