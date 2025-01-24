using System;

namespace ForHerhaling
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Program program = new Program();

            program.run();

        }

        internal void run()
        {
            double[] prijzen = new double[] { 0.99, 5.60, 10.11, 0.15 };

            string[] artiekelen = { "snoepje", "luxe broodje", "lunch menu", "plastic tas" };

            Formulier[] formulieren = new Formulier[2];

            for (int i = 0; i< prijzen.Length; i++)
            {
                Console.WriteLine(prijzen[i]);
                Console.WriteLine(artiekelen[i]);
            }

            

            formulieren[0] = new Formulier()
                {
                Feedback = "Prijzig maar lekker",
                        sterren = 5
                };

            formulieren[1] = new Formulier()
            {
                Feedback = "Er was geen pindakaas op mijn broodje",
                        sterren = 3
                };

            foreach (Formulier formulier in formulieren)
            {
                Console.WriteLine(formulier.Feedback);
                Console.WriteLine(formulier.sterren);
            }

        }
    }
        internal class Formulier
        {

 
        internal int sterren { get; set; }

        internal string Feedback { get; set; }

        }
    
}
