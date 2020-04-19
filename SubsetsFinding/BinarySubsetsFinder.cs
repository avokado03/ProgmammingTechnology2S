using System.Collections.Generic;
using UtilsLibrary;

namespace ConsoleApp2
{
    /// <summary>
    /// http://espressocode.top/finding-all-subsets-of-a-given-set-in-java/
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
            // Запускаем цикл для печати всех 2 ^ n

            // подмножества по одному

            for (int i = 0; i < (1 << n); i++)
            {
                // Распечатать текущее подмножество
                string subsetStr = string.Empty;

                for (int j = 0; j < n; j++)

                    // (1 << j) это число с j-м битом 1

                    // поэтому, когда мы "и" их с

                    // номер подмножества, какие числа мы получаем

                    // присутствуют в подмножестве и которые

                    // не

                    if ((i & (1 << j)) > 0)
                        subsetStr += set[j].ToString() + " ";
                subsets.Add(subsetStr.ToSet());       
            }
        }
    }
}
