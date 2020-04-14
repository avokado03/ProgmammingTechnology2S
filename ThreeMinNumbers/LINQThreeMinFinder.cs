using System.Collections.Generic;
using System.Linq;

namespace ThreeMinNumbers
{
    public class LINQThreeMinFinder : IThreeMinFinder
    {
        public IEnumerable<int> Find(int[] array)
        {
            var arr = array.OrderBy(x => x);
            return arr.Take(3);
        }
    }
}
