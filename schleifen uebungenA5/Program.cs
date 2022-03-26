using System;

namespace schleifen_uebungenA5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bitte tragen sie eine zahl ein");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = -a; i <= a; i = i + 2)
            {
                Console.Write("{0,3}", +i);
            }

        }

    }
}