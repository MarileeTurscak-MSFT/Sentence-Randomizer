using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            for (int i = 0; i <= cont; i++)
                //use counter to ensure the loop continues.

            {
               int noun;
                Random rand = new Random();
                noun = rand.Next(0, 9);
                string[] nouns = { "Kim Jong Un ", "The queen ", "Dragons ", "The cat ", "The bat ", "The avocado ", "The monk ", "The hedgehogs ", "Demons ", "The dolphins " };
                //randomize string of nouns.

                int verb;
                verb = rand.Next(0, 9);
                string[] verbs = { "ate sushi ", "barbequed ", "chirped ", "swam ", "sang ", "spoke ", "cuddled ", "dined ", "chanted ", "fidgeted " };
                //randomize string of verbs.

                int phrase;
                phrase = rand.Next(0, 9);
                string[] phrases = { "with the badgers ", "in the dark ", "under the moon ", "after the storm ", "before the prince ", "in the Black Sea ", "in the castle ", "as the sun set ", "while hope was fading ", "with the Bulgarians " };
                //randomize string of phrases.

                string n = nouns[noun];
                string v = verbs[verb];
                string p = phrases[phrase];
                                
                //define each set of strings.

                StringBuilder madlib = new StringBuilder();
                {
                    madlib.Append(n);
                    madlib.Append(v);
                    madlib.Append(p);
                    //use StringBuilder to join strings together.
                }
                Console.WriteLine("Do you wish to continue?");
                //Ask for user input.
                string x = Console.ReadLine().ToUpper();
                //remove case sensitivity for user input.
                if (x == "Y")
                {
                    cont++;
                    
                 Console.WriteLine(madlib.ToString()); }
           //return joined strings at an increment of one.
                else 
               {
                    Environment.Exit(0);
                    //end program
                }
   }
        }
    }
}


