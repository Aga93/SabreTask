using System.Collections.Generic;


namespace ProcessedInputText
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputText = InputSelector.GetInputText(args);

            List<string> processedText = Replacer.ReplaceText(inputText);

            OutputSelector.SelectOutputType(processedText);
        }
    }
}
