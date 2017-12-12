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
            JeParle();



            Console.ReadLine();
        }

        static void JeParle()
        {
            Console.WriteLine("Je m'appelle R2D2");
        }

        static void JeParleAvecUnMessage(string message)
        {
            Console.WriteLine("Je m'appelle R2D2, " + message);
        }

        static void JeParleAvecUnMessageEtJeReponds(string message)
        {
            Console.WriteLine("Je m'appelle R2D2, " + message);
            message = "Bien reçu";
        }

        static void JeParleAvecUnMessageFormate(string message)
        {
            Console.WriteLine(string.Format("Je m'appelle R2D2, {0}", message));
        }

        static void JeSaisAdditionnerDeuxValeurs(int valeur1, int valeur2)
        {
            int valeur3 = valeur1 + valeur2;
            Console.WriteLine(string.Format("Le montant de l'addition vaut {0}", valeur3));
        }

        static void JeSaisAdditionnerDeuxValeursAvecUnRetour1(int valeur1, int valeur2, int retour)
        {
            retour = valeur1 + valeur2;
            Console.WriteLine(string.Format("Le montant de l'addition vaut {0}", retour));
        }

        static void JeSaisAdditionnerDeuxValeursAvecUnRetourRef(int valeur1, int valeur2, ref int retour)
        {
            retour = valeur1 + valeur2;
            Console.WriteLine(string.Format("Le montant de l'addition vaut {0}", retour));
        }

        static void JeSaisAdditionnerDeuxValeursAvecUnRetourOut(int valeur1, int valeur2, out int retour)
        {
            retour = valeur1 + valeur2;
            Console.WriteLine(string.Format("Le montant de l'addition vaut {0}", retour));
        }

        static int JeSaisAdditionnerDeuxValeursAvecUnRetour(int valeur1, int valeur2)
        {
            return valeur1 + valeur2;            
        }

        // Compléter cette méthode
        static void JeSaisMultiplier(double valeur1, double valeur2, double retour)
        {
            retour = valeur1 * valeur2;
        }

        static double JeSaisMultiplierEtRenvoyer(double valeur1, double valeur2)
        {
            return valeur1 * valeur2;
        }
    }
}
