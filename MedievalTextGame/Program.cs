using System;
using System.Collections.Generic;
namespace MedievalTextGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MEDIEVAL YOU");
            Console.WriteLine();
            Human player1 = GetRace();



        }

        public static Human GetRace()
        {
            string race;
            do
            {
                Console.WriteLine("What race are you? \n" +
                                  "Human \n" +
                                  "Elf \n" +
                                  "Goblin");
                race = Console.ReadLine().ToLower();
                Console.WriteLine();
                if (race == "human")
                {
                    Human player1 = new Human(Human.CreateNewHuman());
                    return player1;
                }
                else if (race == "elf")
                {
                    Console.WriteLine($"Hahahahahaha! Silly, there are no such things as Elves. You are a human.");
                    Console.WriteLine();
                    Human player1 = new Human(Human.CreateNewHuman());
                    return player1;
                }
                else if (race == "goblin")
                {
                    Console.WriteLine($"Hahahahahaha! Silly, there are no such things as {race}s. You are a human.");
                    Console.WriteLine();
                    Human player1 = new Human(Human.CreateNewHuman());
                    return player1;
                }
                else
                {
                    Console.WriteLine($"Naughty, naughty...{race} was not one of the options shown.");
                    Console.WriteLine();
                }
            } while (race != "human" && race != "elf" && race != "goblin");
            Human player2 = new Human();
            return player2;
        }
    }
}
