﻿using System;
using System.Collections.Generic;
using System.IO;

namespace ProcessedInputText
{
    class InputSelector
    {
        public static List<string> GetInputText(string[] parameter)
        {
            List<string> inputText = new List<string>();
            Console.WriteLine("Use following format to read - x:y:z");
            Console.WriteLine("x - put 1 to read from file, 2 to read from console");
            Console.WriteLine("y - optional, number of first line to operate on.");
            Console.WriteLine("z - optional, number of lines to use.");
            string[] userInput = Console.ReadLine().Split(':');

            if (userInput.Length == 1 && userInput[0].Equals(string.Empty))
            {
                return GetInputText(parameter);
            }
            else if (userInput[0] == "1")
            {
                inputText = InputReader.ReadTextFromFile(parameter);
            }
            else if (userInput[0] == "2")
            {
                inputText = InputReader.ReadTextFromConsole();
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
    }
}
