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
            int[] unTableauUneDimension = new int[5] { 1, 2, 3, 4, 5 };

            // Comment parcourir un tableau ?
            // Itération complète
            for (int i = 0; i < unTableauUneDimension.Length; i++)
            {
                Console.WriteLine("1. Tableau un, valeur[" + i + "] = " + unTableauUneDimension[i]); // Les valeurs de types primitifs sont préinitialisées à 0
            }

            for (int j = 0; j < unTableauUneDimension.Length; j++)
                Console.WriteLine("2. Tableau un, valeur[" + j + "] = " + unTableauUneDimension[j]); // Les valeurs de types primitifs sont préinitialisées à 0

            // Itération avec le tant que
            int k = 0;
            //while(k < unTableauUneDimension.Length) // Problème ici ?
            //{
            //    Console.WriteLine("3. Tableau un, valeur[" + k + "] = " + unTableauUneDimension[k]);
            //}

            k = 0;
            //while (k++ < unTableauUneDimension.Length) // Problème ici ?
            //{
            //    Console.WriteLine("3. Tableau un, valeur[" + k + "] = " + unTableauUneDimension[k]);
            //}

            k = 0;
            while (k < unTableauUneDimension.Length)
            {
                Console.WriteLine("3. Tableau un, valeur[" + k + "] = " + unTableauUneDimension[k]);
                k++;
            }

            // Conditions
            if (true)
                Console.WriteLine("4. Le if valide une valeur booléenne à true");

            if (false)
                Console.WriteLine("5. Le if valide une valeur booléenne, on ne passe pas ici");
            else
                Console.WriteLine("5. Le if valide une valeur booléenne, on passe ici");

            if (unTableauUneDimension[0] == 1)
            {
                Console.WriteLine("6. On vérifier la valeur et on entre dans le if");
            }

            if (unTableauUneDimension[2] == 2)
            {
                Console.WriteLine("7. On ne passera jamais ici");
            }



            // Découverte du switch
            for (int i = 0; i < unTableauUneDimension.Length; i++)
            {
                switch (unTableauUneDimension[i])
                {
                    case 1:
                        {
                            Console.WriteLine("8. Valeur 1 trouvée");
                        }
                        break;

                    case 2:
                        {
                            Console.WriteLine("8. Valeur 2 trouvée");
                        }
                        break;

                    default:
                        Console.WriteLine("8. Autre valeur trouvée : " + unTableauUneDimension[i]);
                        break;
                }
            }


            // Cas des énumération
            // TODO: 13/12/2017, finir le cas des énum + le switch case

            Console.ReadLine();
        }

        enum enumATroisValeurs
        {
            Etat1 = 0,
            Etat2 = 3,
            Etat3 = 5
        }

    }
}
