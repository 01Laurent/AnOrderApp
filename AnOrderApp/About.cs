using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnOrderApp
{
    internal class About
    {
        public void aboutWebsite() //presents the locations of the store
        {
            Console.WriteLine("We have different branches across the Country");
            Console.WriteLine();

            List<string> branches = new List<string>() //declaring and initializing a new List object named branches which will hold the strings (branches)
            { //creating an empty string that can hold strings and assigning them to the variable branches
                "Chaka road Mall",
                "Next Gen Mall",
                "Imaara Mall"
            };

            Console.WriteLine("A list of our branches");
            foreach (string branch in branches)
            {
                Console.WriteLine(branch); //line to list the branches in the List<string>
            }

            Console.WriteLine();
            Console.WriteLine("You can also contact us using this number, 01122334455");
            Console.WriteLine();
        }
    }
}
