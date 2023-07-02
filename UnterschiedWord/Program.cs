using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnterschiedWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie einen Satz ein: ");
            string satz = Console.ReadLine();

            int wordZahl = 1;
            char leer = ' ';
            string word = "";

            for (int i = 0; i < satz.Length; i++)
            {
                word += satz[i].ToString();

                if (satz[i] == leer)
                {
                    Console.WriteLine(word);
                    word = "";
                    wordZahl++;
                }
            }

            if (!string.IsNullOrWhiteSpace(word))
            {
               
            }

            Console.WriteLine("Anzahl der Wörter: " + wordZahl);
            Console.ReadLine();
        }

    }
}
