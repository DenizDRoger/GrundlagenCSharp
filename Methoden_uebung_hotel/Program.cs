using System;

namespace Methoden_uebung_hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            
            short[] zimmernummern = { 45, 23, 3, 32 };
            string[] vornamen = { "John", "Paul", "Geroge", "Ringo" };
            string[] nachnamen = { "Lennon", "McCartney", "Harrison", "Starr" };
            short[] übernachtungen = { 1, 4, 12, 3 };
            double[] rechnungsbetrag = {82.46, 329.84, 989.52, 247.38};
            int i = 0;

            Console.WriteLine("bitte geben sie ihren nachnamen oder ihre zimmernummer an");
            string eingabe_Str = Console.ReadLine();
            short eingabe_Short;

            bool flag = short.TryParse(eingabe_Str, out eingabe_Short);
            if (flag == false )
            {
                Console.WriteLine("daten gefunden");
            }
            else if (flag != false)
            {
                Console.WriteLine("daten nicht da  ");
            }
                
        }
        static (bool, short, string, string, short,double) GetData(string diff, string[] nachnamen, string[] vornamen, short[] übernachtungen, double[] rechnungsbetrag, bool richtig)
        {
            bool flag = false;
            int index = 0;
            for (int i = 0; i < nachnamen.Length; i++)
            {

                {if (diff == nachnamen[i])
                    index = i ;
                    flag = true;
                }
            }
            return (flag, nachnamen[index], vornamen[index], übernachtungen[index], rechnungsbetrag[index]);
        }
    }
}
