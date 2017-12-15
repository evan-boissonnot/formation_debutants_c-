using LesRobots;
using System;
using System.Collections.Generic;
using System.IO;
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

        string cheminLog = @"..\..\..\..\log.txt";

        static void Main(string[] args)
        {
            List<Robot> robots = new List<Robot>();

            Initialize(robots);
            LancerAttaques(robots);
        }

        static void LancerAttaques(List<Robot> robotList)
        {
            Random rand = new Random();

            while (robotList.Any(item => item.EstVivant))
            {
                var listVivants = robotList.Where(item => item.EstVivant).ToList();

                listVivants.ForEach(robot =>
                {
                    int x = rand.Next(1, MAX_X);
                    int y = rand.Next(1, MAX_Y);

                    try
                    {
                        robot.SeDeplacer(x, y);
                    }
                    catch (NonValidCoordoonneeException ex)
                    {
                        AjouterLog(ex.Message, ex.Robot);
                    }

                    foreach (var rob in listVivants.Where(item => item.Nom != robot.Nom && item.EstAuBonEndroit(robot))) // Le code peut être amélioré ici
                    {
                        robot.Attaquer(rob);
                        Thread.Sleep(100);
                    }
                });
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

        static void AjouterLog(string message, Robot robot)
        {
            using (StreamWriter writer = new StreamWriter(message, true))
            {
                writer.WriteLine(string.Format("[{0:dd/MM/yyyy HH:mm:ss}] > {1} / {2}", DateTime.Now, message, robot.Nom));
                writer.Flush();
            }
        }
    }
}
