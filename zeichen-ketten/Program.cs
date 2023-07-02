using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zeichen_ketten
{
    class Program
    {
        static void Main(string[] args)
        {
            int zeichencode = 66;
            char zeichen;
            string zeichenkette;
            zeichen = (char)zeichencode; // int -> char
            Console.WriteLine(zeichen);
            zeichenkette = ((char)zeichencode).ToString(); // int -> char -> string

            Console.WriteLine(zeichenkette);
       // Alternativ:
            zeichenkette = "" + (char)zeichencode; // int -> char -> string

            int code;
            string zeich = "a";
            code = zeich[0];
            Console.WriteLine(code);
            Console.WriteLine(zeichenkette);

            string text = "Visual Studio";
            if (string.IsNullOrEmpty(text))
            {
                Console.WriteLine("ok");
            }
            else
            {
                Console.WriteLine("auch ok");
            }
            int laenge = text.Length; // Länge
            string ausschnitt = text.Substring(7, 6); // Ausschnitt
            string gross = text.ToUpper(); // in Grossbuchstaben umwandeln
            string klein = text.ToLower(); // in Kleinbuchstaben umwandeln
            Console.WriteLine(ausschnitt);
            Console.WriteLine(gross);

            string text1 = "Visual Studio";
            string suche = "is";
            if (text1.Contains(suche))
            {
                Console.WriteLine(suche + " ist drin in " + text1);
            }

            AusgabeAufLeeremBildschirm("Hallo");
            Console.WriteLine("geben sie text :");
            string text11=Console.ReadLine();
            Console.WriteLine("geben sie zahl :");
            int zahl11=int .Parse(Console.ReadLine());
            WiederholeText(text11, zahl11);


            Console.ReadLine();
        }

        public static void AusgabeAufLeeremBildschirm(string text)
        {
            
            Console.WriteLine(text);
        }

        public static void WiederholeText(string text, int anzahl)
        {
            int i = 0; // Variable nur innerhalb der Methode
            while (i < anzahl)
            {
                Console.WriteLine((i+1) + text); // Ausgabe ohne <Enter>
                i++; // entspricht i = i + 1;
            }
        }
    }
}
