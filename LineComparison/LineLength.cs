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
            Console.WriteLine("Enter a Co-ordinate for line1");
            Console.WriteLine("Enter X Co-ordinate...! ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Y Co-ordinate...! ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());


            double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Line1 Distance..:- "+ length);

            Console.WriteLine("Enter a Co-ordinate for line1");
            Console.WriteLine("Enter X Co-ordinate...! ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Y Co-ordinate...! ");
            int b1 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());

            double lengt = Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2));
            Console.WriteLine("Line2 distance..:- "+ lengt);

            if (length == lengt)
            {
                Console.WriteLine("Line1 distance equal Line2");
            }

        }
    }
}
