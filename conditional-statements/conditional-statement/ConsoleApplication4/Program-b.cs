using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditional_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            // define instructions
            Console.WriteLine("Ohjelma järjestää kolme syöttämääsi lukua suuruus järjestykseen");

            // define variables
            Console.Write("Syötä 1. luku: ");
            string Eka = Console.ReadLine();
            int numx = int.Parse(Eka);

            Console.Write("Syötä 2. luku: ");
            string Toka = Console.ReadLine();
            int numy = int.Parse(Toka);

            Console.Write("Syötä 3. luku: ");
            string Kolmas = Console.ReadLine();
            int numz = int.Parse(Kolmas);


            // program logic

            if (numx < numy)
            {
                if (numx < numz)
                {
                    if (numy < numz)
                    {
                        Console.WriteLine($"Järjestys on : {numx} , {numy} , {numz}");
                    }
                    else
                    {
                        Console.WriteLine($"Järjestys on : {numx} , {numz} , {numy}");
                    }
                }
                else
                {
                    Console.WriteLine($"Järjestys on : {numz} , {numx} , {numy}");
                }
            }
            else
            {
                if (numx < numz)
                {
                    Console.WriteLine($"Järjestys on : {numy} , {numx} , {numz}");
                }

                else
                {
                    if (numy < numz)
                    {
                        Console.WriteLine($"Järjestys on : {numy} , {numz} , {numx}");
                    }
                    else
                    {
                        Console.WriteLine($"Järjestys on : {numz} , {numy} , {numx}");
                    }

                    Console.ReadKey();
                }
                
            }
        }
    }
}

            
    


            


