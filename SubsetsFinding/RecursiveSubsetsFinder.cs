using System.Collections.Generic;
using UtilsLibrary;

namespace ConsoleApp2
{
    public class RecursiveSubsetsFinder : SubsetsFinder
    {

        public RecursiveSubsetsFinder(int[] set) : base(set)
        {

        }

        public override List<string> GetAllSubsets()
        {
            Find(0, string.Empty);            
            return base.GetAllSubsets();
        }

        private void Find(int elementNumber, string subsetStr)
        {
            if (elementNumber == set.Length)
            {
                subsets.Add(subsetStr.ToSet());
                return;
            }
            Find(elementNumber+1, subsetStr);
            subsetStr += set[elementNumber].ToString() + " ";
            Find(elementNumber+1, subsetStr);
        }
    }
}
