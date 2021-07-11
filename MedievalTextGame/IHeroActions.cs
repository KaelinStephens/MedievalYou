using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Linq;
using System.Runtime.CompilerServices;

namespace MedievalTextGame
{
    public interface IHeroActions
    {
        public static void TalkToPeddlerConsequence()
        {
            Console.Write("Do you stop to ask? y/n");
            char talkToPeddler;
            do
            {
                talkToPeddler = Console.ReadKey().KeyChar;
                Console.Clear();
            } while (talkToPeddler != 'y' || talkToPeddler != 'n');
        }
    }
}
