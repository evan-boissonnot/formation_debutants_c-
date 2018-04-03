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
            Dictionary<ActionType, string> traduction = new Dictionary<ActionType, string>
            {
                { ActionType.askBirthday, "Demande de la date de naissance" },
                { ActionType.askName, "Demande du nom" },
                { ActionType.computeAverage10Number, "Moyenne des 10 chiffres" },
                { ActionType.computeSum10Number, "Saisie et somme des 10 chiffres" },
                { ActionType.displaymenu, "Affichage du menu" },
                { ActionType.exit, "Sortie du menu" },
                { ActionType.historic, "Affichage de l'historique" }
            };

            const int MAX_LIST = 10;
            ActionType type = ActionType.displaymenu;
            string name = string.Empty;
            DateTime birthDay = DateTime.Now;
            List<int> list = new List<int>();


            Dictionary<DateTime, ActionType> actionHistoryList = new Dictionary<DateTime, ActionType>();

            while(type != ActionType.exit)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Bonjour Humain, quel est votre choix ? ");
                string value = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;

                if (Enum.TryParse(value, out type))
                {
                    actionHistoryList.Add(DateTime.Now, type);
                    Console.WriteLine("Vous avez choisi " + type.ToString());
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Choix non pris en compte, veuillez réessayer");
                    type = ActionType.displaymenu;
                }

                switch (type)
                {
                    case ActionType.displaymenu:
                        {
                            Console.WriteLine("____________");
                            Console.WriteLine("MENU".PadLeft(5).PadRight(5));
                            Console.WriteLine("____________");

                            var names = Enum.GetNames(typeof(ActionType));
                            foreach (var key in names)
                            {
                                ActionType currentAction = (ActionType)Enum.Parse(typeof(ActionType), key);
                                string translate = traduction[currentAction]; 
                                Console.WriteLine(string.Format("{0} : {1}", (int)currentAction, translate));

                            }
                        }
                        break;
                    case ActionType.askName:
                        {
                            Console.WriteLine("Votre nom ?");
                            name = Console.ReadLine();
                            Console.WriteLine("Votre nom est : " + name);
                        }
                        break;
                    case ActionType.askBirthday:
                        {
                            bool validDate = false;

                            while (!validDate)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Votre date de naissance ?");
                                string birthdayValue = Console.ReadLine();
                                if (DateTime.TryParse(birthdayValue, out birthDay))
                                {
                                    validDate = true;
                                    Console.WriteLine(string.Format("Votre date de naissance est : {0:HH:mm:ss, le dd/MM/yyyy}", birthDay));
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Vous n'avez pas saisi une date, veuillez recommencer, s'il vous plaît.");
                                }
                            }
                        }
                        break;
                    case ActionType.computeSum10Number:
                        {
                            list.Clear();
                            

                            int i = 0;
                            while(i < MAX_LIST)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Chiffre " + i + " a ajouter dans la liste ?");

                                string valInput = Console.ReadLine();
                                int number;
                                if(int.TryParse(valInput, out number))
                                {
                                    i++;
                                    list.Add(number);
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Vous n'avez pas saisi un entier, veuillez recommencer, s'il vous plaît.");
                                }
                            }
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("La somme est de : " + list.Sum());
                        }
                        break;
                    case ActionType.computeAverage10Number:
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            if(list.Count == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Veuillez d'abord ajouter les nombres dans la liste, s'il vous plaît.");
                            }
                            else
                                Console.WriteLine("La moyenne est de : " + list.Average());
                        }
                        break;
                    case ActionType.historic:
                        {
                            foreach (var item in actionHistoryList)
                                Console.WriteLine(string.Format("{0} - Action : {1}", item.Key.ToString("dd/MM/yyyy HH:mm:ss"), item.Value));
                        }
                        break;
                    case ActionType.exit:
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Bye bye");
                        }
                        break;
                }

                
            }
        }
    }
}
