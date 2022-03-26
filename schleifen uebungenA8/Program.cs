using System;

namespace schleifen_uebungenA8
{
    class Program
    {
        static void Main(string[] args)
        {
            int eingabe;
            int anzahl = 0;
            do
            {
                anzahl++;
                Console.WriteLine("Geben Sie Ihren PIN ein: ");
                eingabe = Convert.ToInt32(Console.ReadLine());

            } while (eingabe != 1234);

            Console.WriteLine("Anzahl der Versuche:{0,2}", anzahl);
        }
    }
}