using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace einkaufen_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geben sie einkauf :");
            int einkauf = int .Parse(Console.ReadLine());
            int differenz=einkauf;

            do
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("geben sie betrag :");
                int betrag = int .Parse(Console.ReadLine());
                differenz -= betrag;

                

                if (differenz < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("rückgeld :" + (-differenz));
                }else if (differenz > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("differenz : " + differenz);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("vielen dank . " + differenz);
                }

            } while (differenz > 0);

            Console.ReadLine();
        }
    }
}
