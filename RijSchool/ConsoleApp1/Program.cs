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

            auto auto1 = new auto()
            {
                automaat = true,
                kenteken = "AA8244",
                kilometerstand = 20567,
                merk = "volkswagen"

            };
            auto auto2 = new auto()
            {
                automaat = false,
                kenteken = "KU786G",
                kilometerstand = 65739,
                merk = "volvo"
            };

            rijleraar rijleraar = new rijleraar()
            {
                leeftijd = 30,
                naam = "John",
                zzp = false
            };

            lesuur lesuur = new lesuur()
            {
                auto = auto1,
                rijleraar = rijleraar,
                tijd = 1130
            };


        }
    }
}
