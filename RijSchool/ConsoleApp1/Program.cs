namespace ConsoleApp1
{
    internal class Program;
    internal class auto
    {
        internal bool automaat;
        internal string merk;
        internal string kenteken;
        internal int kilometerstand;
    };
    internal class rijleraar
    {
        internal string naam;
        internal int leeftijd;
        internal bool zzp;
    }
    internal class student
    {
        internal string naam;
        internal int leeftijd;
        internal lespakket lespakket;
        internal rijleraar leeraar;
        internal theorietest theorietest;
        internal rijtest rijtest;
    }
    internal class lespakket
    {
        internal int urengekocht;
        internal int urenverbruikt;
        internal int examenpoging;
        internal bool automaat;
    }
    internal class rijtest
    {
        internal bool datum;
        internal lesuur[] lesuren;
    }
    internal class theorietest
    {
        internal int aantalfouten;
        internal bool gehaald;
        internal DateTime afnamedatum;
    }
    internal class lesuur 
    {
        internal int tijd;
        internal student student;
        internal rijleraar rijleraar;
        internal auto auto;
    }


    internal class Dag;
    internal class Myclass
    {
        static void Main(string[] args)
        {
            



        }
    }
}
