using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R2D2prendVie
{
    class Program
    {
        static void Main(string[] args)
        {
            // Liste des types primitifs => sans initialisation, avec valeur, Type value
            ListeTypesPrimitifs();

            Console.ReadLine();
        }

        static void ListeTypesPrimitifs()
        {
            bool jeSuisUnBoolean = true;
            Console.WriteLine("boolean : " + jeSuisUnBoolean);

            byte jeSuisUnByte = 0;
            Console.WriteLine("boolean : " + jeSuisUnByte);

            int jeSuisUnEntier = 0;
            Console.WriteLine("entier : " + jeSuisUnEntier);

            char jeSuisUnCaractere = 'r';
            Console.WriteLine("caractere : " + jeSuisUnCaractere);

            double jeSuisUnDouble = 1;
            Console.WriteLine("double : " + jeSuisUnDouble);

            float jeSuisUnDecimal = 2;
            Console.WriteLine("decimal : " + jeSuisUnDecimal);

            DateTime date = DateTime.Now;
            Console.WriteLine("date : " + date);
        }
    }
}
