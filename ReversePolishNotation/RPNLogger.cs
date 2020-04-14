using System;

namespace ReversePolishNotation
{
    public static class RPNLogger
    {
        public static void Log(int fOperand, int sOperand, string operation, int result)
        {
            Console.WriteLine(fOperand.ToString() + operation + sOperand.ToString() +"="+ result.ToString());
        }
    }
}
