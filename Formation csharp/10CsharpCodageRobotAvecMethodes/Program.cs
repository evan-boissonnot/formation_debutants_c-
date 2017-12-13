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

            Console.ReadLine();
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



    }
}
