using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePolishNotation
{
    public static class Operations
    {
        public static Dictionary<string, Func<int, int, string, int>>  GetOperationDictionary()
        {
            var OperationDict = new Dictionary<string, Func<int, int, string, int>>
            {
                {"+", (int fOperand, int sOperand, string operation) => { return fOperand + sOperand; } },
                {"-" ,(int fOperand, int sOperand, string operation) => { return fOperand - sOperand; } },
                {"*", (int fOperand, int sOperand, string operation) => { return fOperand * sOperand; } },
                {"/", (int fOperand, int sOperand, string operation) => { return fOperand / sOperand; } }
            };
            return OperationDict;
        }
    }
}
