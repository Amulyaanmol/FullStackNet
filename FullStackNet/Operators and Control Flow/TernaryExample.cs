using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackNet.Operators_and_Control_Flow
{
    public class TernaryExample
    {
        public static void TernaryOperator()
        {
            int x = 20, y = 10;

            var result = x > y ? "x is greater than y" : "x is less than y";

            Console.WriteLine(result);
        }
    }
}
