using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrMathParser.Helper
{
    public static class TestExpression
    {
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
            };
            int i = 0;
            var errors = new List<int>();
            foreach(var t in tests)
            {
                try
                {
                    var asdf = string.Empty;
                    if (t.Key == "5*2+10")
                        asdf = t.Key;
                    Assert(t.Key, t.Value);
                } catch(Exception e)
                {
                    errors.Add(i);
                    Console.WriteLine($"=>{e.Message}");
                }
                i++;
            }
            Console.WriteLine($"Errors at lines: {string.Join(",", errors.Select(x => x.ToString()).ToArray())}");
            Console.WriteLine("===Complete===");
        }

        private static void Assert(string s, int expectedResult)
        {
            var r = Expression.Eval(s);
            if (r != expectedResult)
                throw new Exception($"Assert Failed.  Expression {s} was expected to return {expectedResult} but instead returned {r}");
        }
    }
}
