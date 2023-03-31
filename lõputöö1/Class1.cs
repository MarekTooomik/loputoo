using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbritePyramid
{
    public class Class1
    {
        public void NumbritePyramid()
        {
            int n, i, j, num = 1;
            Console.WriteLine("Numbrite pyramiid! Sisestage mittu rida tahate: ");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write("  ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("{0,-3}", num++);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
