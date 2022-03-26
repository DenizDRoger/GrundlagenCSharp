using System;

namespace Schleifen_uebungenA6
{
    class Program
    {
        static void Main(string[] args)
        {
            short eingabe = 1;


            while (eingabe != 0)
            {
                Console.WriteLine("Menü ");
                Console.WriteLine("Um das Programm zu beenden müssen Sie 0 eingeben");
                eingabe = Convert.ToInt16(Console.ReadLine());
            }
        }
    }
}