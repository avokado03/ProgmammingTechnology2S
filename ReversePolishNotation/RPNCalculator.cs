using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePolishNotation
{
    public class RPNCalculator
    {
        private Dictionary<string, Func<int, int, string, int>> OperationDict;

        public RPNCalculator()
        {
            FillOperationDictionary();
        }

        public int Calculate(string expression)
        {
            Stack<int> RNPStack = new Stack<int>();
            var elements = expression.Split(' ');
            int operand = 0;
            foreach (string element in elements)
            {
                if (Int32.TryParse(element, out operand))
                    RNPStack.Push(Convert.ToInt32(element));
                else
                {
                    int sOperand = RNPStack.Pop();
                    int fOperand = RNPStack.Pop();
                    int result = GetOperationResult(fOperand, sOperand, element);
                    RNPStack.Push(result);
                    RPNLogger.Log(fOperand, sOperand, element, result);
                }
            }
            return RNPStack.Pop();
        }

        private int GetOperationResult(int fOperand, int sOperand, string operation)
        {
            if (!OperationDict.ContainsKey(operation))
                throw new ArgumentException("Operation not found", operation);
            return OperationDict[operation].Invoke(fOperand, sOperand, operation);
        }

        private void FillOperationDictionary()
        {
            OperationDict = new Dictionary<string, Func<int, int, string, int>>
            {
                {"+", (int fOperand, int sOperand, string operation) => { return fOperand + sOperand; } },
                {"-" ,(int fOperand, int sOperand, string operation) => { return fOperand - sOperand; } },
                {"*", (int fOperand, int sOperand, string operation) => { return fOperand * sOperand; } },
                {"/", (int fOperand, int sOperand, string operation) => { return fOperand / sOperand; } }
            };
        }         
    }
}
