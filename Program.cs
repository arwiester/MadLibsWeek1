using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs_Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            //dynamic word inputs
            string adjective;
            string noun;
            string verbPastTense;
            string adverb;
            string verb;

            Console.WriteLine($"Welcome to Mad Libs! I'm going to ask you for a series of words: nouns, adjectives, verbs, etc. " +
                "Next I will take those words and tell you a story. \n\n" +
                "Press enter to start.\n");
            Console.ReadKey();
            
            //asks for an adjective and stores it as a string variable
            Console.WriteLine($"Enter an adjective:");
            adjective = Console.ReadLine();

            //asks for a noun and stores it as a string variable
            Console.WriteLine($"Enter a noun:");
            noun = Console.ReadLine();
           
            //asks for a verb and stores it as a string variable
            Console.WriteLine($"Enter a verb:");
            verb = Console.ReadLine();

            //asks for a adverb and stores it as a string variable
            Console.WriteLine($"Enter a adverb:");
            adverb = Console.ReadLine();

            //asks for a past tense verb and stores it as a string variable
            Console.WriteLine($"Enter a past tense verb:");
            verbPastTense = Console.ReadLine();

            //takes the inputted string varibales and plugs them into the Mad Lib story
            Console.WriteLine($"Today I went to the zoo. I saw a {adjective} {noun} jumping up and down in its tree. \n" +
                $"He {verbPastTense} {adverb} through the large tunnel that led to its {adjective} {noun}. \n" +
                $"I got some peanuts and passed them through the cage to a gigantic gray {noun} towering above my head.\n" +
                $"Feeding that animal made me hungry. I went to get a {adjective} scoop of ice cream. It filled my stomach.\n" +
                $"Afterwards I had to {verb} {adverb} to catch our bus. When I got home I {verbPastTense} my mom for a {adjective} day at the zoo. \n" ); 
            
            Console.WriteLine($"Press any key to exit the Mad Lib");

            Console.ReadKey();
        }
    }
}
