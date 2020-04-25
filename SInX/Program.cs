using System;

namespace SInX
{
    class Program
    {

        static void Main(string[] args)
        {
            double x, eps;
            MyMath myMath;
            Console.WriteLine("Введите величину угла в радианах: ");
            try
            {
                
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите точность: ");
                eps = Convert.ToDouble(Console.ReadLine());
                myMath = new MyMath(eps, x);
                Console.WriteLine("MyMath.Sin({0}) = {1}",x, myMath.Sin());
                Console.WriteLine("Math.Sin({0}) = {1}", x, Math.Sin(x));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
