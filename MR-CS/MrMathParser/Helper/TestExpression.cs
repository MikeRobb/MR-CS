using System;
using System.Collections.Generic;
using MrLogger;

namespace MrMathParser.Helper
{
    public static class TestExpression
    {
        private static Logger _log = new Logger($"MrMathParserTest_{DateTime.Now.ToString("yyyyMMdd")}", @"C:\Users\Mike Laptop\Desktop\Data", "flog");

        public static void Log(string msg)
        {
            //_log.Log(msg);
        }

        public static void Test()
        {
            var tests = new Dictionary<string, int>()
            {
                {"5", 5 },
                {"0", 0 },
                {"15", 15 },
                {"999", 999 },
                {"1+5", 6 },
                {"5+1", 6 },
                {"5+5", 10 },
                {"0+0", 0 },
                {"5-4", 1 },
                {"4-5", -1 },
                {"0-0", 0 },
                {"5*1", 5 },
                {"5*2", 10 },
                {"5*0", 0 },
                {"5^0", 1 },
                {"5^1", 5 },
                {"5^2", 25 },
                {"5+1+10", 16 },
                {"5*2+10", 20 },
                {"5+2*10", 25 },
                {"5*2*10", 100 },
                {"5*2/10", 1 },
            };
            int i = 0;
            int errorCount = 0;
            Log($"Starting MrMathParser {tests.Count} Test(s)");
            foreach (var t in tests)
            {
                try
                {
                    Assert(t.Key, t.Value);
                }
                catch (Exception e)
                {
                    Log($"=>{e.Message}");
                    errorCount++;
                }
                i++;
            }

            Log($"Finished MrMathParser with {tests.Count - errorCount} of {tests.Count} successful");
        }

        private static void Assert(string s, int expectedResult)
        {
            var r = Expression.Eval(s);
            if (r != expectedResult)
                throw new Exception($"Assert Failed.  Expression {s} was expected to return {expectedResult} but instead returned {r}");
        }
    }
}
