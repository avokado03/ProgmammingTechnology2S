using System.Collections.Generic;

namespace ThreeMinNumbers
{
    public interface IThreeMinFinder
    {
        IEnumerable<int> Find (int[] array);
    }
}
