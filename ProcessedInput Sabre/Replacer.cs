using System.Collections.Generic;

namespace ProcessedInputText
{
    class Replacer 
    {
        
        public static List<string> ReplaceText(List<string> inputText)
        {
            string oldValue = GetValueForReplacer.OldTextValue();
            string newValue = GetValueForReplacer.NewTextValue();
            List<string> outputText = new List<string>();
            if(inputText == null)
            {
                return new List<string>();
            }
            foreach (string line in inputText)
            {
                if (line != null && line.Length > 0)
                {
                    outputText.Add(line.Replace(oldValue,newValue));
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
