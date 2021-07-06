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

        public Human(string firstName, string lastName,  int age, string gender, string pronoun, string path, string pathMessage)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
            Pronoun = pronoun;
            Path = path;
            PathMessage = pathMessage;
            Console.WriteLine($"{FirstName} {LastName} is a {Age} year old Human who identifies as {Gender}. {FirstName} {PathMessage}.");
        }
        public string FirstName{get; set;}
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Pronoun { get; set; }
        public string Path { get; set; }
        public string PathMessage { get; set; }
        public static Human CreateNewHuman()
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("What is your surname?");
            string lastName = Console.ReadLine();
            Console.WriteLine();
            int age = GetAge();
            Console.WriteLine();
            string gender = GetGender();
            Console.WriteLine();
            string pronoun = GetPronoun(gender);
            string path = GetPath();
            string pathMessage = GetPathMessage(path);
            Console.WriteLine();


            return new Human(firstName, lastName, age, gender, pronoun, path, pathMessage);

        }

        public static string GetPath()
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
                    default:
                        Console.WriteLine($"*wagging my finger* Ah - ah - ah! You didn't say the magic word!");
                        Console.WriteLine($"You must choose one of the prescribed destinies.");
                        Console.WriteLine();
                        break;
                }
            } while (path != "knight" && path != "thief" && path != "druid" && path != "mage");

            return path;
        }

        public static string GetPathMessage(string path)
        {
            string pathMessage;
            switch (path)
            {
                case "knight":
                    pathMessage =
                        "slaves the days away as the Great Knight Sir MacGuffin's page hoping to someday become a knight. Too bad even the smallest of knives are too heavy to wield";
                    return pathMessage;
                case "thief":
                    pathMessage = "is 'so lazy,' according to Father Guile, 'as to forgo the God-given right of all peasants [fieldwork] to pursue a life of sin; taking what was not rightfully earned. Now if you'd be so good as to add to the collection plate...";
                    return pathMessage;
                case "druid":
                    pathMessage = "drifts through the forest day after day communing with nature...Well, trying to anyway. If only there was a Grove of Druids around to teach even the basics..";
                    return pathMessage;
                case "mage":
                    pathMessage =
                        "spends most days ineffectually cursing people, waggling sticks in the air with nary a twinkling light, and hocking cure-alls concocted from whatever herb-looking things were around at the time--typically, grass, leaves, and sticks";
                    return pathMessage;
            }

            return "nothing to see here";
        }
        public static string GetGender()
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
                    default:
                        Console.WriteLine();
                        Console.WriteLine($"{gender} is not one of the options presented. Please try again.");
                        Console.WriteLine();
                        break;
                }
            } while (gender != "male" && gender != "female" && gender != "other");

            return gender;

        }

        public static int GetAge()
        {
            int age = IsNumbers();

            while (age < 0 || age > 75)
            {
                while (age > 75)
                {
                    Console.WriteLine("Nice try, but no one lives over the age of 75 in the Medieval Times. Don't ask me how I know. I just do.");
                    Console.WriteLine();
                    age = IsNumbers();
                }
                while (age < 0)
                {
                    Console.WriteLine("Hmm...Nope. Your responding to these prompts indicates you must already be born.");
                    Console.WriteLine();
                    age = IsNumbers();
                }
            }
            return age;
        }

        public static int IsNumbers()
        {
            bool isNumbers;
            int age;
            do
            {
                Console.WriteLine("How old are you?");
                isNumbers = int.TryParse(Console.ReadLine(), out age);
                if (isNumbers == false)
                {
                    Console.WriteLine("*facepalm* That...that isn't a valid age. Please make it easy on me by entering your age in whole-digit format.");
                    Console.WriteLine();
                }
            } while (isNumbers == false);
            return age;
        }

        public static string GetPronoun(string gender)
        {
            var pronoun = "they";
            switch (gender)
            {
                case "other":
                    Console.WriteLine("*sympithetic wince* You're going to have a hard time.");
                    Console.WriteLine("What pronoun would you like to use?");
                    pronoun = Console.ReadLine();
                    Console.WriteLine();
                    return pronoun;
                case "male":
                    pronoun = "he";
                    return pronoun;
                case "female":
                    pronoun = "she";
                    return pronoun;
            }

            return pronoun;

        }
       
    
    }
}
