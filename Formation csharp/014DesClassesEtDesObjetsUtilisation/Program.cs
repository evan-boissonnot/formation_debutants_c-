using LesRobots;
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
            Robot robot = new Robot("Robot 1");
            // affichage tout string() par défaut de Object :
            Console.WriteLine("Robot " + robot.Nom + ", tostring => " + robot);

            Droide droide = new Droide("Droide1", 1, 2, "arme1"); // ici, on n'a qu'un constructeur disponible
            Console.WriteLine("Robot " + droide.Nom + ", tostring => " + droide);

            droide.AfficherPositionnement(); // hérite des attributs du parent, des méthodes du parent
            droide.SeDeplacer(1, 2); // comment faire pour se déplacer plus vite ? => surcharge de la méthode
            droide.AfficherPositionnement();

            // encapsulation
            Robot robot2 = droide; // ça fonctionne ?
            // oui, car classe parente
            // cependant : 
            // robot2.Arme => arme n'est pas visible

            // On peut par contre faire : 
            List<Robot> robots = new List<Robot>()
            {
                new Robot("robot1"),
                new Robot("robot2"),
                new Droide("droide1", 2, 3, "unearme1"),
                new Droide("droide2", 20, 30, "unearme2")
            };

            while (true)
            {
                robots.ForEach(rob =>
                {
                    Random rand = new Random();

                    rob.SeDeplacer(rand.Next(0, 100), rand.Next(0, 100));
                    rob.AfficherPositionnement();
                    Thread.Sleep(300);
                });
            }

            Console.ReadLine();
        }
    }
}
