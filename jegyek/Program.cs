using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jegyek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adj meg egy jegyet(1-5): ");
            byte jegy = byte.Parse(Console.ReadLine());

            switch (jegy)
            {
                case 1:
                    Console.WriteLine("Elégtelen eredmény.");
                    break;
                case 2:
                    Console.WriteLine("Elégséges eredmény.");
                    break;
                case 3:
                    Console.WriteLine("Közepes eredmény.");
                    break;
                case 4:
                    Console.WriteLine("Jó eredmény.");
                    break;
                case 5:
                    Console.WriteLine("Kitűnő eredmény.");
                    break;

                default:
                    Console.WriteLine("Nincs ilyen jegy!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
