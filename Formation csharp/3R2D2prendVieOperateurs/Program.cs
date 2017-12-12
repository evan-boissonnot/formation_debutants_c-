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
            JeParleAvecUnMessage("1 Je suis un robot");
            JeParleAvecUnMessageFormate("2 Je suis un robot");

            int retour3 = JeSaisAdditionnerDeuxValeursAvecUnRetour(1, 2);
            Console.WriteLine("3 fonction La valeur retour de l'addition vaut : " + retour3);

            double retour4 = JeSaisMultiplierEtRenvoyer(2, 3);
            Console.WriteLine("4 fonction La valeur de la multiplication vaut : " + retour4);

            // Comment récupérer la valeur qui est en fait un entier
            //int retour5 = JeSaisMultiplierEtRenvoyer(2, 3); // manque une conversion => qu'est-ce ?

            int retour6 = (int)JeSaisMultiplierEtRenvoyer(2, 3);
            Console.WriteLine("6 fonction La valeur de la multiplication vaut : " + retour6);

            // Quid si l'on multiplie de vraies décimaux ?

            // Avant tout, zoom sur float, double, decimal
            // ici c'est un entier en fait, transtyppé
            float floatValue = 1 / 3;
            double doubleValue = 1 / 3;
            decimal decimalValue = 1 / 3;
            Console.WriteLine("float: {0} double: {1} decimal: {2}", floatValue, doubleValue, decimalValue);

            floatValue = 1F / 3;
            doubleValue = 1D / 3;
            decimalValue = 1M / 3;
            Console.WriteLine("float: {0} double: {1} decimal: {2}", floatValue, doubleValue, decimalValue);

            // Quid alors si l'on récupère une valeur int de deux décimaux ?
            //int retour7 = 1.5F * 1.6F; => ne fonctionne pas
            Console.WriteLine("7 fonction La valeur de la multiplication vaut : " + (1.5F * 1.6F));

            int retour8 = (int) (1.5F * 1.6F);
            Console.WriteLine("8 fonction La valeur de la multiplication vaut : " + retour8);

            decimal retour9 = retour8;
            Console.WriteLine("9 fonction La valeur de la multiplication vaut : " + retour9);
            // Transtypage implicite, car valeur autorisée plus grande, plus de digits

            double retour10 = retour8;
            Console.WriteLine("10 fonction La valeur de la multiplication vaut : " + retour10);
            float retour11 = retour8;
            Console.WriteLine("11 fonction La valeur de la multiplication vaut : " + retour11);
            // Transtypage implicite, car valeur autorisée plus grande, plus de digits

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
