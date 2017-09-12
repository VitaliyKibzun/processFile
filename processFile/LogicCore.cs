using System;
using System.Threading;
using System.IO;

namespace processFile
{
    public class LogicCore
    {
        string fileName = "file.txt";
        string fullPathToFile = null;

        public void StartTheProgram()
        {
            GetPathToTheFile();
            ConsoleMenu consoleMenu = new ConsoleMenu();
            consoleMenu.SelectApplication();

        }

        public void LogicReadFile(string pathToFile)
        {
            string[] lines = File.ReadAllLines(pathToFile);
            Console.WriteLine("\nFile is read.");
        }

        public void LogicReplaceSymbols()
        {

        }

        public string GetPathToTheFile()
        {
            string startupPath = Environment.CurrentDirectory;
            fullPathToFile = Path.Combine(startupPath, fileName);
            return fullPathToFile;
        }
    }
}