using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackNet.DataTypes
{
    public class PalindromeLength
    {
        public static void Palindrome()
        {
            string palindrome;
            System.Console.Write("Enter a palindrome: ");
            palindrome = System.Console.ReadLine();
            System.Console.WriteLine(
            $"The palindrome \"{palindrome}\" is"
            + $" {palindrome.Length} characters.");
        }
        
    }
}
