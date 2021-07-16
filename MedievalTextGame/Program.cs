using System;
using System.Collections.Generic;
using System.Linq;
namespace MedievalTextGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var player1 = RaceCreator.GetRace(); //creates new character
            HeroJourney.LetAdventureCommence(player1);
        }   

       
    }
}
