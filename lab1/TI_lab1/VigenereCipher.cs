using System;
using System.Linq;
using System.Text;
using TI_lab1;

namespace TI_lab1
{
    public static class VigenereCipher
    {
        public static string Encrypt(string text, string key)
        {
            return ProcessText(text, key, true);
        }

        public static string Decrypt(string text, string key)
        {
            return ProcessText(text, key, false);
        }

        private static string ProcessText(string text, string key, bool encrypt)
        {
            if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(key))
                return text;

            string normalizedKey = NormalizeRussianText(key.ToUpper());

            if (string.IsNullOrEmpty(normalizedKey))
                throw new ArgumentException("Ключ должен содержать русские буквы");

            StringBuilder result = new StringBuilder();
            int keyIndex = 0;

            foreach (char c in text)
            {
                char upperC = char.ToUpper(c);
                char normalizedC = NormalizeChar(upperC);

                if (Constants.RussianAlphabet.Contains(normalizedC))
                {
                    bool isUpper = char.IsUpper(c);
                    int charPos = Constants.RussianAlphabet.IndexOf(normalizedC);
                    int keyPos = Constants.RussianAlphabet.IndexOf(normalizedKey[keyIndex % normalizedKey.Length]);

                    int newPos;
                    if (encrypt)
                        newPos = (charPos + keyPos) % Constants.RussianAlphabet.Length;
                    else
                        newPos = (charPos - keyPos + Constants.RussianAlphabet.Length) % Constants.RussianAlphabet.Length;

                    char newChar = Constants.RussianAlphabet[newPos];

                    if (!isUpper)
                        newChar = char.ToLower(newChar);

                    result.Append(newChar);
                    keyIndex++;
                }
                else
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }

        private static string NormalizeRussianText(string text)
        {
            StringBuilder normalized = new StringBuilder();
            foreach (char c in text)
            {
                char normalizedChar = NormalizeChar(c);
                if (Constants.RussianAlphabet.Contains(normalizedChar))
                {
                    normalized.Append(normalizedChar);
                }
            }
            return normalized.ToString();
        }

        private static char NormalizeChar(char c)
        {
            if (c == 'Ё' || c == 'ё')
                return 'Ё';
            return c;
        }
    }
}