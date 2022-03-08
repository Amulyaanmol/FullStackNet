using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackNet.Operators_and_Control_Flow
{
    public class BinaryOperator
    {
            public static void Division()
            {
                int numerator;
                int denominator;
                int quotient;
                int remainder;
                System.Console.Write("Enter the numerator: ");
                numerator = int.Parse(System.Console.ReadLine());
                System.Console.Write("Enter the denominator: ");
                denominator = int.Parse(System.Console.ReadLine());
                quotient = numerator / denominator;
                remainder = numerator % denominator;
                System.Console.WriteLine($"{numerator} / {denominator} = {quotient} with remainder { remainder} ");
            }
        
    }
}
