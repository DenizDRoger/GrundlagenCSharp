using System;

namespace Methoden_uebung_hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            bool richtig = false;
            bool richtig2 = false;
            string nachname;
            short zimmernummer;
            string[] zimmernummern = { "45", "23", "3", "32" };
            string[] vornamen = { "John", "Paul", "Geroge", "Ringo" };
            string[] nachnamen = { "Lennon", "McCartney", "Harrison", "Starr" };
            short[] übernachtungen = { 1, 4, 12, 3 };
            double[] rechnungsbetrag = {82.46, 329.84, 989.52, 247.38};

            Console.WriteLine("Bitte geben Sie ihren Nachnamen oder ihre Zimmernummer ein:");
           
            
            nachname = Console.ReadLine();
            if (Int16.TryParse(nachname, out zimmernummer))
            {
                richtig2 = GetData(richtig);
            }

            else
            {

            }



            Console.WriteLine();

            






        }
        static bool GetData(string nachname, string[] nachnamen, string[] vornamen, short[] übernachtungen, double[] rechnungsbetrag, bool richtig)
        {
            if (eingabe == nachnamen)
            {
                richtig = true;
            }

            else if (eingabe == zimmernummern)
            {
                richtig = true;
            }

            else
            {
                ausgabe = "Ihre Eingabe ist falsch.";
                richtig = false;
            }

            

            return richtig;
        }

        static bool GetData(short zimmernummer, short[]zimmernummern, string[] vornamen, short[] übernachtungen, double[] rechnungsbetrag, bool richtig)
        {
            if (eingabe == nachnamen)
            {
                ausgabe = "hallo";
                richtig = true;
            }

            else if (eingabe == zimmernummern)
            {
                ausgabe = "hallo";
                richtig = true;
            }

            else
            {
                ausgabe = "Ihre Eingabe ist falsch.";
                richtig = false;
            }



            return richtig;
        }
    }
}
