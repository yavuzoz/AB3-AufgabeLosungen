using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AB3_Aufgabe11_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int numberOfItems;
            string sentence;

            Console.WriteLine("Geben Sie einen Satz ein:  "); // Benutzer wird aufgefordert, einen Satz einzugeben.
            sentence = Console.ReadLine(); // Der vom Benutzer eingegebene Satz wird eingelesen.
            if (sentence != "")
            {
                char splitOn;

                splitOn = ' ';
                numberOfItems = Numberofinstances(sentence, splitOn); // Die Numberofinstances-Funktion wird aufgerufen, um die Anzahl der Wörter im Satz zu berechnen.
                Console.WriteLine("Anzahl der Wörter: " + numberOfItems); // Die Anzahl der Wörter wird in der Konsole ausgegeben.
                Console.ReadLine(); // Warten auf Benutzereingabe, um die Konsole geöffnet zu halten.
            }
            else
            {
                Console.WriteLine("Anzahl der Wörter: " + 0); // Wenn ein leerer Satz eingegeben wird, wird die Anzahl der Wörter als 0 ausgegeben.
                Console.ReadLine(); // Warten auf Benutzereingabe, um die Konsole geöffnet zu halten.
            }
        }

        public static int Numberofinstances(string sentence, char splitOn)
        {
            int wordCount;// Eine Variable, um die Anzahl der Wörter zu zählen.
            int count; // Eine Variable für die Schleifeniteration.  

            wordCount = 1; // Initialisierung der Anzahl der Wörter auf 1.
            for (count = 0; count <= sentence.Length - 1; count++) // Schleife, um den Satz zu durchlaufen.
            {
                if (sentence[count] == splitOn)// Überprüft, ob das aktuelle Zeichen im Satz dem Trennzeichen entspricht.
                {
                    wordCount = wordCount + 1; // Inkrementiert die Anzahl der Wörter, wenn das Trennzeichen gefunden wird.
                }
            }
            return wordCount; // Gibt die Gesamtzahl der Wörter zurück.
        }

    }
}

