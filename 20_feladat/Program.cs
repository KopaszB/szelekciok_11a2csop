using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* bekér egy számot és kiírja, hogy páros vagy páratlan*/

            Console.Write("Kérek egy számot: ");
            int szam = int.Parse(Console.ReadLine());

            if (szam % 2 == 0)
            {
                Console.WriteLine($"A(z) {szam} páros");
            }
            else
            {
                Console.WriteLine($"A(z) {szam} páratlan");
            }

            Console.WriteLine(szam % 2 == 0?"Páros":"Páratlan") ; //3-as operandusú feltétel

            Console.ReadKey();
        }
    }
}
