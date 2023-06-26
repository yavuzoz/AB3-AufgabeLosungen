using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AB3_Aufgabe_11_12_13_14_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string antwort;
            do
            {
                MacheBerechnung();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("nochmals berechnen? ( j/n )");
                Console.ForegroundColor = ConsoleColor.Gray;
                antwort = Console.ReadLine();
                

            } while(antwort.ToLower() == "j");

            int wert1 = 10;
            DateTime wert2 = new DateTime(2023, 12, 30);
            Console.WriteLine(" lösung1={0:F} lösüng2={1:D}", wert1, wert2);

            string isim = Console.ReadLine();
     
        }
        static void MacheBerechnung()
        {

            int differenz ;
            Console.WriteLine("geben sie einkauf eingaben ");
            int eingaben= int.Parse(Console.ReadLine());

            Console.WriteLine("geben sie einkauf zahl :");
            int zahl = int.Parse(Console.ReadLine());   
            differenz= eingaben-zahl;

            if( differenz > 0 )
            {
                Console.WriteLine("bitte noch " +  differenz + " zahlen "); 
            }else if(differenz < 0 )
            {
                Console.WriteLine("rückgeld : " + (-differenz));
            }
            else
            {
                Console.WriteLine(" vielen dank " + differenz );
            }
            
        }
    }
}
