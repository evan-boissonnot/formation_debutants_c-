using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15ApprendreEtComprendreExceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            int val1 = 10;
            int val2 = 0;

            // 1. int result = val1 / val2;

            try
            {
                int result = val1 / val2;
            }
            catch
            {
                Console.WriteLine("Il existe une erreur");
            }

            try
            {
                int result = val1 / val2;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Il existe une erreur : " + ex.Message);
            }

            try
            {
                int result = val1 / val2;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Il existe une erreur : " + ex.Message);
            }
            finally
            {
                Console.WriteLine("A. Passons ici quelque soit le code // Utile pour libérer les accès, fermer des fichiers, ....");
            }

            // Du plus spécifique au moins spécifique
            try
            {
                int result = val1 / val2;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Il existe une erreur spécifique : " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Traitement des autres erreurs : " + ex.Message);
            }
            finally
            {
                Console.WriteLine("A. Passons ici quelque soit le code // Utile pour libérer les accès, fermer des fichiers, ....");
            }

            // A montrer : ça ne peut fonctionner, car Exception englobe toutes les autres
            //try
            //{
            //    int result = val1 / val2;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Traitement des autres erreurs : " + ex.Message);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Il existe une erreur spécifique : " + ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("A. Passons ici quelque soit le code // Utile pour libérer les accès, fermer des fichiers, ....");
            //}

            try
            {
                int result = val1 * val2;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Il existe une erreur : " + ex.Message);
            }
            finally
            {
                Console.WriteLine("B. Passons ici quelque soit le code // Utile pour libérer les accès, fermer des fichiers, ....");
            }

            // Pour lancer une exception
            //throw new MonExceptionTypee();

            try
            {
                throw new MonExceptionTypee2("test");
            }
            catch(MonExceptionTypee2 ex)
            {
                Console.WriteLine("Une erreur typée est reçu, " + ex.Message);
            }


            Console.ReadLine();
        }
    }
}
