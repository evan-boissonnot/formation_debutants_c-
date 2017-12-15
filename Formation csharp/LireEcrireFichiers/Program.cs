using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LireEcrireFichiers
{
    class Program
    {
        static void Main(string[] args)
        {

            // pour montrer l'erreur
            // string chemin = @"..\..\test.txt";

            string chemin = @"..\..\..\..\test.txt";

            // Infos du fichier
            FileInfo info = new FileInfo(chemin);
            if(info.Exists)
            {
                Console.WriteLine("0. File : " + info.Extension + ", " + info.DirectoryName);

                DirectoryInfo directory = info.Directory;
                if(directory.Exists)
                {
                    foreach (var item in directory.GetFiles())
                    {
                        Console.WriteLine("0. Fichiers du répertoire : " + item.Name);
                    }
                }
            }           
            
            using (FileStream reader = new FileStream(chemin, FileMode.Open))
            {
                Console.WriteLine("Nom du fichier : " + reader.Name);

                if(reader.CanRead)
                {
                    byte[] buffer2 = new byte[reader.Length];

                    int index = 0;
                    int longueur = (int)reader.Length;
                    while (longueur > 0)
                    {
                        int nbOctetsLus = reader.Read(buffer2, index, longueur);

                        index += nbOctetsLus;
                        longueur = longueur - index;
                    }

                    Console.WriteLine("1. Contenu : " + Encoding.Default.GetString(buffer2));
                }
            }

            using (StreamReader reader = new StreamReader(chemin))
            {
                string contenu = reader.ReadToEnd();
                Console.WriteLine("2. Contenu : " + contenu);
            }

            byte[] buffer = null;
            using (MemoryStream stream = new MemoryStream())
            {
                string content = "Ceci est un test";

                buffer = Encoding.Default.GetBytes(content);

                stream.Write(buffer, 0, (int)buffer.Length);
                stream.Flush();
            }

            using (StreamWriter writer = new StreamWriter(chemin, true))
            {
                writer.WriteLine("Test2");
                // Pour montrer le cache d'écriture :  writer.Flush();
            }

            Console.Read();
        }
    }
}
