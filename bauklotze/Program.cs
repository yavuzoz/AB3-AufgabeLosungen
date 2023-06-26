using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bauklotze
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geben sie anzahl bauklotze ein : ");
            int anzahlBau= int .Parse(Console.ReadLine());
            int bleibenBau=anzahlBau;
            int benutzBau = 0;
            int bereitBau = 1;
            int nummrZeile=0;

            while (bleibenBau >= bereitBau)
            {
                benutzBau = bereitBau + benutzBau;
                bleibenBau = anzahlBau-benutzBau;
                bereitBau += 2;
                nummrZeile++;
                Console.WriteLine("zeile nummer : " + nummrZeile);
                Console.WriteLine("bleiben bauklotze " + bleibenBau + "von anzahlbau " + anzahlBau);

            }
            Console.ReadLine();
        }
    }
}
