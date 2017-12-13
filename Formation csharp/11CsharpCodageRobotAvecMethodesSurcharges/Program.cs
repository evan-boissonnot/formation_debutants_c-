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
            Courir(20);

            Voler(1, 20);
            // Comment faire pour passer autant de paramètres que l'on souhaite ?
            Voler(1, 2, 3, 4, 5, 6, 10);

            Console.ReadLine();
        }

        ///// <summary>
        ///// 1 Méthode pour faire courir le robot
        ///// </summary>
        //static void Courir()
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine("Je me déplace de " + i + "km");
        //    }
        //}

        /// <summary>
        /// 2, apres amélioration, Méthode pour faire courir le robot
        /// </summary>
        static void Courir()
        {
            Courir(10);
        }

        /// <summary>
        /// Méthode pour faire courir le robot, surcharge de la première
        /// > La première a le presque le même code, non ?
        /// </summary>
        static void Courir(int nbKms)
        {
            for (int i = 0; i < nbKms; i++)
            {
                Console.WriteLine("Je me déplace de " + i + "km");
            }
        }

        static void Voler(int pointA, int pointB)
        {
            Console.WriteLine("Je vole du point " + pointA + ", au point " + pointB);
        }

        static void Voler(params int[] destinations)
        {
            for (int i = 0; i < destinations.Length; i++)
            {
                Console.WriteLine("Je pars à cette destination : " + destinations[i]);
            }
        }
    }
}
