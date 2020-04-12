using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeMinNumbers
{
    public class LINQThreeMinFinder : IThreeMinFinder
    {
        public int[] Find(int[] array)
        {
            var arr = array.OrderByDescending(x => x).ToArray();
            return arr.Take(3).ToArray();
        }
    }
}
