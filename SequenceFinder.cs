using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignSequence
{
    public class SequenceFinder
    {
        /// <summary>
        /// Get a sign of number as Math.Sign()
        /// </summary>
        /// <param name="number"></param>
        /// <returns>-1 if -, 1 if +, 0 if 0</returns>
        private int GetSign(int number)
        {
            if (number > 0)
                return 1;
            else if (number < 0)
                return -1;
            else
                return 0;
        }

        public int[] FindSameSignSequence(int[] array)
        {
            int to =0, count = 1, max = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (GetSign(array[i]) != GetSign(array[i - 1]))
                {
                    if (count > max)
                    {
                        max = count;
                        count = 1;
                    }         
                }
                else
                {
                    count++;
                    if (count > max)
                        to = i;
                }
            }
            int res = max > count ? max : count;
            //ArraySegment<int> segment = new ArraySegment<int>(array, from+1, res);


            return array.Skip(to-res+1).Take(res).ToArray();
        }
    }
}
