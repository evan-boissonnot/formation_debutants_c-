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
            Console.WriteLine("Je suis R2D2, prêt pour le combat");

            string maValeur = "Je suis un robot";
            String maSecondeValeur = "intelligent";

            string concatenation = maValeur + " " + maSecondeValeur;

            Console.WriteLine("1. Concatenation : " + concatenation + string.Empty);

            concatenation = concatenation.ToLower();
            Console.WriteLine("2. Mise en minuscule : " + concatenation);

            concatenation = concatenation.ToUpper();
            Console.WriteLine("3. Mise en majuscule : " + concatenation);

            string quatriemeCaractere = concatenation.Substring(3, 1); // Commence à zéro
            Console.WriteLine("4. Affichage 4° caractère : " + quatriemeCaractere);

            string premierCaractere = concatenation.Substring(0, 1); // Commence à zéro
            Console.WriteLine("4. Affichage 1° caractère : " + premierCaractere);

            concatenation = concatenation.PadRight(concatenation.Length + 5);
            Console.WriteLine("5. Ajout de caractères blancs : " + concatenation + ".");

            Console.WriteLine("6. Suppression des caractères blancs : " + concatenation.Trim() + ".");

            bool estVide = string.IsNullOrEmpty("");
            Console.WriteLine("7. Chaine vide ? " + estVide);

            Console.ReadLine();
        }
    }
}
