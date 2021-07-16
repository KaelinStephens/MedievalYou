using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MedievalTextGame
{
    public class Human
    {
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

        public  string FirstName{get; set;}
        public  string LastName { get; set; }
        public  int Age { get; set; }
        public  string Gender { get; set; }
        public  string Pronoun { get; set; }
        public  string Path { get; set; }
        public  string PathMessage { get; set; } //this property is purely for having fun with the character creation message.
    }
}
