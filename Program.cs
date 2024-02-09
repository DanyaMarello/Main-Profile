using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Тайм-код: 2:08:45

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userLogin = "admin";
            string userPassword = "admin";
            string mailUser = "adminmail";
            int tryPass = 3;
            string inputLM;
            string inputPassword;
            string action;
            Start(args);
            void Start(string[] start)
            {
                Console.WriteLine("Welcome to program!\n");
                Console.WriteLine("Please, pick action.\n1 - Login\n2 - Register");
                action = Console.ReadLine();
                switch (action)
                {
                    case "1":
                        Login(args);
                        break;
                    case "2":
                        Register(args);
                        break;
                    default:
                        Console.WriteLine("Undefined action\nPress any key to restart.");
                        Console.ReadKey();
                        Console.Clear();
                        Main(args);
                        break;
                }

                void Login(string[] login)
                {
                    Console.Write("Login/E-Mail: ");
                    inputLM = Console.ReadLine();
                    Console.Write("Password: ");
                    inputPassword = Console.ReadLine();
                    for (; inputLM != userLogin || inputLM != mailUser & inputPassword != userPassword;)
                    {
                        Console.WriteLine("Invalid login/password.");
                        tryPass -= 1;
                        Console.WriteLine("Attempts left: " + tryPass);
                        if (tryPass == 0)
                        {
                            Console.WriteLine("Fail login.");
                            Console.WriteLine("Press any key to exit.");
                            Console.ReadKey();
                            Main(args);
                        }
                        Login(args);
                    }
                    Console.WriteLine("Success!");
                    Console.Clear();
                    Menu(args);
                }
                void Register(string[] register)
                {
                    Console.Write("Please, input you login: ");
                    userLogin = Console.ReadLine();
                    Console.Write("Create password: ");
                    userPassword = Console.ReadLine();
                    Console.Write("Input you e-mail: ");
                    mailUser = Console.ReadLine();

                    Console.WriteLine("Registration complete!");
                    Console.WriteLine("Press any key to login...");
                    Console.ReadKey();
                    Login(args);
                }
                void Menu(string[] menu)
                {
                    Console.WriteLine($"Hello, {userLogin}! Welcome to main menu\nSelect next action:\n" +
                        $"1 - Profile\n" +
                        $"2 - Settings\n" +
                        $"3 - Logout");
                    action = Console.ReadLine();
                    switch (action)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("About you:\n\n" +
                                $"You login: {userLogin}\n" +
                                $"You E-Mail: {mailUser}\n\n" +
                                $"Press any key to back.");
                            Console.ReadKey();
                            Console.Clear();
                            Menu(menu);
                            break;
                        case "2":
                            Console.WriteLine("Settings\n\n" +
                                "1 - Change password\n" +
                                "2 - Change E-Mail\n" +
                                "3 - Change Login");
                            action = Console.ReadLine();
                            switch (action)
                            {
                                case "1":
                                    Console.Clear();
                                    Console.Write("Input you current password: ");
                                    inputPassword = Console.ReadLine();
                                    if (inputPassword == userPassword)
                                    {
                                        Console.Write("New password: ");
                                        userPassword = Console.ReadLine();
                                        Console.WriteLine("Press any key to back.");
                                        Console.ReadKey();
                                        Menu(menu);
                                    }
                                    else goto case "1";
                                    break;
                                case "2":
                                    Console.Clear();
                                    Console.Write("Input you current e-mail: ");
                                    inputLM = Console.ReadLine();
                                    if (inputLM == mailUser)
                                    {
                                        Console.Write("New E-Mail: ");
                                        mailUser = Console.ReadLine();
                                        Console.WriteLine("Press any key to back.");
                                        Console.ReadKey();
                                        Menu(menu);
                                    }
                                    else goto case "2";
                                    break;
                                case "3":
                                    Console.Clear();
                                    Console.Write("Input you current login: ");
                                    inputLM = Console.ReadLine();
                                    if (inputLM == userLogin)
                                    {
                                        Console.Write("New login: ");
                                        userLogin = Console.ReadLine();
                                        Console.WriteLine("Press any key to back.");
                                        Console.ReadKey();
                                        Menu(menu);
                                    }
                                    else goto case "3";
                                    break;
                                default:
                                    Console.WriteLine("Unknown action\nPress any key to back.");
                                    Console.ReadKey();
                                    Menu(menu);
                                    break;
                            }
                            break;
                        case "3":
                            Console.Clear();
                            Start(args);
                            break;
                        default:
                            Console.Write("\nUnknown command\nPress any key to back.");
                            Console.ReadKey();
                            Console.Clear();
                            Menu(menu);
                            break;
                    }
                }
            }
        }
    }
}




/*
            int playerHealth = 1000;
            int playerDamage = 5;
            int enemyHealth = 1500;
            int enemyDamage = 3;

            while (playerHealth > 0 && enemyHealth > 0)
            {
                playerHealth -= enemyDamage;
                enemyHealth -= playerDamage;

                Console.WriteLine(playerDamage + " игрок");
                Console.WriteLine(enemyHealth + " враг");
            }

            if(playerHealth <= 0 && enemyHealth <= 0) 
            {
                Console.WriteLine("Ничья.");
            }
            else if(enemyHealth <= 0)
            {
                Console.WriteLine("Победа игрока");
            }
            else if (playerHealth <= 0)
            {
                Console.WriteLine("Победа врага");
            }
            */
