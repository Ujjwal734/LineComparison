using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public class LineLength
    {
        public void CalcuLength()
        {
            Console.WriteLine("Enter X co-ordinate ");
            int x1, x2;
            x1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a y co-oordinate");
            int y1, y2;
            y1 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Line Length " + length);
        }
    }
}
