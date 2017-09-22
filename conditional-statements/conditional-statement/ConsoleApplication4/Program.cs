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
            bool isNumber;
            do
            {
                // define variables
                Console.Write("Syötä 1. luku: ");                 
                string userInputEka;
                userInput = Console.ReadLine();
                Console.Write("Syötä 2. luku: ");
                string userInputToka;
                userInput = Console.ReadLine();
                Console.Write("Syötä 3. luku: ");
                string userInputKolmas;
                userInput = Console.ReadLine();


                // program logic
                {
                    if (userInputEka < userInputToka)
                    {
                        if (userInputEka < userInputKolmas)
                        {
                            if (userInputToka < userInputKolmas)
                            {
                                Console.WriteLine($"{userInputEka} , {userInputToka} , {userInputKolmas}");
                            }
                            else
                            {
                                Console.WriteLine($"{userInputEka} , {userInputKolmas} , {userInputToka}");
                            }
                        else
                        {
                            Console.WriteLine($"{userInputKolmas} , {userInputEka} , {userInputToka}");
                        }
                    else
                    {
                    if (userInputEka < userInputKolmas)
                    {
                        Console.WriteLine($"{userInputToka} , {userInputEka} , {userInputKolmas}");
                    }
                    else if(userInputToka < userInputKolmas)
                    {
                        Console.WriteLine($"{userInputToka} , {userInputKolmas} , {userInputEka}");
                    }
                    else
                    {
                        Console.WriteLine($"{userInputKolmas} , {userInputToka} , {userInputEka}");
                    }

