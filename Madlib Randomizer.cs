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
                string[] nouns = { "She ", "He ", "It ", "The cat ", "The mongoose ", "The orange ", "The trampoline ", "Musicians ", "Programmers ", "The shake " };
                //randomize string of nouns.

                int verb;
                verb = rand.Next(0, 9);
                string[] verbs = { "ate ", "barbequed ", "chirped ", "collided ", "sang ", "spoke ", "cartwheeled ", "dined ", "watched ", "directed " };
                //randomize string of verbs.

                int phrase;
                phrase = rand.Next(0, 9);
                string[] phrases = { "with the monkeys ", "on the porch ", "under the moon ", "after the storm ", "before the prince ", "over the lake ", "in the gazebo ", "between the lines ", "during the festival ", "with them all " };
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


