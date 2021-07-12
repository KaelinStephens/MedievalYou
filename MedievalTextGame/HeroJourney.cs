using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using System.Linq;

namespace MedievalTextGame
{
    public class HeroJourney
    {
        public static Human CreateNewHuman()   //Human class method called from Main to create a new character.
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();          //takes any input as firstName.
            Console.WriteLine();
            Console.WriteLine("What is your surname?");    //takes any input as lastName. 
            string lastName = Console.ReadLine();
            Console.WriteLine();
            int age = GetAge();            //calls GetAge method to confirm input is numbers and within the parameters of the game then returns the int age.
            Console.WriteLine();
            string gender = GetGender();   //calls GetGender method to populate gender property with a game-specific value.
            Console.WriteLine();
            string pronoun = GetPronoun(gender);  //calls GetPronoun method to set the character's pronouns based on what gender was chosen. If "other" was chosen, also prints additional messages and requests.
            string path = GetPath();           //calls GetPath method to populate path property with a game-specific value.       
            string pathMessage = GetPathMessage(path, firstName);     //calls GetPathMessage method to set the character's pathMessage based on what path was chosen.
            Console.WriteLine();
            Human player1 = new Human(firstName, lastName, age, gender, pronoun, path, pathMessage); //actually populates the properties of the character to Human class.

            return player1;
        }
        public static string GetPath()          //creates a loop requiring player to choose a provided value then returns the path to CreateNewHuman() method.
        {
            string path;
            do
            {
                Console.WriteLine("What is your destiny?");
                Console.WriteLine("Knight");
                Console.WriteLine("Thief");
                // Console.WriteLine("Druid");
                // Console.WriteLine("Mage");
                path = Console.ReadLine().ToLower();
                switch (path)
                {
                    case "knight":
                        //return path;
                        Console.WriteLine("Oops. Destiny under construction. Try choosing another. ");
                        Console.WriteLine();
                        break;
                    case "thief":
                        return path;
                    case "druid":
                        Console.WriteLine("Oops. Destiny under construction. Try choosing another. ");
                        Console.WriteLine();
                        break;
                    //     return path;
                    case "mage":
                        Console.WriteLine("Oops. Destiny under construction. Try choosing another. ");
                        Console.WriteLine();
                        break;
                    //     return path;
                    default:                                       //if invalid input is entered, message shows and loop begins again until a provided path is chosen.
                        Console.WriteLine($"*wagging my finger* Ah - ah - ah! You didn't say the magic word!");
                        Console.WriteLine($"You must choose one of the prescribed destinies.");
                        Console.WriteLine();
                        break;
                }
            } while ( path != "thief");    // && path != "druid" && path != "mage" && path != "knight");

            return path;  //just here to satisfy the return requirements for the method. This line will never get used. All returns can only come from within the do/while loop.
        }

        public static string GetPathMessage(string path, string firstName)    //creates a switch case for the pathMessage based on the path chosen. Then returns the pathMessage to CreateNewHuman() method.
        {
            string pathMessage;
            switch (path)
            {
                case "knight":
                    pathMessage =
                        $"{firstName} slaves the days away as the Great Knight Sir MacGuffin's page hoping to someday " +
                        $"become a knight. Too bad even the smallest of knives are too heavy to wield";
                    return pathMessage;
                case "thief":
                    pathMessage = $"{firstName} is 'so lazy,' according to Father Guile, 'as to forgo the God-given " +
                                  $"right of all peasants [fieldwork] to pursue a life of sin; taking what was not " +
                                  $"rightfully earned. Now if you'd be so good as to add to the collection plate...'";
                    return pathMessage;
                case "druid":
                    pathMessage = $"{firstName} drifts through the forest day after day communing with nature..." +
                                  $"Well, trying to anyway. If only there was a Grove of Druids around to teach even" +
                                  $" the basics..";
                    return pathMessage;
                case "mage":
                    pathMessage =
                        $"{firstName} spends most days ineffectually cursing people, waggling sticks in the air with " +
                        $"nary a twinkling light, and hocking cure-alls concocted from whatever herb-looking things " +
                        $"were around at the time--typically, grass, leaves, and sticks";
                    return pathMessage;
            }

            return "nothing to see here"; //just here to satisfy the return requirements for the method. This line will never get used. All returns can only come from within the do/while loop.
        }
        public static string GetGender()         //creates a loop requiring player to choose a provided value then returns the gender to CreateNewHuman() method.
        {
            string gender;
            do
            {
                Console.WriteLine("What is your gender?");
                Console.WriteLine("male");
                Console.WriteLine("female");
                Console.WriteLine("other");
                gender = Console.ReadLine().ToLower();
                switch (gender)
                {
                    case "male":
                        return gender;
                    case "female":
                        return gender;
                    case "other":
                        return gender;
                    default:                            //if invalid input is entered, message shows and loop begins again until a provided path is chosen.
                        Console.WriteLine();
                        Console.WriteLine($"{gender} is not one of the options presented. Please try again.");
                        Console.WriteLine();
                        break;
                }
            } while (gender != "male" && gender != "female" && gender != "other");      //just means if 'male', 'female', or 'other' are not the input the loop starts over.

            return gender;     //just here to satisfy the return requirements for the method. This line will never get used. All returns can only come from within the do/while loop.

        }

