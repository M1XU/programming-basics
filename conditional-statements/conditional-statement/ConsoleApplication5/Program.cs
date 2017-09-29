using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
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
            {
                if (numx < numy)
                {
                    if (numx < numz)
                    {
                        if (numy < numz)
                        {
                            Console.WriteLine($"{numx} , {numy} , {numz}");
                        }
                        else
                        {
                            Console.WriteLine($"{numx} , {numz} , {numy}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{numz} , {numx} , {numy}");
                    }
                }
                else
                {
                    if (numx < numz)
                    {
                        if (numy < numz)
                        {
                            Console.WriteLine($"{numy} , {numz} , {numx}");
                        }
                        else
                        {
                            Console.WriteLine($"{numz} , {numy} , {numx}");
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
