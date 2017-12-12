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
            JeSaisAdditionnerDeuxValeurs(1, 2); // Quelle valeur est affichée ici ?

            // Comment alors récupérer le résultat de l'addition
            int retour = 0;
            JeSaisAdditionnerDeuxValeursAvecUnRetour1(1, 2, retour);
            Console.WriteLine("3 La valeur retour de l'addition vaut : " + retour);

            // Ref permet de passer une référence vers cette variable => les variables dans les méthodes sont en fait des copies des valeurs
            JeSaisAdditionnerDeuxValeursAvecUnRetourRef(1, 2, ref retour);
            Console.WriteLine("4 ref La valeur retour de l'addition vaut : " + retour);

            JeSaisAdditionnerDeuxValeursAvecUnRetourOut(1, 2, out retour);
            Console.WriteLine("5 out La valeur retour de l'addition vaut : " + retour);
            // Quelle est alors la différence entre out et ref ?

            int retour2;
            JeSaisAdditionnerDeuxValeursAvecUnRetourOut(1, 2, out retour2);
            Console.WriteLine("6 out La valeur retour de l'addition vaut : " + retour2);

            int retour3;
            // JeSaisAdditionnerDeuxValeursAvecUnRetourRef(1, 2, ref retour3); // ne fonctionne pas car : Erreur	CS0165	Utilisation d'une variable locale non assignée 'retour3'
            // Console.WriteLine("7 ref La valeur retour de l'addition vaut : " + retour3);
            // ref demande une variable déjà initialisée auparavant

            int retour4 = JeSaisAdditionnerDeuxValeursAvecUnRetour(1, 2);
            Console.WriteLine("8 fonction La valeur retour de l'addition vaut : " + retour4);


            // Et string alors ? 
            string nouveauMessage = "Un message pour Leïa";
            JeParleAvecUnMessageEtJeReponds(nouveauMessage);
            Console.WriteLine("9 Le message reçu est : " + nouveauMessage);

            Boolean estPrimitive = typeof(string).IsPrimitive;
            Console.WriteLine("String est primitif ?" + estPrimitive);

            // mais transmet bien une copie dans la méthode

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
    }
}
