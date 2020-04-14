using System;

namespace FindMax
{
    public class MaxFinder
    {
        public int Find(int[] array, int size)
        {
            if (size > 0)
                return Math.Max(array[size], Find(array, --size));
            else return array[0];
        }
    }
}
