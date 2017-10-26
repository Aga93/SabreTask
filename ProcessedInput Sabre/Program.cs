using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProcessedInputText
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputText = InputTextReader.GetInputText();

            List<string> processedText = TextProcessor.ReplaceText(inputText);

            OutputWriter.SelectOutputType(processedText);
        }
    }
}
