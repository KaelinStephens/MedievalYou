using System;
using System.Collections.Generic;
using System.Text;

namespace MedievalTextGame
{
    public class RaceCreator
    {
        public static Human GetRace()
        {
            Console.WriteLine("Welcome to MEDIEVAL YOU");       //intro title for the game.
            Console.WriteLine();
            Console.WriteLine("********************************************");
            Console.WriteLine();
            string race;
            do                                     //do/while loop prompts player to choose a character race.
            {
                Console.WriteLine("What race are you? \n" +
                                  "Human \n" +
                                  "Elf \n" +
                                  "Goblin");
                race = Console.ReadLine().ToLower();
                if (race == "human")
                {
                    Console.WriteLine();
                }

                else if (race == "elf") //elves are not yet available in the game.
                {
                    Console.WriteLine($"Hahahahahaha! Silly, there are no such things as Elves. You are a human.");
                    Console.WriteLine();
                }
                else if (race == "goblin") //goblins are not yet available in the game.
                {
                    Console.WriteLine($"Hahahahahaha! Silly, there are no such things as {race}s. You are a human.");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(
                        $"Naughty, naughty...{race} was not one of the options shown."); //shows this message then restarts the loop until player chooses one of the designated races.
                    Console.WriteLine();
                }
            } while (race != "human" && race != "elf" && race != "goblin");         //ensures player input is valid for this application.

            return HeroJourney.CreateNewHuman(); //calls method that will populate all Human properties.
        }
    }
}