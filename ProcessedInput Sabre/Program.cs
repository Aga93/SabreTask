using System.Collections.Generic;


namespace ProcessedInputText
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputText = InputTextReader.GetInputText(args);

            List<string> processedText = Replacer.ReplaceText(inputText);

            OutputWriter.SelectOutputType(processedText);
        }
    }
}
