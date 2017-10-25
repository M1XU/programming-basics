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
            int a;
            int b;
            // int m;
            // while (true)
            //{
                Console.WriteLine("Anna kaksi lukua ja ohjelma palauttaa sinulle luvuista pienemmän");
                Console.Write("Anna ensimmäinen luku: ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Anna toinen luku: ");
                b = int.Parse(Console.ReadLine());
                // if (n < 0)
                // {
                //     Console.WriteLine("Luku {0} ei ole sallittuluku", n);
                // }
                // else
                // {
                //     break;
                // }
            //}
            string res = getMinimum(a,b);
            Console.WriteLine(res);
            Console.ReadKey();

            int resb = getMinimumInt(a, b);
            Console.WriteLine(resb);
            Console.ReadKey();
        }
            static string getMinimum(int x, int y)
            {
                string res = string.Empty;
                if (x < y)
                    res = x.ToString();
                else
                    res = y.ToString();
                return res;
            }
        static int getMinimumInt(int x, int y)
        {
            return x < y ? x : y;
            //if (x < y)
            //    return x;
            //else                
            //    return y;
        }
    }
}








