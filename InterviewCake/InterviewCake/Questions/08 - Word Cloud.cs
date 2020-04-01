using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace InterviewCake.Questions
{
    public class _08___Word_Cloud
    {
        public static Dictionary<string, int> GetWordCloudDictionary(string input)
        {
            var wordCloud = new Dictionary<string, int>();
            var lastWord = new StringBuilder();

            // Iterate through input. If it's punctuation symbol/space, insert previous
            // word and increment it's frequency by 1.
            // (Assume last character is always apunctuation symbol)
            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                if (char.IsLetter(currentChar))
                {
                    lastWord.Append(currentChar);
                }
                else if (lastWord.Length != 0)
                {
                    string lastWordString = lastWord.ToString().ToLowerInvariant();
                    if (!wordCloud.ContainsKey(lastWordString))
                        wordCloud.Add(lastWordString, 0);

                    wordCloud[lastWordString]++;

                    lastWord.Clear();
                }
            }

            return wordCloud;
        }

        public static void PrintWordCloud(Dictionary<string, int> wordCloud)
        {
            foreach (var kv in wordCloud)
            {
                WriteLine("Key : " + kv.Key + ", Value: " + kv.Value);
            }

            WriteLine("======");
        }
    }
}
