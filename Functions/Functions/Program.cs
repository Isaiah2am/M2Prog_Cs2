using System.Net.Mime;

namespace Functions
{
    internal class Program
    {
        string[] vragen = new string[]
        {
            "ben je l?",
            "ben je w?"

        };
        internal string getvraag(int vraagindex)
        {
            return vragen[vraagindex];
        }


        internal string getrandomvraag()
        {
            //1 maak eem new random object
            Random rand = new Random();
            int random = rand.Next(vragen.Length);
            return getvraag(random);
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.run();

            //class
        }
        internal void run()
        {
            Console.WriteLine("dit is de start van mijn progamma");
            vraag1();
            vraag2();
            vraag3();
            vraag4();
            vraag5();
            vraag6();
            string vraag0 = getvraag(0);
            Console.WriteLine(vraag0);
            string vraagr= getrandomvraag();

            Console.WriteLine(vraagr);
            



        }
        internal void vraag1()
        {
            Console.WriteLine("how long do you think you can survive a zombie apocolypse?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);

        }
        internal void vraag2()
        {
            Console.WriteLine("What would you do if you won a million dollars?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);

        }
        internal void vraag3()
        {
            Console.WriteLine("Why do round pizzas come in square boxes?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);

        }
        internal void vraag4()
        {
            Console.WriteLine("What would you call a male ladybug?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);

        }
        internal void vraag5()
        {
            Console.WriteLine("What is the worst game you played but that you liked anyway?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);

        }
        internal void vraag6()
        {
            Console.WriteLine("What would you call a male human?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);

        }
        internal void vraag7()
        {
            Console.WriteLine("How long do you think you can survive a zombie apocolypse?");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);

        }
    }
}
