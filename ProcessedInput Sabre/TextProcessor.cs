using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessedInputText
{
    class TextProcessor
    {
        public static List<string> ReplaceText(List<string> inputText)
        {
            Console.WriteLine("Enter word to replace");
            string oldTextValue = Console.ReadLine();
            Console.WriteLine("Enter new text");
            string newTextValue = Console.ReadLine();

            List<string> outputText = new List<string>();
            foreach (string line in inputText)
            {
                if (line != null && line.Length > 0)
                {
                    outputText.Add(line.Replace(oldTextValue, newTextValue));
                }
                else
                {
                    continue;
                }
            }
            return outputText;
        }
    }
}
