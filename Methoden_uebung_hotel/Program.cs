using System;

namespace Methoden_uebung_hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            short[] zimmernummer = { 45, 23, 3, 32 };
            string[] vorname = { "John", "Paul", "George", "Ringo" };
            string[] nachname = { "Lennon", "McCartney", "Harrison", "Starr" };
            short[] übernachtung = { 1, 4, 12, 3 };
            double[] rechnungsbetrag = { 82.46, 329.84, 989.52, 247.38 };

            do
            {
                Console.WriteLine("Geben Sie ihre Daten ein");
                string eingabe_str = Console.ReadLine();
                short eingabe_short;

                bool flag = short.TryParse(eingabe_str, out eingabe_short);

                if (flag == true)
                {
                    Console.WriteLine(GetData(eingabe_short, zimmernummer, vorname, nachname, übernachtung, rechnungsbetrag));
                }
                else
                {
                    
                    Console.WriteLine(GetData(eingabe_str, zimmernummer, vorname, nachname, übernachtung, rechnungsbetrag));
                }

            } while (true);
        }
        static (bool, short, string, string, short, double) GetData(short diff, short[] zn, string[] vn, string[] nn, short[] ue, double[] rb)
        {

            
            if (eingabe == zn)



            return (true, 0, "", "", 0, 0.0);
        }
        static (bool, short, string, string, short, double) GetData(string diff, short[] zn, string[] vn, string[] nn, short[] ue, double[] rb)
        {




            return (true, 0, "", "", 0, 0.0);
        }




    }
}