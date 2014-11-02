//Write a program that encodes and decodes a
//string using given encryption key (cipher). The 
//key consists of a sequence of characters. The 
//encoding/decoding is done by performing XOR
//(exclusive or) operation over the first letter of the 
//string with the first of the key, the second – with the second, ect.
//When the last key character is reached, the next is the first.

using System;
using System.Text;

class EncodeAndDecodeString
{
    static StringBuilder Encode(string textToEncode, string cipher)
    {
        StringBuilder encodedText = new StringBuilder(textToEncode.Length);

        for (int i = 0; i < textToEncode.Length; i++)
        {
            encodedText.Append((char) (textToEncode[i] ^ cipher[i % cipher.Length]));
        }

        return encodedText;
    }

    static StringBuilder Decode(StringBuilder encodedText, string cipher)
    {
        StringBuilder decodedText = new StringBuilder(encodedText.Length);

        for (int i = 0; i < encodedText.Length; i++)
        {
            decodedText.Append((char)(encodedText[i] ^ cipher[i % cipher.Length]));
        }

        return decodedText;
    }

    static void Main()
    {
        Console.Write("Please, type the string to be encoded and press Enter: ");
        string textToEncode = Console.ReadLine();
        Console.Write("Please, type the encryption key and press Enter: ");
        string cipher = Console.ReadLine();

        StringBuilder encodedText = new StringBuilder(textToEncode.Length);
        encodedText = Encode(textToEncode, cipher);
        Console.WriteLine("The encoded text is: {0}", encodedText);

        StringBuilder decodedText = new StringBuilder(textToEncode.Length);
        decodedText = Decode(encodedText, cipher);
        Console.WriteLine("The decoded text is: {0}", decodedText);
    }
}