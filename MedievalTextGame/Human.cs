using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MedievalTextGame
{
    public class Human
    {
        private Human human;

        public Human(Human human)
        {
            this.human = human;
        }

        public Human()
        {

        }

        public Human(string firstName, string lastName, int age, string gender, string pronoun, string path, string pathMessage)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
            Pronoun = pronoun;
            Path = path;
            PathMessage = pathMessage;
            Console.WriteLine($"{FirstName} {LastName} is a {Age} year old Human who identifies as {Gender}. {PathMessage}.");  //character creation message prints when a new character is created.
        }

        public string FirstName{get; set;}
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Pronoun { get; set; }
        public string Path { get; set; }
        public string PathMessage { get; set; } //this property is purely for having fun with the character creation message.
        
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
                Console.WriteLine("Druid");
                Console.WriteLine("Mage");
                path = Console.ReadLine().ToLower();
                switch (path)
                {
                    case "knight":
                        return path;
                    case "thief":
                        return path;
                    case "druid":
                        return path;
                    case "mage":
                        return path;
                    default:                                       //if invalid input is entered, message shows and loop begins again until a provided path is chosen.
                        Console.WriteLine($"*wagging my finger* Ah - ah - ah! You didn't say the magic word!");
                        Console.WriteLine($"You must choose one of the prescribed destinies.");
                        Console.WriteLine();
                        break;
                }
            } while (path != "knight" && path != "thief" && path != "druid" && path != "mage");

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
                                  $"rightfully earned. Now if you'd be so good as to add to the collection plate...";
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
            string pronoun;
            Console.WriteLine("*sympithetic wince* You're going to have a hard time.");
            Console.WriteLine("What pronoun would you like to use?");
            pronoun = Console.ReadLine();
            Console.WriteLine();
            return pronoun;
        }
    }
}
