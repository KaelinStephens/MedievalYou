using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Linq;
using System.Runtime.CompilerServices;

namespace MedievalTextGame
{
    public class HeroActions
    {
        public static void TalkToPeddlerConsequence(Human player1)
        {
            char talkToPeddler;
            do
            {
                Console.WriteLine("Do you stop to ask? y/n");
                talkToPeddler = Console.ReadKey().KeyChar; 
                Console.WriteLine();

            } while (talkToPeddler != 'y' && talkToPeddler != 'n');

            if (talkToPeddler == 'n')
            {
                HeroJourney.GoHome(player1);
            }
            else
            {
                HeroJourney.ApproachPeddler(player1);
            }
        }

        public static void DoesPlayerAcceptBag(Human player1)
        {
            char doesPlayerAcceptBag;
            do
            {
                Console.WriteLine("Do you accept the bag? y/n");
                doesPlayerAcceptBag = Console.ReadKey().KeyChar;
                Console.WriteLine();

            } while (doesPlayerAcceptBag != 'y' && doesPlayerAcceptBag != 'n');

            if (doesPlayerAcceptBag == 'n')
            {
                Console.WriteLine("'No thanks.'");
                HeroJourney.GoHome(player1);
            }
            else
            {
                HeroJourney.AcceptHerbBag(player1);
            }
        }

        public static void ReactionToPricePathGetter(Human player1)
        {
            switch (player1.Path)
            {
                case "knight":
                    ReactionToPriceKnight(player1);
                    break;
                case "thief":
                    ReactionToPriceThief(player1);
                    break;
                case "druid":
                    ReactionToPriceDruid(player1);
                    break;
                case "mage":
                    ReactionToPriceMage(player1);
                    break;
            }
        }

        public static void ReactionToPriceKnight(Human player1)
        {
            Console.WriteLine("What do you do?");
        }
        public static void ReactionToPriceThief(Human player1)
        {
            char choice;
            do
            {
                Console.WriteLine("What do you do?");
                Console.WriteLine("A: Complain");
                Console.WriteLine("B: Negotiate");
                Console.WriteLine("C: Steal the bag");
                Console.WriteLine("D: You don't want the herbs");
                Console.WriteLine();
                choice = Console.ReadKey().KeyChar;
                switch (choice)
                {
                    case 'a':
                        HeroJourney.ComplainAboutPrice(player1);
                        break;
                    case 'b':
                        HeroJourney.NegotiatePrice(player1);
                        break;
                    case 'c':
                        HeroJourney.StealTheBag(player1);
                        break;
                    case 'd':
                        Console.WriteLine("'Ten anything would be too much for herbs.' you say as you toss the bag back to the peddler.");
                        HeroJourney.GoHome(player1);
                        break;
                    default:
                        Console.WriteLine("Seriously? Just choose one of the options shown.");
                        break;
                }
            } while (choice != 'a' && choice != 'b' && choice != 'c' && choice != 'd');
        }
        public static void ReactionToPriceThiefAfterComplain(Human player1)
        {
            char choice;
            do
            {
                Console.WriteLine("What do you do?");
                Console.WriteLine("A: Inquire about work");
                Console.WriteLine("B: Negotiate");
                Console.WriteLine("C: Steal the bag");
                Console.WriteLine("D: You don't want the herbs");
                Console.WriteLine();
                choice = Console.ReadKey().KeyChar;
                switch (choice)
                {
                    case 'a':
                        HeroJourney.InquireAboutDebtWork(player1);
                        break;
                    case 'b':
                        HeroJourney.NegotiatePrice(player1);
                        break;
                    case 'c':
                        HeroJourney.StealTheBag(player1);
                        break;
                    case 'd':
                        Console.WriteLine("'Ten anything would be too much for herbs.' you say as you toss the bag back to the peddler.");
                        HeroJourney.GoHome(player1);
                        break;
                    default:
                        Console.WriteLine("Seriously? Just choose one of the options shown.");
                        break;
                }
            } while (choice != 'a' && choice != 'b' && choice != 'c' && choice != 'd');
        }
        public static void ReactionToPriceThiefAfterNegotiate(Human player1)
        {
            char choice;
            do
            {
                Console.WriteLine("What do you do?");
                Console.WriteLine("A: Complain");
                Console.WriteLine("B: Inquire about work");
                Console.WriteLine("C: Steal the bag");
                Console.WriteLine("D: You don't want the herbs");
                Console.WriteLine();
                choice = Console.ReadKey().KeyChar;
                switch (choice)
                {
                    case 'a':
                        HeroJourney.ComplainAboutPrice(player1);
                        break;
                    case 'b':
                        HeroJourney.InquireAboutDebtWork(player1);
                        break;
                    case 'c':
                        HeroJourney.StealTheBag(player1);
                        break;
                    case 'd':
                        Console.WriteLine("'Ten anything would be too much for herbs.' you say as you toss the bag back to the peddler.");
                        HeroJourney.GoHome(player1);
                        break;
                    default:
                        Console.WriteLine("Seriously? Just choose one of the options shown.");
                        break;
                }
            } while (choice != 'a' && choice != 'b' && choice != 'c' && choice != 'd');
        }
        public static void ReactionToPriceThiefAfterWorkInquire(Human player1)
        {
            char choice;
            do
            {
                Console.WriteLine("What do you do?");
                Console.WriteLine("A: Complain");
                Console.WriteLine("B: Negotiate");
                Console.WriteLine("C: Steal the bag");
                Console.WriteLine("D: You don't want the herbs");
                Console.WriteLine("E: Agree to work off debt");
                Console.WriteLine();
                choice = Console.ReadKey().KeyChar;
                switch (choice)
                {
                    case 'a':
                        HeroJourney.ComplainAboutPrice(player1);
                        break;
                    case 'b':
                        HeroJourney.InquireAboutDebtWork(player1);
                        break;
                    case 'c':
                        HeroJourney.StealTheBag(player1);
                        break;
                    case 'd':
                        Console.WriteLine("'Ten anything would be too much for herbs.' you say as you toss the bag back to the peddler.");
                        HeroJourney.GoHome(player1);
                        break;
                    case 'e':
                        HeroJourney.WorkOffDebt(player1);
                        break;
                    default:
                        Console.WriteLine("Seriously? Just choose one of the options shown.");
                        break;
                }
            } while (choice != 'a' && choice != 'b' && choice != 'c' && choice != 'd' && choice != 'e');
        }
        public static void ReactionToPriceDruid(Human player1)
        {

        }
        public static void ReactionToPriceMage(Human player1)
        {

        }

    }
}
