using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _012DesClassesEtDesObjets
{
    class Program
    {
        static void Main(string[] args)
        {
            MonRobot robot = new MonRobot("c3po");
            MonRobot robot2 = new MonRobot("crp1", 10);
            MonRobot robot3 = new MonRobot("r2d2", 10, 20);
            

            /// Pour expliquer les pointeurs vers objet
            MonRobot robot5 = robot;

            // Il manque les coordonnées de base
            MonRobot robot4 = new MonRobot("yoda", 10, 20, 1, 2);

            robot4.SeDeplacer(1, 2);


            robot.SeDeplacer(1, 1);
            robot.AfficherPositionnement();
            robot5.AfficherPositionnement(); // c'est le même robot en fait

            List<MonRobot> robotList = new List<MonRobot>();

            for (int i = 0; i < 10; i++)
            {
                Tuple<int, int> coordonnees = RetourneNouvellesCoordonnees();

                robotList.Add(new MonRobot("nom " + i, 10, 20, coordonnees.Item1, coordonnees.Item2)
                {
                    Taille = 10
                });
            }

            int j = 0;
            while(true)
            {
                robotList.ForEach(item =>
                {
                    Tuple<int, int> coordonnees = RetourneNouvellesCoordonnees();

                    item.SeDeplacer(coordonnees.Item1, coordonnees.Item2);

                    Thread.Sleep(100);
                });

                j++;
                if (j % 2 == 0)
                    robotList.ForEach(item => Reinitialiser(item));
            }

            Console.ReadLine();
        }

        static void Reinitialiser(MonRobot robot) // Copie de la référence, pas des valeurs
        {
            robot.SeDeplacer(0, 0);
        }

        static Tuple<int, int> RetourneNouvellesCoordonnees()
        {
            Random rand = new Random();

            int coordX = rand.Next(0, 100);
            int coordY = rand.Next(0, 100);

            return new Tuple<int, int>(coordX, coordY);
        }
    }
}
