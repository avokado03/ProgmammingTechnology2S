using System;

namespace ReversePolishNotation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку выражения с постфиксной записи");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Разделяйте операнды и операторы между собой пробелами!");
            Console.ResetColor();
            string expression = Console.ReadLine();
            RPNCalculator calculator = new RPNCalculator();
            int result = 0;
            try
            {               
                result = calculator.Calculate(expression);               
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
            finally
            {
                Console.WriteLine("Вычисление закончено. Результат: {0}", result);
                Console.Read();
            }
        }
    }
}
