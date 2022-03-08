
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackNet.DataTypes
{
    public class AnonymousTypes
    {
        public static void UnkownType()
        {
           var patent1 =
           new
           {
               Title = "Bifocals",
               YearOfPublication = "1784"
           };
            var patent2 =
           new
           {
               Title = "Phonograph",
               YearOfPublication = "1877"
           };
            System.Console.WriteLine(
           $"{ patent1.Title } ({ patent1.YearOfPublication })");
            System.Console.WriteLine(
           $"{ patent2.Title } ({ patent2.YearOfPublication })");
        }
    }
}
