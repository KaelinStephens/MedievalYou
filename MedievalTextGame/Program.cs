using System;
using System.Collections.Generic;
using System.Linq;
namespace MedievalTextGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MEDIEVAL YOU");
            Console.WriteLine();
            Human player1 = GetRace(); //creates new character
            //HeroJourney.LetAdventureCommence(player1); //the adventure starts


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
                    Human player1 = new Human(Human.CreateNewHuman()); //calls method that will populate all Human properties.
                    return player1;
                }
                else if (race == "elf") //elves are not yet available in the game.
                {
                    Console.WriteLine($"Hahahahahaha! Silly, there are no such things as Elves. You are a human.");
                    Console.WriteLine();
                    Human player1 = new Human(Human.CreateNewHuman()); //calls Human class method that will populate all Human properties.
                    return player1;
                }
                else if (race == "goblin") //goblins are not yet available in the game.
                {
                    Console.WriteLine($"Hahahahahaha! Silly, there are no such things as {race}s. You are a human.");
                    Console.WriteLine();
                    Human player1 = new Human(Human.CreateNewHuman()); //calls Human class method that will populate all Human properties.
                    return player1;
                }
                else
                {
                    Console.WriteLine($"Naughty, naughty...{race} was not one of the options shown."); //shows this message then restarts the loop until player chooses one of the designated races.
                    Console.WriteLine();
                }
            } while (race != "human" && race != "elf" && race != "goblin");
            Human player2 = new Human(); //just here to satisfy the return requirements for the method. These two lines will never get used. All returns can only come from within the do/while loop.
            return player2;
        }
    }
}
