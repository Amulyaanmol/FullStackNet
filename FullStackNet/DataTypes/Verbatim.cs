using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackNet.DataTypes
{
    public class Verbatim
    {
        public static void Triangle()
        {
            Console.WriteLine("Triangle\n----------------------------------------");
            Console.Write(@"begin
                                         /\
                                        /  \
                                       /    \
                                      /      \
                                     /________\
            end");
        }
    }
}
