using System;

namespace Schleifen_uebungenA7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bitte tragen sie eine zahl ein");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i >= 0; i--)
            {
                Console.WriteLine("{0}", +i);
            }
        }
    }
}