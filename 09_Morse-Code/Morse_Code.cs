using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Morse_Code
{
    public static class MorseCode
    {
        public static readonly Dictionary<char, string> MorseDict;

        static Morse()
        {
            MorseDict = new Dictionary<char, string>
            {
                {'a', ".-" },       {'b', "-..." },
                {'c', "-.-." },     {'d', "-.." },
                {'e', "." },        {'f', "..-." },
                {'g', "--." },      {'h', "...." },
                {'i', ".." },       {'j', ".---" },
                {'k', "-.-" },      {'l', ".-.." },
                {'m', "--" },       {'n', "-." },
                {'o', "---" },      {'p', ".--." },
                {'q', "--.-" },     {'r', ".-." },
                {'s', "..." },      {'t', "-" },
                {'u', "..-" },      {'v', "...-" },
                {'w', ".--" },      {'x', "-..-" },
                {'y', "-.--" },     {'z', "--.." },

                {'1', ".----" },    {'2', "..---" },    {'3', "...--" },
                {'4', "....-" },    {'5', "....." },    {'6', "-...." },
                {'7', "--..." },    {'8', "---.." },    {'9', "----." },
                {'0', "-----" },    {' ', " " }
            };
        }

        public static string ToMorse(string input)
        {
            var result = new StringBuilder();

            foreach (char character in input)
            {
                if (MorseDict.ContainsKey(character))
                {
                    result.Append(MorseDict[character]);
                }
            }
            return result.ToString();
        }

        public static string FromMorse(string input)
        {
            string[] inputArray = input.Split(' ');
            var result = new StringBuilder();

            foreach (string code in inputArray)
            {
                if (MorseDict.ContainsValue(code))
                {
                    result.Append(MorseDict);       // klopt nog niet
                }
            }
            return result.ToString();
        }

    }
}
