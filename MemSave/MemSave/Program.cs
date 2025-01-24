using System.Net;
using System.Net.Security;

namespace MemSave
{


    internal class Program
    {

        string saveFile = "welkomState";

        string welkomTekst = "hello world";

        

        static void Main(string[] args)
        {
            Program program = new Program();
            program.run();
           
        }

        internal void run() {

            bool bestaatDeFile = File.Exists(saveFile);

             

            if (bestaatDeFile) { 
            
                File.ReadAllText(saveFile);

                
            }

           


            while (true)
            {
                Console.WriteLine("Enter a text and then press enter");
                welkomTekst = Console.ReadLine();

                File.WriteAllText(saveFile, welkomTekst);   

            }   

        }

    }
}
