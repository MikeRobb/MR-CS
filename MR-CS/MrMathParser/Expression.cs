using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrMathParser
{
    /// <summary>
    /// An expression is:
    ///     - int
    ///     - (<expression>)
    ///     - <expression><op><expression>
    /// </summary>
    /// <link>https://cs.stackexchange.com/questions/23738/grammar-for-parsing-simple-mathematical-expression</link>
    public static class Expression
    {
        private static char[] _highOps = new[] { '*', '^', '/' };
        private static char[] _lowOps = new[] { '+', '-' };

        public static int Eval(string s)
        {
            // Checks for Paras
            if (IsParaExp(s))
            {
                return HandleParaExp(s);
            }

            // Checks Low Ops
            if (IsBinaryOp(s, _lowOps))
            {
                return HandleBinaryOp(s, _lowOps);
            }

            // Checks High Ops
            if (IsBinaryOp(s, _highOps))
            {
                return HandleBinaryOp(s, _highOps);
            }

            return int.Parse(s);
        }



        #region Binary Operations
        private static bool IsBinaryOp(string s, char[] ops)
        {
            return ops.Any(x => s.IndexOf(x) >= 0);
        }

        private static int HandleBinaryOp(string s, char[] ops)
        {
            int[] indexes = ops.Select(x => s.IndexOf(x)).ToArray();
            if(indexes.Any(x => x >= 0)) {
                char o = ops[0];
                int minI = indexes[0];
                for(int i = 1; i < ops.Length; i++ )
                {
                    var curI = indexes[i];
                    if(minI == -1 || (curI != -1 && curI < minI))
                    {
                        o = ops[i];
                        minI = indexes[i];
                    }
                }

                return OpEval(s.Substring(0, minI), o, s.Substring(minI + 1));
            }

            throw new InvalidOperationException("Attempting to handle a binary operation on a non-binary operation", new Exception(s));
        }

        private static int OpEval(string exp1, char op, string exp2)
        {
            switch(op)
            {
                case '^':
                    return (int)Math.Pow(Eval(exp1), Eval(exp2));
                case '*':
                    return Eval(exp1) * Eval(exp2);
                case '/':
                    return Eval(exp1) / Eval(exp2);
                case '+':
                    return Eval(exp1) + Eval(exp2);
                case '-':
                    return Eval(exp1) - Eval(exp2);
            }

            throw new InvalidOperationException($"A call to a HighOpEval was called with the {op} value;");
        }
        #endregion
        #region Para Operations
        private static bool IsParaExp(string s)
        {
            return s[0] == '(';
        }
        private static int HandleParaExp(string s)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
