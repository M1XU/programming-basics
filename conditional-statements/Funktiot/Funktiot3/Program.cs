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
            // program logic
            Console.WriteLine(reqNumbers(10));
            Console.ReadKey();
        }
        static int reqNumbers(int n)
        {
            Console.WriteLine($"Syötä {n} lukua : ");
            string res = string.Empty;
            int max = 0;
            int jarjestys = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i}. ");
                int a = int.Parse(Console.ReadLine());
                if (a < 0)
                {
                    Console.WriteLine($"Luku {a} ei ole sallittu luku");
                    i--;
                }
                else
                {
//                    Console.WriteLine($"{i}. {a}");
                    res += $"{a} ,";
                }

                if (a > max) max = a;
                if (a == max) jarjestys = i;  
                
            }
            Console.WriteLine(res);
            Console.WriteLine($"Suurin luku on {max}, ja se oli {jarjestys}. syöttämäsi luku.");
            return max;
        }
    }
}