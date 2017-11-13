using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessedInputText
{
    class InputTextReader
    {
        public static string[] parameter;

        public static List<string> GetInputText()
        {
            List<string> inputText = new List<string>();
            Console.WriteLine("Use following format to read - x:y:z");
            Console.WriteLine("x - put 1 to read from file, 2 to read from console");
            Console.WriteLine("y - optional, number of first line to operate on.");
            Console.WriteLine("z - optional, number of lines to use.");
            string[] userInput = Console.ReadLine().Split(':');

            if (userInput.Length == 0)
            {
               userInput.DefaultIfEmpty();  //return null;
            }
            else if (userInput[0] == "1")
            {
                inputText = ReadTextFromFile();
            }
            else if (userInput[0] == "2")
            {
                inputText = ReadTextFromConsole();
            }

            if (userInput.Length == 1)
            {
                return inputText;
            }
            else if (userInput.Length == 3 && userInput[1] != null && userInput[2] != null)
            {
                return inputText.GetRange(int.Parse(userInput[1]), int.Parse(userInput[2]));
            }
            return null;
        }
        public static List<string> ReadTextFromFile()
        {
            List<string> textFromFile = new List<string>();
            //Console.WriteLine("Write Path to file.");
            using (StreamReader fileWithTextToProcessed = new StreamReader(parameter[0]/*"C:/Users/Aga/Desktop/Pan_Tadeusz.txt"/*Console.ReadLine()*/))
            {
                string singleLineFromText;
                while ((singleLineFromText = fileWithTextToProcessed.ReadLine()) != null)
                {
                    textFromFile.Add(singleLineFromText);
                }
            };
            return textFromFile;
        }

        public static List<string> ReadTextFromConsole()
        {
            List<string> textFromConsole = new List<string>();
            Console.WriteLine("Enter your input text. If you want to finish - write 'end' in new line and press Enter.");
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
                textFromConsole.Add(line);
            }
            return textFromConsole;
        }
    }
}
