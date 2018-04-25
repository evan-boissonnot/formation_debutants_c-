using LesRobots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LattaqueDesClones
{
    class Program
    {
        const int MAX_X = 50;
        const int MAX_Y = 50;

        static void Main(string[] args)
        {
            List<LesRobots.Robot> robots = new List<LesRobots.Robot>();

            Initialize(robots);
            LancerAttaques(robots);
        }

        static void LancerAttaques(List<LesRobots.Robot> robotList)
        {
            Random rand = new Random();

            while (robotList.Count(item => item.EstVivant) > 1)
            {
                foreach(var robot in robotList)
                { 
                    int x = rand.Next(1, MAX_X);
                    int y = rand.Next(1, MAX_Y);

                    robot.SeDeplacer(x, y);

                    foreach (var rob in robotList) // Le code peut être amélioré ici
                    {
                        if (robot.Nom != rob.Nom && robot.EstAuBonEndroit(rob))
                        {
                            robot.Attaquer(rob);
                        }
                        Thread.Sleep(100);
                    }
                };
                AfficherRobots(robotList);
                Thread.Sleep(1000);
            }
        }

        static void AfficherRobots(List<LesRobots.Robot> robotList)
        {
            Console.WriteLine("________________");

            for (int i = 1; i < MAX_X; i++)
            {
                string line = string.Empty;
                for (int j = 1; j < MAX_Y; j++)
                {
                    string value = " ";

                    Robot robot = robotList.FirstOrDefault(item => item.EstAuBonEndroit(i, j));
                    if (robot != null)
                        value = robot.EstVivant ? "O" : "X";

                    line += value;
                }
                Console.WriteLine(line);
            }
        }

        static void Initialize(List<LesRobots.Robot> robotList)
        {
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                int typeValue = rand.Next(1, 3);
                TypeRobot type = (TypeRobot)typeValue;

                Robot robot = null;

                switch (type)
                {
                    case TypeRobot.Droide:
                        robot = new Droide("droide : " + i, 1, 1, "fusil");
                        break;
                    case TypeRobot.R2D:
                        robot = new R2D("r2d : " + i, 1, 1);
                        break;
                }

                robotList.Add(robot);
            }
        }
    }
}
