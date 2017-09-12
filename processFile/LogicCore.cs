using System;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;

namespace processFile
{
    public class LogicCore
    {
        string fileName = "file.txt";
        string fullPathToFile = null;
        internal bool isFileRead = false;
        internal bool ifFileProcessed = false;
        private string[] linesInDocument = null;

        public void StartTheProgram()
        {
            GetPathToTheFile();
            ConsoleMenu consoleMenu = new ConsoleMenu();
            consoleMenu.SelectApplication();
        }

        public void LogicReadFile(string pathToFile)
        {
            linesInDocument = File.ReadAllLines(pathToFile);
            isFileRead = true;

            Console.WriteLine("\nFile is read.");
            System.Threading.Thread.Sleep(900);
        }

        public void LogicReplaceSymbols()
        {
            foreach (string line in linesInDocument)
            {
                string updatedLine = null;
                foreach (char c in line)
                {
                    if (Char.IsLower(c))
                    {
                        updatedLine = updatedLine + Char.ToUpper(c);
                    }
                    else if (Char.IsUpper(c))
                    {
                        updatedLine = updatedLine + Char.ToLower(c);
                    }
                    else
                    {
                        updatedLine = updatedLine + c;
                    }
                }
                //string lineReplacedSymbols = Regex.Replace(line, @"\B\p{Lu}", m => m.ToString().ToLower());
            }
        }

        public string GetPathToTheFile()
        {
            string startupPath = Environment.CurrentDirectory;
            fullPathToFile = Path.Combine(startupPath, fileName);
            return fullPathToFile;
        }
    }
}