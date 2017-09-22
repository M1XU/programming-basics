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
            Console.WriteLine("Ohjelma kertoo onko luku positiivinen, negatiivinen tai nolla, sekä kertoo onko luku parillinen vai pariton !");
            bool isNumber;
            {
                Console.Write("Syötä luku: ");
                // define variables 
                string userInput;
                userInput = Console.ReadLine();

                int evaluatedNumber;
                isNumber = int.TryParse(userInput, out evaluatedNumber);

                //check isNumber
                if(!isNumber)
                {
                    Console.WriteLine("Syötit jotain muuta kuin numeroita !");
                    Console.ReadKey();
                    return;
                }


                // program logic
                if (evaluatedNumber < 0)
                {
                    Console.Write($"Numero {evaluatedNumber} on negatiivinen");
                }
                else if (evaluatedNumber > 0)
                {
                    Console.Write($"Numero {evaluatedNumber} on positiivinen");
                }
                else
                {
                    Console.Write($"Numero {evaluatedNumber} on nolla");
                }

                if (evaluatedNumber % 2 == 0)
                {
                    Console.WriteLine(" ja se on parillinen");
                }
                else
                {
                    Console.WriteLine(" ja se on pariton");
                }
            }
            Console.ReadKey();
        }
    }
}
