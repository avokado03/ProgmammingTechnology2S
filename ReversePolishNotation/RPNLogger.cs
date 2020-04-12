using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
