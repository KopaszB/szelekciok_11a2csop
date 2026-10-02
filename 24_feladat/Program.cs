using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Olvassa be egy hónap számát, majd írja ki, hogy melyik évszakban van az adott hónap.*/
            Console.Write("Adj meg a hónap számát(1-12): ");
            byte honap = byte.Parse(Console.ReadLine());

            switch (honap)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Tél");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Tavasz");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Nyár");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Ősz");
                    break;

                default:
                    Console.WriteLine("Nincs ilyen hónap!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
