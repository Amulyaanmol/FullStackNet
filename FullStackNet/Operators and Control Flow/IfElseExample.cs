
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackNet.Operators_and_Control_Flow
{
    public class IfElseExample
    {
        public static void IfElseStatement()
        {
            double radius; // Declare a variable to store the radius.
            double area; // Declare a variable to store the area.
            Console.Write("Enter the radius of the circle: ");
            // double.Parse converts the ReadLine()
            // return to a double.
            radius = double.Parse(Console.ReadLine());
            if (radius >= 0)
            {
                // Calculate the area of the circle.
                area = Math.PI * radius * radius;
                Console.WriteLine(
                $"The area of the circle is: { area:0.00}");
            }
            else
            {
                Console.WriteLine(
                $"{ radius } is not a valid radius.");
            }
        }
    }
    
}
