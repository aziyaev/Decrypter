
# Decrypter

**Education project from NowYouSeeSharp courses**

### What can you do with this?

The application encrypts the input text in the selected alphabet with a Vigener cipher. 
Non—alphabetic characters (spaces, punctuation marks, numbers) are not converted.

### How can you use this?

The project has two appendices. [WebApp Decoder](https://github.com/aziyaev/Decrypter/tree/main/DecrypterWebApp) and [WPF Decoder](https://github.com/aziyaev/Decrypter/tree/main/DecrypterWPF).

#### WPF Decoder

[Source](https://github.com/aziyaev/Decrypter/tree/main/DecrypterWPF)

<img src="https://github.com/aziyaev/Decrypter/blob/main/MSTestDecrypter/wpf.png" alt="wpfScreen"/>

The application has the following functionality: 
* Encryption by a given key;
* Decryption by a given key; 
* Loading .docx and .txt file with encrypted/decrypted text; 
* Uploading .docx and txt .file with encrypted/decrypted text;
* You can to specify ROT (converting the first letter of the text)
* Нou can change the alphabet to the suggested one (currently: Rus)

#### WebApp Decoder ASP.NET MVC

[Source](https://github.com/aziyaev/Decrypter/tree/main/DecrypterWebApp)

<img src="https://github.com/aziyaev/Decrypter/blob/main/MSTestDecrypter/asp.png" alt="aspScreen"/>

The application has the following functionality: 
* Encryption by a given key;
* Decryption by a given key.
* Нou can change the alphabet to the suggested one (currently: Rus)

#### Sources of the Vigener Cipher

[Source](https://github.com/aziyaev/Decrypter/tree/main/VigenereCipher)

Testing has shown that the encryption and decryption functions work correctly.

The application was tested using [MSTest](https://github.com/aziyaev/Decrypter/tree/main/MSTestDecrypter) Visual Studio.

<img src="https://github.com/aziyaev/Decrypter/blob/main/MSTestDecrypter/asp.png" alt="aspScreen"/>

##### Encode function

The Vigener encryption function by the method of simple substitution with a key

```C#
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
```

##### Decode function

The Vigener decryption function by the method of simple substitution with a key

```C#
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
```
