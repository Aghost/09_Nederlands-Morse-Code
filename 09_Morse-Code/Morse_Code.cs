using System.Collections.Generic;
using System.Linq;

namespace _09_Morse_Code
{
    public static class MorseCode
    {
        public static readonly Dictionary<char, string> MorseDict;
        public static readonly Dictionary<string, char> ReversedDict;

        static MorseCode()
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
                {'0', "-----" },    {' ', "_" }
            };

            ReversedDict = MorseDict.ToDictionary(x => x.Value, x => x.Key);
        }

        public static string ToMorse(char character)
        {
            if (MorseDict.ContainsKey(character))
            {
                return MorseDict[character];
            }
            else return "";
        }

        public static char FromMorse(string str)
        {
            if (ReversedDict.ContainsKey(str))
            {
                return ReversedDict[str];
            }
            else
            {
                return '\0';
            }
        }

    }
}
