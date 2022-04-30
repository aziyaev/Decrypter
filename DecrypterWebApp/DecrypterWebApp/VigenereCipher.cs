using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecrypterWebApp.Controllers
{
    public class VigenereCipher
    {
        private static char[] UpperAlphabetRU = new char[] {
            'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И',
            'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С',
            'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь',
            'Э', 'Ю', 'Я'};

        private static char[] LowerAlphabetRU = new char[] {
            'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и',
            'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с',
            'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь',
            'э', 'ю', 'я'};



        private bool isConsiderLetterCase;
        private int ROT;
        private Alphabet alphabet;
        

        public VigenereCipher(Alphabet alphabet, bool isConsiderLetterCase = true, int ROT = 0)
        {
            this.isConsiderLetterCase = isConsiderLetterCase;
            this.ROT = ROT;
            this.alphabet = alphabet;
        }

        public string Encode(string input, string keyword)
        {
            int len = UpperAlphabetRU.Length;

            string result = "";
            char[] currentUpperAlphabet = UpperAlphabetRU;
            char[] currentLowerAlphabet = LowerAlphabetRU;

            switch (alphabet)
            {
                case Alphabet.rus:
                    currentUpperAlphabet = UpperAlphabetRU;
                    currentLowerAlphabet = LowerAlphabetRU;
                    break;
            }

            string clearKeyword = "";

            foreach(char c in keyword)
            {
                if (currentLowerAlphabet.Contains(c) || currentUpperAlphabet.Contains(c))
                    clearKeyword += c;
            }

            if (string.IsNullOrEmpty(clearKeyword) || string.IsNullOrWhiteSpace(clearKeyword))
                return input;


            int keywordIndex = 0;

            foreach (char c in input)
            {
                if (Char.IsLetter(c) && isConsiderLetterCase && (currentLowerAlphabet.Contains(c) || currentUpperAlphabet.Contains(c)))
                {
                    int index = 0;
                    if (Char.IsLower(c))
                    {
                        clearKeyword = clearKeyword.ToLower();
                        index = (Array.IndexOf(currentLowerAlphabet, c) + len + Array.IndexOf(currentLowerAlphabet, clearKeyword[keywordIndex]) + ROT) % len;

                        result += LowerAlphabetRU[index];
                    }
                    else if (Char.IsUpper(c))
                    {
                        clearKeyword = clearKeyword.ToUpper();
                        index = (Array.IndexOf(currentUpperAlphabet, c) + len + Array.IndexOf(currentUpperAlphabet, clearKeyword[keywordIndex]) + ROT) % len;

                        result += currentUpperAlphabet[index];
                    }

                    if (keywordIndex + 1 == clearKeyword.Length)
                        keywordIndex = 0;
                    else
                        keywordIndex++;
                }
                else if (Char.IsLetter(c) && (currentLowerAlphabet.Contains(c) || currentUpperAlphabet.Contains(c)))
                {

                    int index = 0;
                    clearKeyword = clearKeyword.ToLower();
                    index = (Array.IndexOf(currentLowerAlphabet, char.ToLower(c)) + len + Array.IndexOf(currentLowerAlphabet, clearKeyword[keywordIndex]) + ROT) % len;

                    result += currentLowerAlphabet[index];

                    if (keywordIndex + 1 == clearKeyword.Length)
                        keywordIndex = 0;
                    else
                        keywordIndex++;
                }
                else
                    result += c;
            }
            return result;
        }

        public string Decode(string input, string keyword)
        {
            int len = UpperAlphabetRU.Length;

            string result = "";
            char[] currentUpperAlphabet = UpperAlphabetRU;
            char[] currentLowerAlphabet = LowerAlphabetRU;

            switch (alphabet)
            {
                case Alphabet.rus:
                    currentUpperAlphabet = UpperAlphabetRU;
                    currentLowerAlphabet = LowerAlphabetRU;
                    break;
            }

            string clearKeyword = "";

            foreach (char c in keyword)
            {
                if (currentLowerAlphabet.Contains(c) || currentUpperAlphabet.Contains(c))
                    clearKeyword += c;
            }

            if (string.IsNullOrEmpty(clearKeyword) || string.IsNullOrWhiteSpace(clearKeyword))
                return input;

            int keywordIndex = 0;

            foreach (char c in input)
            {
                if (Char.IsLetter(c) && isConsiderLetterCase && (currentLowerAlphabet.Contains(c) || currentUpperAlphabet.Contains(c)))
                {
                    int index = 0;
                    if (Char.IsLower(c))
                    {
                        clearKeyword = clearKeyword.ToLower();
                        index = (Array.IndexOf(currentLowerAlphabet, c) + len - Array.IndexOf(currentLowerAlphabet, clearKeyword[keywordIndex]) - ROT) % len;


                        result += currentLowerAlphabet[index];
                    }
                    else if (Char.IsUpper(c))
                    {
                        clearKeyword = clearKeyword.ToUpper();
                        index = (Array.IndexOf(currentUpperAlphabet, c) + len - Array.IndexOf(currentUpperAlphabet, clearKeyword[keywordIndex]) - ROT) % len;

                        result += currentUpperAlphabet[index];
                    }

                    if (keywordIndex + 1 == clearKeyword.Length)
                        keywordIndex = 0;
                    else
                        keywordIndex++;
                }
                else if (Char.IsLetter(c) && (currentLowerAlphabet.Contains(c) || currentUpperAlphabet.Contains(c)))
                {
                    int index = 0;
                    clearKeyword = clearKeyword.ToLower();
                    index = (Array.IndexOf(currentLowerAlphabet, char.ToLower(c)) + len - Array.IndexOf(currentLowerAlphabet, clearKeyword[keywordIndex]) - ROT) % len;


                    result += currentLowerAlphabet[index];

                    if (keywordIndex + 1 == clearKeyword.Length)
                        keywordIndex = 0;
                    else
                        keywordIndex++;
                }
                else
                    result += c;
            }
            return result;
        }
    }



}