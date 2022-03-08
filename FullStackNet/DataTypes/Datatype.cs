using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackNet.DataTypes
{
    public class Datatype
    {
        public static void TypeList()
        {
            Console.WriteLine("VALUE TYPE:");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("INTEGERS:");
            byte a = 12;
            Console.WriteLine("byte\tA = {0}\t{1}\t{2}\t{3}", a, typeof(byte), byte.MaxValue, byte.MinValue);
            sbyte b = 12;
            Console.WriteLine("sbyte\tB = {0}\t{1}\t{2}\t{3}", b, typeof(sbyte), sbyte.MaxValue, sbyte.MinValue);
            short c = 12;
            Console.WriteLine("short\tC = {0}\t{1}\t{2}\t{3}", c, typeof(short), short.MaxValue, short.MinValue);
            ushort d = 12;
            Console.WriteLine("ushort\tD = {0}\t{1}\t{2}\t{3}", d, typeof(ushort), ushort.MaxValue, ushort.MinValue);
            int e = 12;
            Console.WriteLine("int\tE = {0}\t{1}\t{2}\t{3}", e, typeof(int), int.MaxValue, int.MinValue);
            uint f = 12;
            Console.WriteLine("unit\tF = {0}\t{1}\t{2}\t{3}", f, typeof(uint), uint.MaxValue, uint.MinValue);
            long g = 12;
            Console.WriteLine("long\tG = {0}\t{1}\t{2}\t{3}", g, typeof(long), long.MaxValue, long.MinValue);
            ulong h = 12;
            Console.WriteLine("ulong\tH = {0}\t{1}\t{2}\t{3}", h, typeof(ulong), ulong.MaxValue, ulong.MinValue);

            Console.WriteLine("\nFLOATING POINT:");
            Console.WriteLine("---------------------------------------------");
            float i = 123.34f;
            Console.WriteLine("float\ti = {0}\t{1}\t{2}\t{3}", i, typeof(float), float.MaxValue, float.MinValue);
            double j = 123.34;
            Console.WriteLine("double\tj = {0}\t{1}\t{2}\t{3}", j, typeof(double), double.MaxValue, double.MinValue);
            decimal k = 123.34m;
            Console.WriteLine("decimal\tk = {0}\t{1}\t{2}\t{3}", k, typeof(decimal), decimal.MaxValue, decimal.MinValue);

            Console.WriteLine("\nTEXT:");
            Console.WriteLine("---------------------------------------------");
            char l = 'f';
            Console.WriteLine("char\tl = {0}\t{1}", l, typeof(char));

            Console.WriteLine("\nBOOLEAN:");
            Console.WriteLine("---------------------------------------------");
            bool m = true;
            Console.WriteLine("bool\tm = {0}\t{1}", m, typeof(bool));

            Console.WriteLine("\nREFERENCE TYPE:");
            Console.WriteLine("---------------------------------------------");
            string n = "Hello";
            Console.WriteLine("string\tn = {0}\t{1}", n, typeof(string));
            object o = 12.34;
            Console.WriteLine("object\to = {0}\t{1}", o, typeof(object));

            int[] q = { 12, 45, 56 };
            Console.WriteLine("int[]\tq = {0}", q, typeof(int[]));

            Console.WriteLine("\nNULLABLE TYPE:");
            Console.WriteLine("---------------------------------------------");
            string r = null;
            Console.WriteLine("string\tr = {0}\t{1}", r, typeof(string));
            int? s = null;
            Console.WriteLine("int\ts = {0}\t{1}", s, typeof(int?));
        }
    }
}
