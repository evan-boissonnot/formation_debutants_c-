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

            Console.WriteLine("4. Average : " + unTableauUneDimension.Average());
            Console.WriteLine("5. Average : " + unSecondTableauUneDimension.Average());

            Console.WriteLine("6. Contient 2 ? " + unSecondTableauUneDimension.Contains(2));

            int value = (int) unSecondTableauUneDimension.GetValue(2);
            Console.WriteLine("7. Récupération de la valeur à l'index 2 : " + value);

            Console.WriteLine("8. Longueur du tableau : " + unSecondTableauUneDimension.Length);

            Console.WriteLine("9. Max : " + unSecondTableauUneDimension.Max());
            Console.WriteLine("10. Min : " + unSecondTableauUneDimension.Min());

            // Parler de : unSecondTableauUneDimension.Rank

            // Affectation valeur : 
            value = unSecondTableauUneDimension[2];
            unSecondTableauUneDimension[2] = 5;
            Console.WriteLine("11. Valeur avant : " + value + ", après : " + unSecondTableauUneDimension[2]);
            // ou bien
            value = unSecondTableauUneDimension[2];
            unSecondTableauUneDimension.SetValue(10, 2);
            Console.WriteLine("11. Valeur avant : " + value + ", après : " + unSecondTableauUneDimension[2]);



            // Tableau N dimensions
            int[,,] tableauAtroisDimensions;
            tableauAtroisDimensions = new int[,,] { 
                                                    { { 1, 2 }, 
                                                      { 3, 4 }
                                                    }, 
                                                    { { 5, 6 }, 
                                                      { 7, 8 }
                                                    },
                                                    { { 9, 10 },
                                                      { 11, 12 }
                                                    }
                                                  };

            string[,,,] unTableau = new string[,,,] 
            {
                {
                    {
                        {
                            "1"
                        },
                        {
                            "2"
                        },
                        {
                            "3"
                        },
                        {
                            "4"
                        },
                        {
                            "5"
                        },
                        {
                            "6"
                        },
                        {
                            "7"
                        },
                        {
                            "8"
                        },
                        {
                            "9"
                        },
                        {
                            "10"
                        },
                    },
                    {
                        {
                            "11"
                        },
                        {
                            "12"
                        },
                        {
                            "13"
                        },
                        {
                            "14"
                        },
                        {
                            "15"
                        },
                        {
                            "16"
                        },
                        {
                            "17"
                        },
                        {
                            "18"
                        },
                        {
                            "19"
                        },
                        {
                            "20"
                        },
                    }
                }
            };

            //for (int i = 0; i < tableauAtroisDimensions.Length; i++) // ne fonctionne pas, car length renvoie ici le nombre total d'élément, car multi dimensionnel
            //{
            //    Console.WriteLine("12. Affichage valeur une dimension [" + i + ", 0, 0] : " + tableauAtroisDimensions[i, 0, 0]);
            //}

            for (int i = 0; i < tableauAtroisDimensions.GetLength(0); i++) // On peut optimiser ce code => récursivité
            {
                for (int j = 0; j < tableauAtroisDimensions.GetLength(1); j++)
                {
                    for (int k= 0; k < tableauAtroisDimensions.GetLength(2); k++)
                    {
                        Console.WriteLine("12. Affichage valeur une dimension [" + i + "," + j + "," + k + "] : " + tableauAtroisDimensions[i, j, k]);
                    }
                }
            }

            // Tableaux de tableaux
            int[][] unTableauDeTableau = new int[][]
            {
                new int[] {1, 2, 3},
                new int[] {5, 6, 7, 8},
                new int[] {9, 10 },
            };

            for (int i = 0; i < unTableauDeTableau.Length; i++)
            {
                for (int j = 0; j < unTableauDeTableau[i].Length; j++)
                {
                    Console.WriteLine("13. Affichage valeur tableau en cascade [" + i + "][" + j + "] : " + unTableauDeTableau[i][j]);
                }
            }

            // Une autre façon de parcourir : foreach
            foreach (var tableau in unTableauDeTableau)
            {
                foreach (var valTableau in tableau)
                {
                    Console.WriteLine("14. Affichage valeur tableau en cascade (foreach) " + valTableau);
                }
            }

            Console.ReadLine();
        }
    }
}