        public static int GetAge()           //calls IsNumber method to confirm the input is all numbers. 
        {                                   //Next creates a loop requiring player to enter a number between 1 and 75. Then returns the age to CreateNewHuman() method.
            int age = IsNumbers();   //method called to convert input to int. If non-numbers are entered, method requires new input until all numbers are entered.

            while (age < 0 || age > 75)        //if number is too high or too low, message shows and loop begins again until a provided path is chosen.
            {
                while (age > 75)            //if input is over 75, message prints, IsNumbers() method is called again and loop repeats.
                {
                    Console.WriteLine("Nice try, but no one lives over the age of 75 in the Medieval Times. Don't ask me how I know. I just do.");
                    Console.WriteLine();
                    age = IsNumbers();         //method called to convert input to int. If non-numbers are entered, method requires new input until all numbers are entered.
                }
                while (age < 0)          //if input is under 1, message prints, IsNumbers() method is called again and loop repeats.
                {
                    Console.WriteLine("Hmm...Nope. Your responding to these prompts indicates you must already be born.");
                    Console.WriteLine();
                    age = IsNumbers();        //method called to convert input to int. If non-numbers are entered, method requires new input until all numbers are entered.
                }
            }
            return age;            //returns age to CreateNewHuman() method.      
        }

        public static int IsNumbers()        // creates a loop to determine if the input for age is all numbers. If not, message prints and loop begins again to get new input. 
        {                                   // Then returns the age to GetAge() method.
            bool isNumbers;
            int age;
            do
            {
                Console.WriteLine("How old are you?");
                isNumbers = int.TryParse(Console.ReadLine(), out age);
                if (isNumbers == false)                                    //if invalid input is entered, message shows and loop begins again until a provided path is chosen.
                {
                    Console.WriteLine("*facepalm* That...that isn't a valid age. Please make it easy on me by entering your age in whole-digit format.");
                    Console.WriteLine();
                }
            } while (isNumbers == false);
            return age;        //once parameters of only numbers is met, age is converted to an int and returned to the GetAge() method.
        }

        public static string GetPronoun(string gender)   //creates a switch case for the pronoun based on the gender chosen.
        {                                               // If "other" was chosen as gender, message prints and asks for desired pronoun as input. 
            var pronoun = "they";                       // Then returns the pronoun to CreateNewHuman() method. 
            switch (gender)
            {
                case "other":
                    pronoun = OtherPronounGetter();   //calls method which gets user-input for unique pronoun.
                    return pronoun;
                case "male":
                    pronoun = "he";
                    return pronoun;
                case "female":
                    pronoun = "she";
                    return pronoun;
            }

            return pronoun;   //just here to satisfy the return requirements for the method. This line will never get used. All returns can only come from within the do/while loop.
        }

