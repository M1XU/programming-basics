using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //int f = 1;
            //do
            //{
            //    Console.WriteLine($"I {i}");
            //    i = i + 1;
            //    Console.WriteLine($"I {i}");
            //    // sama kuin yllä i+;
            //    Console.WriteLine($"F {f}");
            //    f = f * i;
            //    Console.WriteLine($"F {f}");
            //    // sama kuin yllä f *=i
            //    Console.WriteLine($"{i}!={f}");

            //} while (i < 5);

            int i = 0;
            int f = 1;
            Console.WriteLine("Ohjelma laskee kertoman syötämällesi numerolle:");
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("Virheellinen syöte !!!");
            }
            // tai return;  lopettaa suoraan
            else
            {
                // for(i=1;i<=number;i++)
                while (i < number)
                {
                    i = i + 1; //jos käytetään for lausetta niin tätä riviä ei tarvita
                    f = f * i;
                    Console.WriteLine($"Syötit: {number}\n Vastaus: {f}"); //5!=120
                }
            } 




            Console.ReadKey();
        }
    }
}
