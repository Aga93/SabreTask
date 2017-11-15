using System;
using System.Collections.Generic;


namespace ProcessedInputText
{
    class OutputSelector
    {
        public static void SelectOutputType(List<string> text)
        {
            Console.WriteLine("Enter 1 to write to file, Enter 2 to write to console");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                OutputWriter.SaveTextToFile(text);
            }
            else if (userInput == "2")
            {
                OutputWriter.PrintToConsole(text);
            }
        }
    }
}
