using System;

namespace ProcessedInputText
{
    class GetWordForReplacer 
    {
        public static string OldTextValue()
        {
            Console.WriteLine("Enter word to replace");
            string oldTextValue = Console.ReadLine();

            return oldTextValue;
        }

        public static string NewTextValue()
        {
            Console.WriteLine("Enter new text");
            string newTextValue = Console.ReadLine();

            return newTextValue;
        }

    }
}
