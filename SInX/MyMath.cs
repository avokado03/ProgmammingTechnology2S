using System;

namespace SInX
{
    public static class MyMath
    {
        public static double Factorial(int N)
        {
            if (N < 0)
                return 0;
            if (N == 0)
                return 1;
            else
                return N * Factorial(N - 1);
        }

        public static double Sin(double x, double eps)
        {
            return GetMaclaurinSinCos(x, eps, 1);
        }

        public static double Cos(double x, double eps)
        {
            return GetMaclaurinSinCos(x, eps, 0);
        }

        /// <summary>
        /// Recursive Method for calculating sine of an angle
        /// </summary>
        /// <param name="x">Angle (rad) </param>
        /// <param name="eps">Аccuracy</param>
        /// <param name="sum">Sum of all items in range</param>
        /// <param name="n">Counter (0 -> infinity)</param>
        /// <param name="sign">Sign of item (as Math.Pow(-1,n))-</param>
        /// <param name="factOf">For getting factorial's param (as 2*n+1).</param>
        /// <returns></returns>
        private static double GetMaclaurinSinCos(double x, double eps, int factOf, double sum = 0, int n = 0, short sign = 1)
        {
            //We can make this operation faster
            //double xn = Math.Pow(-1, n) * Math.Pow(x, 2*n + 1) / Factorial(2*n+1);
            //by two cumulative parameters
            //sign -> Math.Pow(-1, n)
            //factOf -> (2*n+1)
            double xn = sign * (Math.Pow(x, factOf) / Factorial(factOf));
            if (Math.Abs(xn) > eps)
            {
                return GetMaclaurinSinCos(x, eps, factOf += 2, sum + xn,  ++n, sign*=-1);
            }
            else
            {
                return sum;
            }
        }
    }
}
