using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*bekér a felhasználótól egy számot, majd kiírja az adott számról, hogy páros, páratlan, vagy
nulla.
*/
            Console.Write("Kérek egy számot: ");
            int szam = int.Parse(Console.ReadLine());

            if (szam==0)
            {
                Console.WriteLine("A szám nulla");
            }
            else if (szam % 2 == 0)
            {
                Console.WriteLine($"A(z) {szam} páros");
            }
            else
            {
                Console.WriteLine($"A(z) {szam} páratlan");
            }

            Console.ReadKey();
        }
    }
}
