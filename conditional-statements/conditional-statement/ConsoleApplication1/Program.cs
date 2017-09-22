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
            Console.WriteLine("Ohjelma kertoo onko luku parillinen vai pariton");
            bool isNumber;
            do
            {

                Console.Write("Syötä luku: ");
                // define variables 
                string userInput;
                userInput = Console.ReadLine();

                int evaluatedNumber;
                isNumber = int.TryParse(userInput, out evaluatedNumber);

                // program logic
                if (isNumber == true)
                {
                    if (evaluatedNumber % 2 == 0)
                    {
                        Console.WriteLine($"Numero {evaluatedNumber} on parillinen");
                    }
                    else
                    {
                        Console.WriteLine($"Numero {evaluatedNumber} on pariton");
                    }
                }
                else
                {
                    Console.WriteLine("Syötit jotain muuta kuin numeroita !");


                }

            } while (isNumber == false);

            Console.ReadKey();

        }
    }
}
