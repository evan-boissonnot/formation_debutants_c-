using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCodageRobot2
{
    class Program
    {
        const int MAX_LIST = 10;

        static void Main(string[] args)
        {            
            ActionType type = ActionType.displaymenu;

            LancerMoteur(type);
        }

        static void LancerMoteur(ActionType type) 
        {
            string name = string.Empty;
            DateTime birthDay = DateTime.Now;
            List<int> list = new List<int>();
            Dictionary<DateTime, ActionType> actionHistoryList = new Dictionary<DateTime, ActionType>();

            while (type != ActionType.exit)
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
                            DisplaymMenu();
                        }
                        break;
                    case ActionType.askName:
                        {
                            AskName(ref name);
                        }
                        break;
                    case ActionType.askBirthday:
                        {
                            AskBirthday(ref birthDay);
                        }
                        break;
                    case ActionType.computeSum10Number:
                        {
                            ComputeSum10Number(list);
                        }
                        break;
                    case ActionType.computeAverage10Number:
                        {
                            ComputeAverage10Number(list);
                        }
                        break;
                    case ActionType.historic:
                        {
                            DisplayActionHistorics(actionHistoryList);
                        }
                        break;
                    case ActionType.exit:
                        {
                            Exit();
                        }
                        break;
                }
            }
        }

        static void Exit()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Bye bye");
        }

        static void DisplayActionHistorics(Dictionary<DateTime, ActionType> actionHistoryList)
        {
            foreach (var item in actionHistoryList)
                Console.WriteLine(string.Format("{0} - Action : {1}", item.Key.ToString("dd/MM/yyyy HH:mm:ss"), item.Value));
        }

        static void ComputeAverage10Number(List<int> list)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (list.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Veuillez d'abord ajouter les nombres dans la liste, s'il vous plaît.");
            }
            else
                Console.WriteLine("La moyenne est de : " + list.Average());
        }

        static void ComputeSum10Number(List<int> list)
        {
            list.Clear();
            int i = 0;
            while (i < MAX_LIST)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Chiffre " + i + " a ajouter dans la liste ?");

                string valInput = Console.ReadLine();
                int number;
                if (int.TryParse(valInput, out number))
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

        static void AskBirthday(ref DateTime birthDay)
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
                    Console.WriteLine(string.Format("Votre date de naissance est : {0:dd/MM/yyyy}", birthDay));
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Vous n'avez pas saisi une date, veuillez recommencer, s'il vous plaît.");
                }
            }
        }

        static void DisplaymMenu()
        {
            Console.WriteLine("____________");
            Console.WriteLine("MENU".PadLeft(5).PadRight(5));
            Console.WriteLine("____________");

            var names = Enum.GetNames(typeof(ActionType));
            foreach (var key in names)
                Console.WriteLine(string.Format("{0} : {1}", (int)Enum.Parse(typeof(ActionType), key), key));
        }

        static void AskName(ref string name)
        {
            Console.WriteLine("Votre nom ?");
            name = Console.ReadLine();
            Console.WriteLine("Votre nom est : " + name);
        }
    }
}
