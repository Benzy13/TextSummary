using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;


namespace TextSummary
{
    public class StringUtility
    {
        //--------------------------------
        public static string SummarizeText(string text, int maxLength = 30)
        {
            if (text.Length < maxLength)
                return text;

            string[] words = text.Split(' ');
            int totalChars = 0;
            List<string> summaryWords = new List<string>();

            foreach (var word in words)
            {
                totalChars += word.Length + 1;
                summaryWords.Add(word);
                if (totalChars > maxLength)
                    break;
            }
            return String.Join(" ", summaryWords) + "...";
        }
        //--------------------------------
        public static string PascalCase(string text)
        {
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            string[] words = text.Split(' ');
            List<string> pascalWords = new List<string>();

            foreach (var word in words)
            {
                pascalWords.Add(textInfo.ToTitleCase(word.ToLower()));
            }
            return String.Join("", pascalWords);
        }
    }
}
