using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotenBerchnen
{
    class Program
    {
        static void Main(string[] args)
        {
            string antwort;
            int i = 0;
            float totalNoten=0;
            do
            {
                i++;
                Console.Write("bitte geben sie die " + i + " note ein :");
                float noten= float .Parse(Console.ReadLine());
                
                
                totalNoten = noten + totalNoten;
                float notenSchnitt = totalNoten / i; 
                Console.Write($"das ergibt einen notenschinitt von  : " +  notenSchnitt.ToString("0.##"));
                Console.WriteLine();
                Console.Write("noch eine note eingeben ? ( j/n ) ");
                antwort= Console.ReadLine();


            } while (antwort == "j");
            Console.WriteLine("vielen dank ! ");
            Console.ReadLine();
        }
    }
}
