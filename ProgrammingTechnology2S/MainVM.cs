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
            var projects = new List<ProjectsInfo>();
            projects.Add(new ProjectsInfo
            {
                Name = "FindMax",
                Description = "Найти величину максимума целочисленного массива без использования каких - либо операторов цикла и goto",
                Points = 2
            });

            projects.Add(new ProjectsInfo
            {
                Name = "PackingString",
                Description = "Дана текстовая строка вида: “XXXZZRRVBVVVVVWW…” (не содержащая символа @).Упаковать ее, заменив группы одинаковых символов: VVVVV = @5V",
                Points = 3
            });

            projects.Add(new ProjectsInfo
            {
                Name = "PointInTriangle",
                Description = "Выяснить, находится ли точка в треугольнике, зная координаты вершин и самой точки",
                Points = 2
            });

            projects.Add(new ProjectsInfo
            {
                Name = "ReversePolishNovation",
                Description = "Определить значение выражения в постфиксной форме записи",
                Points = 3
            });

            projects.Add(new ProjectsInfo
            {
                Name = "SinX",
                Description = "Найти значение синуса угла, разложив функцию синуса в ряд",
                Points = 3
            });

            projects.Add(new ProjectsInfo
            {
                Name = "SubsetsFinding",
                Description = "Найти все подмножества заданного множества",
                Points = 5
            });

            projects.Add(new ProjectsInfo
            {
                Name = "ThreeMinNumbers",
                Description = "Найти 3 минимальных значения в целочисленном массиве",
                Points = 3
            });

            projects.Add(new ProjectsInfo
            {
                Name = "UnpackingString",
                Description = "Распаковать строку из PackingString",
                Points = 3
            });
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
