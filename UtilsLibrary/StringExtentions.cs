using System;
using System.Drawing;

namespace UtilsLibrary
{
    public static class StringExtentions
    {
        public static string ToSet(this string set)
        {
            return "{ " + set + "}";
        }

        public static PointF ToPointF(this string coords)
        {
            var xy = coords.Trim('(', ')').Split(' ');
            return new PointF(Convert.ToSingle(xy[0]), Convert.ToSingle(xy[1]));
        }
    }
}
