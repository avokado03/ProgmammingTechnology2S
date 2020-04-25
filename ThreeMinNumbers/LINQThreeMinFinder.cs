using System.Collections.Generic;
using System.Linq;

namespace ThreeMinNumbers
{
    /// <summary>
    /// Найти 3 минимальных числа в массиве (сортировка)
    /// </summary>
    public class LINQThreeMinFinder : IThreeMinFinder
    {
        public IEnumerable<int> Find(int[] array)
        {
            var arr = array.OrderBy(x => x);
            return arr.Take(3);
        }
    }
}
