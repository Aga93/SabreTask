using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessedInputText
{
    class OutputWriter
    {

        public static void SelectOutputType(List<string> text)
        {
            Console.WriteLine("Enter 1 to write to file, Enter 2 to write to console");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                SaveTextToFile(text);

            }
            else if (userInput == "2")
            {
                PrintToConsole(text);
            }
        }

        public static void SaveTextToFile(List<string> text)
        {
            using (StreamWriter writeTextToFile = new StreamWriter("processedText.txt"))
            {
                foreach (string el in text)
                {
                    writeTextToFile.WriteLine(el);
                }
                writeTextToFile.Close();
            }
        }

        public static void PrintToConsole(List<string> text)
        {
            foreach (string line in text)
            {
                Console.WriteLine(line);
            }
        }
    }
}
