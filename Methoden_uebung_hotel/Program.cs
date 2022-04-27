using System;

namespace Methoden_uebung_hotel
{
    class Program
    {
        static void Main(string[] args)
            //deniz kartal und murtaza behzad
        {
            short[] zimmernummer = { 45, 23, 3, 32 };
            string[] vorname = { "John", "Paul", "George", "Ringo" };
            string[] nachname = { "Lennon", "McCartney", "Harrison", "Starr" };
            short[] übernachtung = { 1, 4, 12, 3 };
            double[] rechnungsbetrag = { 82.46, 329.84, 989.52, 247.38 };
            do
            {
                Console.WriteLine("Geben Sie ihren nachnamen oder zimmernummer ein");
                string eingabe_str = Console.ReadLine();
                short eingabe_short;

                bool flag = short.TryParse(eingabe_str, out eingabe_short);
                

                if (flag == true)
                {
                    var daten = GetData(eingabe_short, zimmernummer, vorname, nachname, übernachtung, rechnungsbetrag);
                    if (daten.Item1 == true)
                    {
                        Console.Clear();
                        Console.WriteLine(daten);
                    }
                    else
                    {

                        Console.Clear();
                        Console.WriteLine("Gast nichtgefunden");
                    }
                }
                else
                {
                    
                    var daten = GetData(eingabe_str, zimmernummer, vorname, nachname, übernachtung, rechnungsbetrag);

                    if(daten.Item1==true)
                    {
                        Console.Clear();
                        Console.WriteLine(daten);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Gast nichtgefunden");
                    }
                }

            } while (true);
        }
        static (bool, short, string, string, short, double) GetData(short diff, short[] zn, string[] vn, string[] nn, short[] ue, double[] rb)
        {
            bool flag = false;
            int index = 0;
            for (int i = 0; i < nn.Length; i++)
            {
                if (diff == zn[i])
                    index = i;
                flag = true;
            }


                return (flag, zn[index],vn[index],nn[index],ue[index],rb[index]) ;
        }
        static (bool, short, string, string, short, double) GetData(string diff, short[] zn, string[] vn, string[] nn, short[] ue, double[] rb)
        {
            bool flag = false;
            int index = 0;
            for (int i = 0; i < nn.Length; i++)
            {
                if (diff == nn[i])
                {
                    index = i;
                    flag = true;
                }


            }
            return (flag, zn[index], vn[index], nn[index], ue[index], rb[index]);
        }

    }
}
