using System;
using System.Text;
using System.Text.RegularExpressions;

class DecodeAndDecrypt
{
    static void Main()
    {
        string input = Console.ReadLine();
        //string input = "KKICXDE3P5";

        var codeLength = int.Parse(Regex.Match(input, @"\d*$").ToString());
        input = input.Remove(input.Length - codeLength.ToString().Length, codeLength.ToString().Length);
        input = Decode(input);

        string cypher = input.Substring(input.Length - codeLength, codeLength);
        input = input.Substring(0, input.Length - codeLength);

        input = Encrypt(input, cypher);

        Console.WriteLine(input);
    }

    static string Decode(string text)
    {
        StringBuilder result = new StringBuilder();
        int counter = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '1' || text[i] == '2' || text[i] == '3' || text[i] == '4' || text[i] == '5' || text[i] == '6' || text[i] == '7' || text[i] == '8' || text[i] == '9')
            {
                for (counter = 0; counter < int.Parse(text[i].ToString()); counter++)
                {
                    result.Append(text[i + 1]);
                }
                if (i < text.Length - 2)
                {
                    i++;
                }
                else
                {
                    break;
                }
            }
            else
            {
                result.Append(text[i]);
            }
        }

        return result.ToString();
    }

    static string Encrypt(string msg, string cypher)
    {
        StringBuilder encodedText = new StringBuilder(msg.Length);
        int positionsLeft = 0;

        if (msg.Length >= cypher.Length)
        {
            for (int i = 0; i < msg.Length; i++)
            {
                encodedText.Append((char)((GetCode(msg[i]) ^ GetCode(cypher[i % cypher.Length])) + 65));
            }
        }
        else
        {
            positionsLeft = cypher.Length - msg.Length;
            while (positionsLeft > 0)
            {
                for (int i = 0; i < msg.Length; i++)
                {
                    encodedText.Append((char)((GetCode(msg[i]) ^ GetCode(cypher[i % cypher.Length])) + 65));
                }
                cypher = cypher.Substring(msg.Length);
                msg = encodedText.ToString();
                encodedText = new StringBuilder(msg.Length);
                for (int i = 0; i < cypher.Length; i++)
                {
                    encodedText.Append((char)((GetCode(msg[i]) ^ GetCode(cypher[i % cypher.Length])) + 65));
                }

                for (int i = encodedText.Length; i < msg.Length; i++)
                {
                    encodedText.Append(msg[i]);
                }

                positionsLeft = cypher.Length - msg.Length;
            }


        }

        return encodedText.ToString();
    }

    static int GetCode(char input)
    {
        int code = (int)input - 65;

        return code;
    }
}
