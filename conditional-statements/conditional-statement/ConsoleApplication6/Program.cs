using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Perustiedot
            // -Kysytään asiakkaan tiedot
            // - Lasketaan alennus
            // - Ilmoitetaan lipun hinta

            // Ehdot Vain yksi alennus myönnetään. Paitsi jos on opiskelija sekä Mtk:n jäsen, hän saa molemmat alennukset

            // - Normaalihinta 16 e
            // - Alle 7 v.ilmaiseksi
            // - 65 v.ja yli: 50 % alennus
            // - 7 - 15 v. : 50 % alennus
            // - Mtk jäsen : 15 % alennus
            // - Varusmies: 50 % alennus
            // - Opiskelija: 45 % alennus

            // define variables

            Console.Write("Onko asiakas alle 7 vuotta? (K/E)");
            string alle7 = Console.ReadLine();
            if (alle7 = "K")
            {
                Console.WriteLine($"Lipun hinta 0 €");
            }
            Console.ReadKey();

        }
    }
}