        public static string OtherPronounGetter()    //method gets and returns to GetPronoun method a unique pronoun for players with genders "other".
        {
            Console.WriteLine("*sympathetic wince* You're going to have a hard time.");
            Console.WriteLine("What pronoun would you like to use?");
            string pronoun = Console.ReadLine();
            Console.WriteLine();
            return pronoun;
        }
        public static void LetAdventureCommence(Human player1)       //the adventure starts.
        {
            Console.WriteLine();
            Console.WriteLine("****************");
            Console.WriteLine();
            Console.WriteLine("Then one day........");
            Console.WriteLine();
            Console.WriteLine(
                $"'Herbs for sale!' An old peddler calls as you walk through the village on your way {EnterPlayer1(player1)}");  //takes player1's path to output an appropriate entry scene.
            Console.WriteLine();
            Console.WriteLine($"'Herbs for sale!' He calls again. 'Herbs for sale! {player1.FirstName}, herbs?' " +
                              $"He proffers you a rather full looking cloth bag.");
            Console.WriteLine("But, wait, you've never seen this peddler before. How did he know your name?");
            Console.WriteLine();
            HeroActions.TalkToPeddlerConsequence(player1);        //calls method from HeroActions for first interaction with peddler.
        }

        public static string EnterPlayer1(Human player1)        //takes player1's path to output an appropriate entry scene.
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

