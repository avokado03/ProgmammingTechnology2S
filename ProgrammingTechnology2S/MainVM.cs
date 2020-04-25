using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProgrammingTechnology2S
{
    public class MainVM
    {
        private IList<ProjectsInfo> projects = new List<ProjectsInfo>();
        private ProjectsInfo selectedProject;
        private int points;

        public MainVM()
        {
            projects = GetProjects();
            points = CalculatePoints();
        }

        public IList<ProjectsInfo> GetProjects()
        {
            var projects = ProjectsList.projects;
            return projects;
        }
        public int CalculatePoints()
        {
            return projects.Sum(x => x.Points);
        }
        public IList<ProjectsInfo> Projects
        {
            get
            {
                return projects;
            }
            set
            {
                projects = value;
            }
        }

        public ProjectsInfo SelectedProject
        {
            get
            {
                return selectedProject;
            }
            set
            {
                selectedProject = value;
            }
        }

        public int Points { get => points; set => points = value; }
    }
}
