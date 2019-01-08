using Epam.Task6.Entities;
using Epam.Task6.Logic;
using Epam.Task6.LogicContracts;
using System;
using System.Collections.Generic;

namespace Epam.Task6.PL
{
    public class Program
    {
        private static ILogic logic;

        public static void Main(string[] args)
        {
            logic = new CommonLogic();
            while (true)
            {
                ShowMenu();
                string input = ReadMenuChoise();
                switch (input)
                {
                    case "1":
                        ShowAllUsers();
                        break;
                    case "2":
                        AddNewUser();
                        break;
                    case "3":
                        RemoveUser();
                        break;
                    case "4":
                        AwardUser();
                        break;
                    case "5":
                        ShowAllAwards();
                        break;
                    case "6":
                        AddNewAward();
                        break;
                    case "7":
                        RemoveAward();
                        break;
                    case "-1":
                    case "0":
                    case "8":
                        return;
                    default: break;
                }
            }
        }

        public static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Please, choose the action:");
            Console.WriteLine("1 - show all users");
            Console.WriteLine("2 - add new user");
            Console.WriteLine("3 - remove user");
            Console.WriteLine("4 - award user");
            Console.WriteLine("5 - show all awards");
            Console.WriteLine("6 - add new award");
            Console.WriteLine("7 - remove award");
            Console.WriteLine("8 - exit");
            Console.WriteLine("Enter your choise: ");
        }

        public static string ReadMenuChoise()
        {
            return Console.ReadLine();
        }

        public static void ShowAllUsers()
        {
            IEnumerable<User> users = logic.GetAllUsers();
            foreach (var user in users)
            {
                ShowUser(user);
            }
            PressAnyKey();
        }

        public static void ShowUser(User user)
        {
            Console.Write($"{user.Id}. {user.Name}, {user.Age} years-old. Was born {user.DateOfBirth.ToString("dd.MM.yyyy")}" +
                              $"{Environment.NewLine}Awards: ");
            if (user.Awards.Count > 0)
            {
                foreach (var a in user.Awards)
                {
                    Console.WriteLine($"{a.Id}. {a.Title}");
                }
            }
            else
            {
                Console.WriteLine("No awards");
            }
        }

        public static void AddNewUser()
        {
            Console.WriteLine("Enter the name of user: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter the day of birth: ");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the month of birth: ");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the year of birth: ");
            int year = int.Parse(Console.ReadLine());

            DateTime userDateOfBirth = new DateTime(year, month, day);

            if (logic.AddUser(userName, userDateOfBirth))
            {
                Console.WriteLine("User was successfully added!");
            }
            else
            {
                Console.WriteLine("User addition error!");
            }
            PressAnyKey();
        }

        private static void PressAnyKey()
        {
            Console.WriteLine("Press any key to back to menu . . .");
            Console.ReadKey();
        }

        public static void RemoveUser()
        {
            Console.WriteLine("Enter the ID of user to remove: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int id))
            {
                if (logic.RemoveUser(id))
                {
                    Console.WriteLine("User was succesfully removed!");
                }
                else
                {
                    Console.WriteLine("User removing error: cannot remove a user");
                }
            }
            else
            {
                Console.WriteLine("Incorrect user ID!");
            }
            PressAnyKey();
        }

        /////////////
        
        public static void AwardUser()
        {
            Console.WriteLine("Enter the ID of award: ");
            string awardId = Console.ReadLine();
            Console.WriteLine("Enter the ID of user to award: ");
            string userId = Console.ReadLine();

            if (int.TryParse(awardId, out int awardid))
            {
                if (int.TryParse(userId, out int userid))
                {
                    if (logic.Award(awardid, userid))
                    {
                        Console.WriteLine("User was successfully awarded!");
                    }
                    else
                    {
                        Console.WriteLine("User awarding error: cannot award a user");
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect user ID!");
                } 
            }
            else
            {
                Console.WriteLine("Incorrect award ID!");
            }
            PressAnyKey();
        }
         //////////////////
         
        public static void ShowAllAwards()
        {
            IEnumerable<Award> awards = logic.GetAllAwards();
            foreach (var award in awards)
            {
                ShowAward(award);
            }
            PressAnyKey();
        }

        public static void ShowAward(Award award)
        {
            Console.WriteLine($"{award.Id}. {award.Title}");
        }

        public static void AddNewAward()
        {
            Console.WriteLine("Enter the name of award: ");
            string awardTitle = Console.ReadLine();

            if (logic.AddAward(awardTitle))
            {
                Console.WriteLine("Award was successfully added!");
            }
            else
            {
                Console.WriteLine("Award addition error!");
            }
            PressAnyKey();
        }

        public static void RemoveAward()
        {
            Console.WriteLine("Enter the ID of award to remove: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int id))
            {
                if (logic.RemoveAward(id))
                {
                    Console.WriteLine("Award was succesfully removed!");
                }
                else
                {
                    Console.WriteLine("Award removing error: cannot remove an award");
                }
            }
            else
            {
                Console.WriteLine("Incorrect award ID!");
            }
            PressAnyKey();
        }
    }
}
    