            return "no path to enter from";     //just here to satisfy the return requirements for the method. This line will never get used. All returns can only come from within the switch/case.
        }

        public static void GoHome(Human player1)     //ends the game when player chooses option from HeroActions.TalkToPeddlerConsequence() which ends the adventure.
        {
            switch (player1.Path)
            {
                case "knight":
                    break;
                case "thief":
                    Console.WriteLine("You continue on your way home. Soon, you forget all about the old peddler.");
                    Console.WriteLine("Tonight, tonight you will finally unlock a door and become a real thief.");
                    Console.WriteLine();
                    Console.WriteLine("*******************************************************");
                    Console.WriteLine();
                    Console.WriteLine("THE END");
                    break;
                case "druid":
                    break;
                case "mage":
                    break;
            }
            System.Environment.Exit(0); //ends the application.
        }

        public static void ApproachPeddler(Human player1)
        {
            Console.WriteLine("'I've never met you before. How do you know my name?'");
            Console.WriteLine("'Never mind that, herbs?' He proffers the bulging bag again.");
            HeroActions.DoesPlayerAcceptBag(player1);
        }

        public static void AcceptHerbBag(Human player1)
        {
            string pronoun;
            switch (player1.Pronoun)
            {
                case "he":
                    pronoun = "sir";
                    break;
                case "she":
                    pronoun = "madam";
                    break;
                default:
                    pronoun = player1.Pronoun;
                    break;
            }
            Console.WriteLine("You take the bag.");
            Console.WriteLine($"'That will be 10 scales, my good {pronoun}.");
            Console.WriteLine("'Ten...what...?' you ask.");
            Console.WriteLine("'Scales,' he replies, 'ten scales'");
            Console.WriteLine();
            HeroActions.ReactionToPricePathGetter(player1);
        }

        public static void ComplainAboutPrice(Human player1)
        {
            Console.WriteLine("You scoff. 'Scales? That's no form of money. And, even if it was, 10 would be far too much for a simple bag of herbs.'");
            Console.WriteLine("'Ah, but scales ARE a form of currency. The kind of currency I accept. If you don't have the money you can work the debt off.'");
            Console.WriteLine();
            HeroActions.ReactionToPriceThiefAfterComplain(player1);
        }

        public static void NegotiatePrice(Human player1)
        {
            Console.WriteLine("Maybe you can get these herbs for a steal.");
            Console.WriteLine("'I don't know. Even 10 pence for a bag of herbs is too much. I'll give you...' you rummage around in your pockets. Last night's escapades " +
                              "didn't go to plan so there's not much rummage through, '...this!'");
            Console.WriteLine("You thrust your open hand toward the peddler.");
            Console.WriteLine();
            Console.WriteLine("The old man leans over and peers at your hand. 'A dead cockroach?' he asks bewildered. 'Surely, my wares are worth more than that.'");
            Console.WriteLine("For the first time, you look down at your proffered hand. 'EEEEEWYUCK!' You exclaim as you frantically fling the dead bug from your hand." +
                              " Blasted filthy prison. Blasted guards for taking you there. And blasted door for not unlocking like it was supposed to!");
            Console.WriteLine();
            Console.WriteLine("'Oooo, a live cockroach. Maybe two of them would be worth my bag of herbs.' The peddler says, fascinated.");
            Console.WriteLine("You look as where you flung the nasty thing. Sure enough, it was scuttling away.");
            Console.WriteLine("'Too bad that one already got away.' The peddler says, wistfully. 'Of course, you could always work to pay off the debt.'");
            Console.WriteLine();
            HeroActions.ReactionToPriceThiefAfterNegotiate(player1);
        }

        public static void StealTheBag(Human player1)
        {
            Console.WriteLine("'Nah.' You toss the bag back to the peddler who fumbles, but doesn't drop it. He looks at you shocked.");
            Console.WriteLine("'Wha...What? Are you sure?'");
            Console.WriteLine("'Yep.' You stroll away. Once you reach the intersection and turn the corner you dash down the next street, back towards the peddler's stall. " +
                              "Sneaking between two buildings you see the back of the stall and the bag of herbs.");
            Console.WriteLine();
            Console.WriteLine("Or, you would be sneaking if the sun wasn't shining directly behind you, the alley cats weren't yowling at you for waking them from their naps," +
                              " and you weren't mumbling to yourself about how THIS time you'll prove you're a proper thief. But those things won't deter you! In fact, you " +
                              "don't even notice them.");
            Console.WriteLine();
            Console.WriteLine("And you wonder why your theft attempts never reap rewards.");
            Console.WriteLine();
            Console.WriteLine("Crouching in the shadows--well, crouching in your own shadow--you wait for the perfect moment. But it doesn't come, so you make a dash for the stall. " +
                              "The peddler cannot stop you. You grab the bag and sprint down the lane towards home.");
            Console.WriteLine();
            Console.WriteLine("Once home, you open the bag to find.....herbs. A lot of loose herbs. " +
                              "Don't know what else you expected, I mean, the peddler did say he sold herbs and the bag was a bag of herbs.");
            Console.WriteLine();
            Console.WriteLine("'Oh, well,' you say to yourself, 'I guess I could do with a cup of tea.' And you set about brewing up a cup of your first successful heist. It was disgusting.");
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();
            Console.WriteLine("THE END");
            System.Environment.Exit(0); //ends the application.
        }

        public static void InquireAboutDebtWork(Human player1)
        {
            Console.WriteLine("You narrow your eyes at the peddler. 'What kind of work are you talking about? I don't know how much 10 scales is worth.'");
            Console.WriteLine("'It's worth the contents of that bag. As for the work, you can help pack my items to go to the next town.'");
            Console.WriteLine();
            HeroActions.ReactionToPriceThiefAfterWorkInquire(player1);
        }

        public static void WorkOffDebt(Human player1)
        {
            Console.WriteLine("You agree to help the peddler pack in exchange for the herbs.");
            Console.WriteLine("The old man smiles. 'Very well,' he cackles. He reaches into a bag tied to his belt extracting a pinch of...something...which he blows into your face!");
            Console.WriteLine();
            Console.WriteLine("You feel woozy and sit down. Once the world stops spinning you get back up and declare, 'What's the big idea?!'");
            Console.WriteLine("'Now, now,' the peddler soothes, 'steady there.'");
            Console.WriteLine("He pats you on your neck. You feel much calmer. He pulls a halter from his bag and puts it on you. Then as you stand there, he begins loading his goods " +
                              "onto your back. Occasionally he loads something extra to one side making the load unbalanced, but he notices you pawing at the ground and readjusts the load.");
            Console.WriteLine();
            Console.WriteLine("When he finishes packing up he takes up the lead rope. 'Ok,' he quietly calls, 'giddup.' And he leads you out of town.");
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();
            Console.WriteLine("THE END");
            System.Environment.Exit(0); //ends the application.
        }
    }
}
