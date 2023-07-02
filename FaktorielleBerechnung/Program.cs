using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaktorielleBerechnung
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte ein zahl eingeben: ");
            int zahl = Convert.ToInt32(Console.ReadLine());
            int result=1;

            for(int i = 1; i<=zahl; i++)
            {
                result *= i; 
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
