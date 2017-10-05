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

            int hinta = 16;
            // int mtk = 15;
            int ale50 = 2;
            // int opiskelija = 45;


            Console.WriteLine("Syötä asiakkaan ikä : ");
            string userInput = Console.ReadLine();
            //int.TryParse(userInput, out int number);
            int ika = int.Parse(userInput);
            // int i = 0;
            // int f = 1;
 
            if (ika < 7)
            {
                Console.WriteLine($"Lipun hinta on : {hinta * 0} euroa ");
            }
            else if
            {
                Console.WriteLine("Oletko Opiskelija ? (k/e)");
                bool opiskelija = Console.ReadLine();
                if (opiskelija == k)
                    {
                    int oale = 2;
                    int alehinta = hinta / oale;
                    Console.WriteLine($"Lipun hinta on = {alehinta} euroa")
                    }
                else
                {
                    int alehinta = hinta;
                    Console.WriteLine($"Lipun hinta on = {alehinta} euroa")
                }


            }
            else if (ika <= 15)
            {
                int alehinta = hinta / ale50;

                Console.WriteLine($"Lipun hinta on = {alehinta} euroa");
                
            }
            else if (ika >=65)
            {
                Console.WriteLine($"Lipun hinta on = {alehinta} euroa");
            }
            else
            {
                Console.WriteLine($"ikaale = 0");
            }
            // Console.WriteLine($"ikäalennus {ikaale}");

            Console.ReadKey();
        }
    }
}
