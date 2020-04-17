using System;

namespace SInX
{
    class Program
    {

        static void Main(string[] args)
        {
            double x, eps;
            Console.WriteLine("Введите величину угла в радианах: ");
            try
            {
                
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите точность: ");
                eps = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("MyMath.Sin({0}) = {1}",x, MyMath.Sin(x, eps));
                Console.WriteLine("Math.Sin({0}) = {1}", x, Math.Sin(x));
                Console.WriteLine("MyMath.Cos({0}) = {1}", x, MyMath.Cos(x, eps));
                Console.WriteLine("Math.Cos({0}) = {1}", x, Math.Cos(x));
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
