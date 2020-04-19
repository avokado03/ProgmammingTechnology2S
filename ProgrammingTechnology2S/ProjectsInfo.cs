using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTechnology2S
{
    public class ProjectsInfo
    {
        public string  Name { get; set; }
        public string  Description { get; set; }
        public int  Points { get; set; }

        public ProjectsInfo() { }

        public ProjectsInfo(string name, string description, int points)
        {
            Name = name;
            Description = description;
            Points = points;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
