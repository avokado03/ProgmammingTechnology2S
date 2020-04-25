using System;

namespace FindMax
{
    /// <summary>
    /// Дан массив X типа int и его размер n. Найти величину максимума массива без
    ///использования каких-либо операторов цикла и goto (2 балла)
    /// </summary>
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
