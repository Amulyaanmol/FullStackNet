using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackNet.DataTypes
{
    public class TypeConversion
    {
        public static void ConvertString()
        {
            bool boolean = true;
            string text = boolean.ToString();
            // Display "True"
            System.Console.WriteLine(text);
        }
    }
}
