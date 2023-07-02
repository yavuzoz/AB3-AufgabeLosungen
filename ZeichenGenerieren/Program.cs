using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeichenGenerieren
{
    class Program
    {
        static void Main(string[] args)
        {
            string start;
            string end;
            bool weiter=false;

            do
            {
                Console.WriteLine("Bitte startbuchstabe eingeben : ");
                start = Console.ReadLine();
                Console.WriteLine("Bitte endbuchstabe eingeben :");
                end = Console.ReadLine();

                if (string.IsNullOrEmpty(start) || string.IsNullOrEmpty(end))
                {
                    Console.WriteLine("es muss nicht leer sein!");
                    weiter = true;
                }
                else if (start.Length > 1 || end.Length > 1)
                {
                    Console.WriteLine("bitte nur ein buschstaben eingeben");
                    weiter = true;
                }
                else if (String.Compare(start, end) >= 0)
                {
                    Console.WriteLine("erste buchstaben muss klein sein");
                    weiter = true;
                }
                else
                {
                    for (int i = start[0]; i <= end[0]; i++)
                    {
                        char c = (char)i;
                        Console.Write(c.ToString().ToLower()+ " ");
                    }
                    weiter = false;
                }

                Console.ReadLine();
            } while (weiter==true);

            
        }
    }
}
