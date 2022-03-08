using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackNet.IntroducingCSharp
{
    public class VariableCreate
    {
        // Creating a Variable and Assigning value to it then modify it
        public static void Variable()
        {
            string change; //create variable of type string
            string message = "Enjoy the day!"; // Assign value to variable
            change = "do you think soo?";
            System.Console.WriteLine(message);
            System.Console.WriteLine(change);
            message = "yes."; // changing the value of variable
            System.Console.WriteLine(message);
        }
    }
}
