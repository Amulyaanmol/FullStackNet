
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackNet.DataTypes
{
    public class ArrayIntroduction
    {
        public static void OneDiamentionalArray()
        {
            // string[] languages declaration
            //string[] languages = { "C#", "COBOL", "Java",}; Assignment
            // if declaration and assignment happens at same time no need to give new key word

            /*string[] languages;
            languages = new string[]{"C#", "COBOL", "Java"};*/

            string[] languages = { "C#", "COBOL", "Java",
            "C++", "Visual Basic", "Pascal",
            "Fortran", "Lisp", "J#"};

            // Retrieve fifth item in languages array (Java)
            System.Console.WriteLine(languages[4]+" "+ languages.Length);

        }
    }
}
