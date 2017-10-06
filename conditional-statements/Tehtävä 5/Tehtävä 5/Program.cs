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
            Console.OutputEncoding = System.Text.Encoding.UTF8;
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
            // float mtk = 15;
            int ale50 = 50;
            // int oale = 45;
            bool alennus = false


            Console.WriteLine("Syötä asiakkaan ikä : ");
            int ika = int.Parse(Console.ReadLine());
            //int.TryParse(userInput, out int number);

            // int i = 0;
            // int f = 1;
 
            if (ika < 7)
            {
                Console.WriteLine($"Lipun hinta on : {hinta * 0} euroa ");
            }
            else if
            {
                Console.WriteLine("Oletko Opiskelija ? (k/e)");
                string opiskelija = Console.ReadLine().ToUpper();
                Console.WriteLine("Oletko MTK:n jäsen ? (k/e)");
                string mtk = Console.ReadLine()ToUpper();

                if (opiskelija == "K" && )
                    {
                    int oale = 2;
                    int alehinta = hinta / oale;
                    Console.WriteLine($"Lipun hinta on = {alehinta} euroa")
                    if (mtk == K)
                        }
                else
                {
                    int alehinta = hinta;
                    Console.WriteLine($"Lipun hinta on = {alehinta} euroa")
                }
                if (ika  >=7 && ika <=15 && alennus == false)
                {
                    int ale = 50;
                    alennus = true;

                    Console.WriteLine($"Lipun hinta on : {hinta * 0} euroa ");
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
            if (MTK =="K" && alennus == false)
            {
                ale = 15;
                alennus = true;
            }
            decimal = totalPrice = (price - (price * Convert.ToDecimal(discount / 100m)));
            // Console.WriteLine($"ikäalennus {ikaale}");

            Console.ReadKey();
        }
    }
}
