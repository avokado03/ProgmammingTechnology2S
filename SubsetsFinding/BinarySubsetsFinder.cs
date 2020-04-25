using System.Collections.Generic;
using UtilsLibrary;

namespace ConsoleApp2
{
    /// <summary>
    /// Найти все подмножества заданного множества (с помощью битового сдвига)
    /// </summary>
    public class BinarySubsetsFinder : SubsetsFinder
    {
        public BinarySubsetsFinder(int[] set) : base(set)
        {
        }

        public override List<string> GetAllSubsets()
        {
            Find();
            return base.GetAllSubsets();
        }

        public void Find()
        {
            int n = set.Length;

            for (int i = 0; i < (1 << n); i++)
            {
                string subsetStr = string.Empty;

                for (int j = 0; j < n; j++)
                {
                    if ((i & (1 << j)) > 0)
                        subsetStr += set[j].ToString() + " ";
                }

                subsets.Add(subsetStr.ToSet());       
            }
        }
    }
}
