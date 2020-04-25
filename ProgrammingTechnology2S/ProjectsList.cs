using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTechnology2S
{
    public static class ProjectsList
    {
        public static List<ProjectsInfo> projects = new List<ProjectsInfo>
        {
            new ProjectsInfo
            {
                Name = "FindMax",
                Description = "Найти величину максимума целочисленного массива без использования каких - либо операторов цикла и goto",
                Points = 2
            },
            new ProjectsInfo
            {
                Name = "PackingString",
                Description = "Дана текстовая строка вида: “XXXZZRRVBVVVVVWW…” (не содержащая символа @).Упаковать ее, заменив группы одинаковых символов: VVVVV = @5V",
                Points = 3
            },
            new ProjectsInfo
            {
                Name = "PointInTriangle",
                Description = "Выяснить, находится ли точка в треугольнике, зная координаты вершин и самой точки",
                Points = 2
            },
            new ProjectsInfo
            {
                Name = "ReversePolishNotation",
                Description = "Определить значение выражения в постфиксной форме записи",
                Points = 3
            },
            new ProjectsInfo
            {
                Name = "SinX",
                Description = "Найти значение синуса угла, разложив функцию синуса в ряд",
                Points = 3
            },
            new ProjectsInfo
            {
                Name = "SubsetsFinding",
                Description = "Найти все подмножества заданного множества",
                Points = 5
            },
            new ProjectsInfo
            {
                Name = "ThreeMinNumbers",
                Description = "Найти 3 минимальных значения в целочисленном массиве",
                Points = 3
            },
            new ProjectsInfo
            {
                Name = "UnpackingString",
                Description = "Распаковать строку из PackingString",
                Points = 3
            }
        };
    }
}
