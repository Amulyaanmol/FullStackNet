using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackNet.IntroducingCSharp
{
    public class StringVariable
    {
        // Interacting with keyboard - input output
       public static void ShowFullName()
        {
            string firstName;
            string lastName;
            System.Console.WriteLine("Give your FullName!");
            System.Console.Write("Enter your first name: "); // No new line
            firstName = System.Console.ReadLine();// asking value from keyboard
            System.Console.Write("Enter your last name: ");
            lastName = System.Console.ReadLine();
            System.Console.WriteLine(
            $"Your Given name is { firstName } { lastName }."); // Displaying user entered input on to console output using string interpolation
            System.Console.WriteLine("\nUsing Compite Formatting\n----------------------");
            System.Console.WriteLine(
            "Your full name is {0} {1}.", firstName, lastName); //  composite formatting
        }
    }
}
