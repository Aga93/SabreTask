using System;
using System.Collections.Generic;
using System.IO;

namespace ProcessedInputText
{
    class GetTextToProcessed
    {
        public static List<string> ReadTextFromFile(string[] parameter)
        {
            List<string> textFromFile = new List<string>();


            using (StreamReader fileWithTextToProcessed = new StreamReader(parameter[0]))
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
