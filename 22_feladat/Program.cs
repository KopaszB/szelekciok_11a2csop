using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*egy tetszőleges számról mondjuk meg, hogy osztható-e maradék nélkül 3-mal!*/
            Console.Write("Adj meg egy számot: ");
            int szam = int.Parse(Console.ReadLine());

            Console.WriteLine(szam%3==0?"Osztható hárommal":"Nem osztható hárommal");

            Console.ReadKey();
        }
    }
}
