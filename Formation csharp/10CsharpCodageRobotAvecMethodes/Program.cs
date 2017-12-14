using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCodageRobot2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Je suis R2D2, je sais courir");
            Courir();
            int value = Sommer(1, 2);
            Console.WriteLine("1. Valeur sommée : " + value);

            // Comment alors retourner plusieurs éléments ?
            // Notion de tuples
            Tuple<string, string> resultat = SeparerChaineEnDeux("JESUISUNROBOT");
            Console.WriteLine("3. Tuple, Résultat 1 : " + resultat.Item1 + ", resultat 2 : " + resultat.Item2);
            // D'autre façon de retourner plusieurs résultats ? 
            // =>  dictionary, list, ...

            Console.ReadLine();
        }

        static Tuple<string, string> SeparerChaineEnDeux(string chaine)
        {
            int halfPartIndex = chaine.Length / 2;

            return new Tuple<string, string>(chaine.Substring(0, halfPartIndex), chaine.Substring(halfPartIndex, chaine.Length - halfPartIndex));
        }

        /// <summary>
        /// 1 Méthode pour faire courir le robot
        /// </summary>
        static void Courir()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Je me déplace de " + i + "km");
            }
        }

        static int Sommer(int a, int b)
        {
            return a + b;
        }

    }
}
