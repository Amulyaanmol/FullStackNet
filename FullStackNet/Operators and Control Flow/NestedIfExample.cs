
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackNet.Operators_and_Control_Flow
{
    public class NestedIfExample
    {
        public static void NestedIf()
        {
            
            int input; // Declare a variable to store the input.
            System.Console.Write("What is the maximum number " + "of turns ?" + "(Enter 0 to exit.): ");
            // int.Parse() converts the ReadLine()
            // return to an int data type.
            input = int.Parse(System.Console.ReadLine());
            if (input <= 0)
                // Input is less than or equal to 0.
                System.Console.WriteLine("Exiting...");
            else if (input < 5)
                // Input is less than 5.
                System.Console.WriteLine($"It has more than {input}" + " maximum turns.");
            else if (input > 5)
                // Input is greater than 5.
                System.Console.WriteLine($"It has fewer than {input}" + " maximum turns.");
            else
                // Input equals 5.
                System.Console.WriteLine("Correct," + "has a maximum of 5 turns.");
            
        }

    }
}
