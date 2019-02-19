using System;
using System.Collections.Generic;

namespace TextSummary
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "The quick brown fox jumps over the lazy dog.";
            Console.WriteLine(StringUtility.SummarizeText(sentence,25));
        }


    }
}
