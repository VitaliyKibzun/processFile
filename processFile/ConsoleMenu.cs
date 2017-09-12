using System;

namespace processFile
{
    public class ConsoleMenu:LogicCore
    {
        private string pathToFile = "";
        string menuMenu = "Menu:";
        string menuReadFile = "Click 1 to read the File.txt";
        private bool allowedReadFile = false;
        string menuReplaceSymbolsInFile = "Click 2 to replace symbols in file";
        private bool allowedReplaceSymbolsInFile = false;
        string menuSaveFile = "Click 3 to save the file";
        private bool allowedSaveFile = false;
        string menuExit = "Click 0 to Exit";
        private bool allowedExit = false;
        string menuChoice = "Make your choice: ";
        private string menuConsole = "Select 1 to use Console application";
        private bool allowedConsole = false;
        private string menuWindowForm = "Select 2 to use Window form application";
        private bool allowedWinForm = false;
        private string menuWpfForm = "Select 3 to use WPF form applicaiton";
        private bool allowedWpf = false;
        private LogicCore consoleLogicCore;

        public void MenuExit()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            allowedExit = true; 
            Console.WriteLine(menuExit);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void MenuMenu()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(menuMenu);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public string MenuChoice()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(menuChoice);
            string choice = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            return choice;
        }

        private void MenuReadFile()
        {
            allowedReadFile = false;
            Console.ForegroundColor = ConsoleColor.Gray;
            if (!isFileRead)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                allowedReadFile = true;
            }
            Console.WriteLine(menuReadFile);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void StartConsoleProgram()
        {
            while (true)
            {
                ProcessSelectedAction(MenuListOfActions());
            }
        }

        public string MenuSelectApplicationType()
        {
            Console.Clear();
            MenuMenu();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(menuConsole);
            allowedConsole = true;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(menuWindowForm);
            Console.WriteLine(menuWpfForm);
            MenuExit();
            return MenuChoice();
        }

        public void SelectApplication()
        {
            ProcessSelectedApplicationType(MenuSelectApplicationType());

        }

        private void ProcessSelectedApplicationType(string menuItem)
        {
            switch (menuItem)
            {
                case "1":
                {
                    if (allowedConsole)
                    {
                        StartConsoleProgram();
                    }
                    else
                    {
                        ShowErrorMessage("Option is not available\n");
                    }
                    break;
                }
                case "2":
                {
                    if (allowedWinForm)
                    {
                        
                    }
                    else
                    {
                        ShowErrorMessage("Option is not available\n");
                        SelectApplication();
                    }
                    break;
                }
                case "3":

                    break;
                case "0":
                    if (allowedExit)
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        ShowErrorMessage("Option is not available\n");
                        SelectApplication();
                    }
                    break;
                default:
                {
                    ShowErrorMessage("Incorrect value\n");
                    SelectApplication();
                    break;
                }
            }
        }

        private void ShowErrorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Gray;
            System.Threading.Thread.Sleep(900);
        }

        private void ProcessSelectedAction(string menuItem)
        {
            switch (menuItem)
            {
                case "1":
                {
                    LogicReadFile(GetPathToTheFile());
                    break;
                }
                case "2":
                    LogicReplaceSymbols();
                    break;
                case "3":

                    break;
                case "0":
                    Environment.Exit(0);
                    break;

                default:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Incorrect value\n");
                        System.Threading.Thread.Sleep(500);
                        StartConsoleProgram();
                        break;
                    }
            }
        }

        private void MenuReplaceActionsInFile()
        {
            allowedReplaceSymbolsInFile = false;
            Console.ForegroundColor = ConsoleColor.Gray;
            if (isFileRead)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                allowedReplaceSymbolsInFile = true;
            }
            Console.WriteLine(menuReplaceSymbolsInFile);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private void MenuSaveFile()
        {
            allowedSaveFile = false;
            Console.ForegroundColor = ConsoleColor.Gray;
            if (isFileRead)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                allowedSaveFile = true;
            }
            Console.WriteLine(menuSaveFile);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private string MenuListOfActions()
        {
            Console.Clear();
            MenuMenu();
            MenuReadFile();
            MenuReplaceActionsInFile();
            MenuSaveFile();
            MenuExit();
            return MenuChoice();
        }
    }
}