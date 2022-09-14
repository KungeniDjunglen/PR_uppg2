using System;

namespace Uppgift2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur långt hoppade Elin? ");
            string Elin = Console.ReadLine();
            Console.WriteLine("hur långt hoppade Alma? ");
            string Alma = Console.ReadLine();
            int iElin = int.Parse(Elin);
            int iAlma = int.Parse(Alma);
            int Resultat = iElin - iAlma;
            Console.WriteLine("Elin hoppade " + Resultat + " meter längre än Alma");

        }
    }
}