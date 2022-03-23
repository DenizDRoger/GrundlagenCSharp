using System;

namespace Methoden_Uebung1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie oft soll das wort geschrieben werden");
            int durchlauf = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Geben sie bitte ihr Wort ein");
            string Text = Console.ReadLine();
            Console.Clear();

            int anzahl = 0;
            anzahl = ausgabeTextMalX(durchlauf, Text);

            Console.Write("\nAnzahl der Buchstaben: {0}", anzahl);
        }

        static int ausgabeTextMalX(int durchlauf, string Text)
        {
            for (int i = 0; i < durchlauf; i++)
            {
                Console.WriteLine(Text);
            }
            return Text.Length * durchlauf;
        }
    }
}
