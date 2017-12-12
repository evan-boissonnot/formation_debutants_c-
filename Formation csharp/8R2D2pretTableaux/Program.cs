using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace R2D2pret
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] unTableauUneDimension = new int[5];
            int[] unSecondTableauUneDimension = { 1, 2, 3 };
            string[] unTroisiemeTableauUneDimension = new string[3] { "chaine 1", "chaine 2", "chaine 3" };

            // Comment parcourir un tableau ?
            // Itération complète
            for (int i = 0; i < unTableauUneDimension.Length; i++)
            {
                Console.WriteLine("1. Tableau un, valeur[" + i + "] = " + unTableauUneDimension[i]); // Les valeurs de types primitifs sont préinitialisées à 0
            }

            for (int i = 0; i < unSecondTableauUneDimension.Length; i++)
                Console.WriteLine("2. Tableau deux, valeur[" + i + "] = " + unSecondTableauUneDimension[i]);

            for (int i = 0; i < unTroisiemeTableauUneDimension.Length; i++)
                Console.WriteLine("3. Tableau trois, valeur[" + i + "] = " + unTroisiemeTableauUneDimension[i]);

            Console.ReadLine();
        }
    }
}
