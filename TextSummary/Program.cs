using System;

namespace TextSummary
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "The QUICK brown fox jumps over the lazy dog.";
            Console.WriteLine(StringUtility.SummarizeText(sentence,25));
            Console.WriteLine(StringUtility.PascalCase(sentence));

        }


    }
}
