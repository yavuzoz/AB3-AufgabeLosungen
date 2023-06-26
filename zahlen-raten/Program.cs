using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zahlen_raten
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int zahl = random.Next(1, 100);
            int geraten;
            int geratenZahl=0;

            Console.WriteLine("bitte zahl raten (1-100)");
            geraten = int.Parse(Console.ReadLine());

            do
            {
                geratenZahl++;
                Console.WriteLine("geraten zahl :  " + geratenZahl + " . geraten");
                if(zahl> geraten)
                {
                    Console.WriteLine("die zahl ist gross, bitte noch grosser zahl raten : ");
                    geraten = int .Parse(Console.ReadLine());
                }else if(zahl< geraten)
                {
                    Console.WriteLine("die zahl ist klein , bitte noch kleiner zahl raten : ");
                    geraten =int.Parse(Console.ReadLine());
                }

            }while(geraten!=zahl);

            int result = punktBerechnen(geratenZahl);
            Console.WriteLine("sie haben gewinnen, und " + geratenZahl + ". mal geraten , ihr punkt is ::" + result); 
            Console.ReadLine();
        }

        static int punktBerechnen(int geratenZahl)
        {
            int punkt=0;
            if (geratenZahl == 1)
            {
                punkt = 100;
                Console.WriteLine(" Ihre punkt : " + punkt);
            }else if (geratenZahl == 2)
            {
                punkt = 75;
                Console.WriteLine("ihre punkt :" + punkt);
            }
            else if (geratenZahl == 3)
            {
                punkt = 50;
                Console.WriteLine("ihre punkt :" + punkt);
            }
            else if (geratenZahl == 4)
            {
                punkt = 30;
                Console.WriteLine("ihre punkt :" + punkt);
            }
            else if (geratenZahl == 5)
            {
                punkt = 15;
                Console.WriteLine("ihre punkt :" + punkt);
            }
            else if (geratenZahl == 6)
            {
                punkt = 5;
                Console.WriteLine("ihre punkt :" + punkt);
            }

            return punkt;
        }
    }
}
