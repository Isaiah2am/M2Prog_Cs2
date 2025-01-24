using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace list
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
             string[] characters = 
                  [
                    "Pac-Man",
                    "Samus",
                    "Crash Bandicoot",
                    "Spyro the Dragon",
                    "Donkey Kong",
                    "Mario",
                    "Luigi",
                    "Astro",
                    "Solid Snake",
                    "Master Chief",
                    "Kratos",
                    "Sonic the Hedgehog",
                    "Link",
                    
                 ];

            List<string> characterList = new List<string>(  );
             characterList.Add("timmy");


            foreach (string character in characters)
            {
                characterList.Add(character);
            }

            foreach (string character in characterList)
            {
                Console.WriteLine(character);
            }
        }
    }
}
