using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ertekeles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adj meg egy pontszámot(0-100): ");
            byte pont = byte.Parse(Console.ReadLine());

            switch (pont)
            {
                case byte x when x>=0 && x<=39:
                    Console.WriteLine("Jegy: 1");
                    break;
                case byte x when x >= 40 && x <= 54:
                    Console.WriteLine("Jegy: 2");
                    break;
                case byte x when x >= 55 && x <= 69:
                    Console.WriteLine("Jegy: 3");
                    break;
                case byte x when x >= 70 && x <= 84:
                    Console.WriteLine("Jegy: 4");
                    break;
                case byte x when x >= 85 && x <= 100:
                    Console.WriteLine("Jegy: 5");
                    break;


                default:
                    Console.WriteLine("Nincs ilyen pontszám!");
                    break;   
            }
            Console.ReadKey();
        }
    }
}
