using System;

namespace SInX
{
    /// <summary>
    /// Вычислить синус разложением в ряд Маклорена, рекурсивно
    /// </summary>
    public class MyMath
    {
        private const double MAX_RAD = 32;
        private double eps = 1;
        private double x = 0;

        public MyMath(double eps, double x)
        {
            this.eps = eps;
            this.x = Validate(x);
        }
       

        public double Sin()
        {
            return GetMaclaurinSin(x,x, 1);
        }

        private double Validate(double x)
        {
            if (x > MAX_RAD)
            {
                var xDeg = x * 180 / Math.PI;
                return xDeg % 360 * Math.PI /180;
            }
            return x;
        }

        private double GetMaclaurinSin(double sum,double xn, double n)
        {
            if (Math.Abs(xn) > eps)
            {
                xn *= -(x * x) / (2 * n) / (2 * n + 1);
                return GetMaclaurinSin(sum+xn, xn, ++n);
            }
            else
            {
                return sum;
            }
        }
    }
}
