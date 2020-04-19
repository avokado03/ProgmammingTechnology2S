using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    public abstract class SubsetsFinder
    {
        public int subsetsCount { get; private set; }

        private const string STR_EMPTY_SUB = "{ empty subset }";
        protected List<string> subsets;
        protected int[] set;

        public SubsetsFinder(int[] set)
        {
            this.set = set;
            subsets = new List<string>();
            subsetsCount = CountSubsets();
        }

        public virtual List<string> GetAllSubsets()
        {
            subsets = subsets.OrderBy(x => x.Length).ToList();
            subsets[0] = STR_EMPTY_SUB;
            return subsets;
        }

        protected int CountSubsets()
        {
            return Convert.ToInt32(Math.Pow(2, set.Length));
        }
    }
}
