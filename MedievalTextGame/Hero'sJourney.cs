using System;
using System.Collections.Generic;
using System.Text;

namespace MedievalTextGame
{
    public class HeroJourney : IHeroActions
    {
        public static void LetAdventureCommence(Human player1)
        {
            var enterPlayer1 = EnterPlayer1(player1);  //takes player1's path to output an appropriate entry scene.
            Console.WriteLine(
                $"'Herbs for sale!' An old peddler calls as you walk through the village on your way {enterPlayer1}");
        }

        public static string EnterPlayer1(Human player1)
        {
            switch (player1.Path)
            {
                case "knight":
                    return "knight";
                case "thief":
                    return "home after yet another humiliating night spent in the tanty. For 'disturbing the peace'. " +
                           "DISTURBING THE PEACE! You're a thief, not a ruckus hooligan! You should have been imprisoned " +
                           "for stealing...Well...attempting to steal at least. It's not your fault the stupid door " +
                           "wouldn't open and the owner woke up. I mean, who wouldn't try the old 'technical tap' when " +
                           "the lock picks didn't work?";
                case "druid":
                    return "druid";
                case "mage":
                    return "mage";
            }

            return "no path to enter from";
        }

        //  peddler calls out
        //  player going somewhere
        // peddler calls player's name
        // FIRST CHOICE does player talk to peddler
        // if no, game ends
        // if yes, player talks to peddler
        // SECOND CHOICE does player take herb bag
        // if no, give choice to talk more or leave
        //     if leave, game ends
        //     if talk more, player talks more with the peddler then repeats second choice
        // if yes, player takes bag and peddler asks for payment
        // THIRD CHOICE what does player do about payment? (path specific)
        // player has bag and leaves peddler stall
        // FOURTH CHOICE does player go on quest?
        // if no, consequences occur until a choice can be made (path specific)
        // if yes, travel until RANDOM ENCOUNTER 
        // FIFTH CHOICE what does player do about encounter? (path, gender specific)
        // consequences of choice happen
        // player meets a mentor (path specific)
        // SIXTH CHOICE what does player do? (path specific)
        // player (and mentor) continue on quest 
        // travel until RANDOM ENCOUNTER
        // consequences of encounter (path, gender, and previous choice specific)
        // player attempts to complete quest
        // consequences of attempt (path and previous choice specific)
        // if successful, player travels to meet up with peddler
        // SEVENTH CHOICE does player travel to repay peddler?
        // if no, consequences occur until a choice can be made (path specific)
        // if yes, player travels to peddler
        // player finds peddler 
        // EIGHTH CHOICE what does player do once they meet the peddler again? (path and previous choice specific)
        // one of four endings (path specific)
        //     1. worked hard, trained hard, reward is continues on to glory
        //     2. did some, through struggle player gets nicer life
        //     3. did little, returns to life not having learned anything or grown as a character
        //     4. did not complete quest, peddler grabs a handful of herbs and blows them into player's face. 
        //        player becomes a mule to carry the peddler's wares as debt repayment
        // THE END
    }
}
