using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackNet.DataTypes
{
    public class Immutables
    {
        public static void Uppercase()
        {
            string text, uppercase;
            System.Console.Write("Enter text: ");
            text = System.Console.ReadLine();
            // UNEXPECTED: Does not convert text to uppercase
            text.ToUpper();
            System.Console.WriteLine(text);
            System.Console.WriteLine("After saving the returned value");
            uppercase = text.ToUpper();
            System.Console.WriteLine(uppercase);
        }
    }
}
