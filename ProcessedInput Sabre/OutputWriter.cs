using System;
using System.Collections.Generic;
using System.IO;

namespace ProcessedInputText
{
    class OutputWriter
    {
        public static void SaveTextToFile(List<string> text)
        {
            using (StreamWriter writeTextToFile = new StreamWriter("processedText.txt"))
            {
                foreach (string el in text)
                {
                    writeTextToFile.WriteLine(el);
                }
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
