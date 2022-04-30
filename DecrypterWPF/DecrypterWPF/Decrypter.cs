using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecrypterWPF
{
    public class Decrypter
    {
        public VigenereCipher VC { get; set; }
        public int ROT { get; set; }
        public bool IsConsiderLetterCase { get; set; }
        public Alphabet CurrentAlphabet { get; set; }
        public bool IsEncodeText { get; set; }

        public Decrypter()
        {
            this.ROT = 0;
            this.IsConsiderLetterCase = true;
            this.CurrentAlphabet = Alphabet.rus;
            this.IsEncodeText = true;
        }

        public string ConvertText(string input, string keyword)
        {
            VC = new VigenereCipher(CurrentAlphabet, IsConsiderLetterCase, ROT);
            string output;

            if (IsEncodeText)
                output = VC.Encode(input, keyword);
            else
                output = VC.Decode(input, keyword);

            return output;
        }
    }
}
