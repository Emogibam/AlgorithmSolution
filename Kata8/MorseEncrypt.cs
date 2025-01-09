using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata8
{
    public class MorseEncrypt
    {
        // https://www.codewars.com/kata/55b8c0276a7930249e00003c/train/csharp

        private static readonly Dictionary<char, string> CHAR_TO_MORSE = new Dictionary<char, string>
    {
        { 'A', ".-" }, { 'B', "-..." }, { 'C', "-.-." }, { 'D', "-.." },
        { 'E', "." }, { 'F', "..-." }, { 'G', "--." }, { 'H', "...." },
        { 'I', ".." }, { 'J', ".---" }, { 'K', "-.-" }, { 'L', ".-.." },
        { 'M', "--" }, { 'N', "-." }, { 'O', "---" }, { 'P', ".--." },
        { 'Q', "--.-" }, { 'R', ".-." }, { 'S', "..." }, { 'T', "-" },
        { 'U', "..-" }, { 'V', "...-" }, { 'W', ".--" }, { 'X', "-..-" },
        { 'Y', "-.--" }, { 'Z', "--.." },
        { '1', ".----" }, { '2', "..---" }, { '3', "...--" }, { '4', "....-" },
        { '5', "....." }, { '6', "-...." }, { '7', "--..." }, { '8', "---.." },
        { '9', "----." }, { '0', "-----" },
        { ' ', "" } 
    };

        public static string ToMorse(string englishStr)
        {
            if (string.IsNullOrWhiteSpace(englishStr)) return string.Empty;

            var words = englishStr.ToUpper().Split(' ');

            var encodedWords = words.Select(word =>
                string.Join(" ", word.Select(c =>
                    CHAR_TO_MORSE.TryGetValue(c, out var morse) ? morse : "?")));

            return string.Join("   ", encodedWords);
        }
    }
}
