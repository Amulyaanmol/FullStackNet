
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackNet.Operators_and_Control_Flow
{
    public class UnaryExample
    {
        public static void UnaryOperator()
        {
            int x = 123;
            // Displays 123, 124, 125.
            System.Console.WriteLine($"{x++}, {x++}, {x}");
            // x now contains the value 125.
            // Displays 126, 127, 127.
            System.Console.WriteLine($"{++x}, {++x}, {x}");
            // x now contains the value 127.
        }
    }
}
