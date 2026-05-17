using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TI_lab1
{
    public static class RailFenceCipher
    {
        public static string Encrypt(string text, int rails)
        {
            if (rails < 1)
                throw new ArgumentException("Количество рельсов должно быть >= 1");

            if (string.IsNullOrEmpty(text))
                return text;

            if (rails == 1)
                return text;

            char[] result = new char[text.Length];

            List<int> letterPositions = new List<int>();
            List<char> letters = new List<char>();

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                if (char.IsLetter(c) && ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z')))
                {
                    letterPositions.Add(i);
                    letters.Add(c);
                }
                else
                {
                    result[i] = c;
                }
            }

            if (letters.Count == 0)
                return text;

            string lettersString = new string(letters.ToArray());
            string encryptedLetters = EncryptLettersOnly(lettersString, rails);

            for (int i = 0; i < letterPositions.Count; i++)
            {
                result[letterPositions[i]] = encryptedLetters[i];
            }

            return new string(result);
        }

        public static string Decrypt(string text, int rails)
        {
            if (rails < 1)
                throw new ArgumentException("Количество рельсов должно быть >= 1");

            if (string.IsNullOrEmpty(text))
                return text;

            if (rails == 1)
                return text;

            char[] result = new char[text.Length];

            List<int> letterPositions = new List<int>();
            List<char> letters = new List<char>();

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                if (char.IsLetter(c) && ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z')))
                {
                    letterPositions.Add(i);
                    letters.Add(c);
                }
                else
                {
                    result[i] = c;
                }
            }

            if (letters.Count == 0)
                return text;

            string lettersString = new string(letters.ToArray());
            string decryptedLetters = DecryptLettersOnly(lettersString, rails);

            for (int i = 0; i < letterPositions.Count; i++)
            {
                result[letterPositions[i]] = decryptedLetters[i];
            }

            return new string(result);
        }

        private static string EncryptLettersOnly(string text, int rails)
        {
            List<char>[] fence = new List<char>[rails];
            for (int i = 0; i < rails; i++)
                fence[i] = new List<char>();

            int rail = 0;
            int direction = 1;

            foreach (char c in text)
            {
                fence[rail].Add(c);
                rail += direction;

                if (rail == 0 || rail == rails - 1)
                    direction = -direction;
            }

            return string.Join("", fence.Select(f => new string(f.ToArray())));
        }

        private static string DecryptLettersOnly(string text, int rails)
        {
            char?[,] fence = new char?[rails, text.Length];

            int rail = 0;
            int direction = 1;

            for (int col = 0; col < text.Length; col++)
            {
                fence[rail, col] = '*';
                rail += direction;

                if (rail == 0 || rail == rails - 1)
                    direction = -direction;
            }

            int index = 0;
            for (int row = 0; row < rails; row++)
            {
                for (int col = 0; col < text.Length; col++)
                {
                    if (fence[row, col] == '*')
                    {
                        fence[row, col] = text[index];
                        index++;
                    }
                }
            }

            List<char> result = new List<char>();
            rail = 0;
            direction = 1;

            for (int col = 0; col < text.Length; col++)
            {
                result.Add(fence[rail, col].Value);
                rail += direction;

                if (rail == 0 || rail == rails - 1)
                    direction = -direction;
            }

            return new string(result.ToArray());
        }
    }
}