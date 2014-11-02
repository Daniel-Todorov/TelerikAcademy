//In a warm, sunny day Andrew found a bottle near the sea. It was a very special bottle, containing not one, but two messages. 
//The first message contained a big sequence of digits (0-9). 
//“This must be a secret code”, Andrew thought. And he was right. 
//After seeing the second message everything became clearer. 
//The second message said something like this: “A123C11B98”. 
//Another idea struck Andrew: “Hmm may be this is the cipher, used for creating the secret code”. 
//And again he was right.
//An alphabetical message, containing only capital English letters, is encoded with the given cipher. 
//For every letter in the original message it is replaced by the given sequence of digits in the cipher.
//For example an original message ABC with a cipher A123C11B98 will be encoded as 1239811.
//Write a program that for a given secret code from the first bottle message and a given cipher from the second bottle message 
//finds all possible original messages that can be encoded to the given secret code.

namespace _01.MessagesInBottle
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class MessagesInBottle
    {
        private static int numberOfLetters;
        private static int numberOfElementsToPick;
        private static int[] arr;
        private static SortedDictionary<string, string> result = new SortedDictionary<string, string>();
        private static List<KeyValuePair<string, string>> listOfKeys = new List<KeyValuePair<string, string>>();
        private static string secretMessage;
        private static SortedSet<string> resultContainer = new SortedSet<string>();

        static void Main()
        {
            secretMessage = Console.ReadLine();

            var cipher = Console.ReadLine();

            var splitedCipher = Regex.Matches(cipher, "\\w[0-9]+");
            numberOfLetters = splitedCipher.Count;

            foreach (var item in splitedCipher)
            {
                var stringifiedItem = item.ToString();
                var letter = item.ToString()[0].ToString();
                var code = item.ToString().Substring(1, stringifiedItem.Length - 1);
                KeyValuePair<string, string> element = new KeyValuePair<string, string>(code, letter);
                listOfKeys.Add(element);
            }

            string totalResult = string.Empty;
            string totalRealResult = string.Empty;
            int maxLengthOfSecretMessage = 20;
                arr = new int[maxLengthOfSecretMessage];
                numberOfElementsToPick = maxLengthOfSecretMessage;
                GenerateVariations(0, totalResult, totalRealResult);

            Console.WriteLine(resultContainer.Count);
            foreach (var item in resultContainer)
            {
                Console.WriteLine(item);
            }
        }

        private static void GenerateVariations(int index, string totalResult, string totalRealResult)
        {
            if (totalResult.Equals(secretMessage))
            {
                resultContainer.Add(totalRealResult);
                return;
            } else if (index >= numberOfElementsToPick || !secretMessage.StartsWith(totalResult))
            {
                return;
            }
            else
            {
                for (int i = 0; i < numberOfLetters; i++)
                {
                    totalResult += listOfKeys[i].Key;
                    totalRealResult += listOfKeys[i].Value;
                    GenerateVariations(index + 1, totalResult, totalRealResult);
                    totalRealResult = totalRealResult.Substring(0, totalRealResult.Length - 1);
                    totalResult = totalResult.Substring(0, totalResult.Length - listOfKeys[i].Key.Length);
                }
            }
        }
    }
}
