using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace R2D2pret
{
    class Program
    {
        static void Main(string[] args)
        {

            /// Arraylist

            System.Collections.ArrayList list = new System.Collections.ArrayList();

            list.Add(1);
            list.Add("test");
            list.Add(DateTime.Now);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("1. ArrayList[" + i + "] = " + list[i]);
            }

            foreach (var item in list)
            {
                Console.WriteLine("2. ArrayList " + item);
            }

            list.Insert(1, 1.5M);

            foreach (var item in list)
            {
                Console.WriteLine("3. ArrayList " + item);
            }

            /// List
            List<int> listInt = new List<int>(1);
            listInt.Add(1);
            listInt.Add(2);

            List<int> listInt2 = new List<int>(1);
            listInt2.Add(10);
            listInt2.Add(20);

            

            foreach (var item in listInt)
            {
                Console.WriteLine("4. List<int> " + item);
            }

            foreach (var item in listInt2)
            {
                Console.WriteLine("5. List<int> " + item);
            }

            Dictionary<string, int> dico = new Dictionary<string, int>()
            {
                { "clef1", 1 },
                { "clef2", 2 },
            };

            foreach (var item in dico)
            {
                Console.WriteLine("6. dico " + item);
                Console.WriteLine("6. dico.Key " + item.Key);
                Console.WriteLine("6. dico.Value " + item.Value);
            }

            foreach (var key in dico.Keys)
            {
                Console.WriteLine("7. dico(key) " + key);
                Console.WriteLine("7. dico[key] " + dico[key]);
            }

            Console.ReadLine();
        }
    }
}
