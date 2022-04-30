using DevExpress.Utils.CommonDialogs;
using DevExpress.Utils.CommonDialogs.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.Web.CodeGeneration;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems;
using Microsoft.Win32;
using DecrypterWPF;

namespace MSTestDecrypter
{
    [TestClass]
    public class UnitTest1
    {
        private static List<string> ExpectedItemsEncodeSorpion = new List<string>()
        {
            "ькяь г уънвё выаиъ шаыоьыд",
            "р х ррь шчёе — вуую пу оацу?",
            "иээ п ьчсб цду въицндж?",
            "дпюхае, н хякм, т сижты мэьф",
            "юпьп ящухвпьмфх ьнькцрве.",
            "ящ рл, ъ хэты шувжиааящш фюфу",
            "жщбм ъиющп соьюъбц жыоюо,",
            "уё ьх юъбнуубх ьньм."

        };

        private static List<string> ExpectedItemsEncode1a = new List<string>()
        {
            "лбсм ф лмбсь флсбм лпсбммь",
            "а л гбн рйщф — шёдп зё впмё?",
            "шуп а нпдф ёъё тлбибуэ?",
            "уёрёсэ, а иобя, г гбщёк гпмё",
            "нёоа рсёисёоэён облбибуэ.",
            "оп гь, л нпёк оётшбтуопк епмё",
            "цпуэ лбрмя збмптуй цсбоа,",
            "гь оё птубгйуё нёоа."

        };

        private static List<string> ExpectedItemsDecode = new List<string>()
        {
            "карл у клары украл кораллы",
            "я к вам пишу — чего же боле?",
            "Что я могу еще сказать?",
            "Теперь, я знаю, в вашей воле",
            "Меня презреньем наказать.",
            "Но вы, к моей несчастной доле",
            "Хоть каплю жалости храня,",
            "Вы не оставите меня."
        };


        private static Dictionary<string, List<string>> testSet = new Dictionary<string, List<string>>()
        {
            {
                "скорпион", ExpectedItemsEncodeSorpion
            },
            {
                "1а" , ExpectedItemsEncode1a
            }
        };



        [TestMethod]
        public void TestMethod1()
        {
            DecrypterWPF.Decrypter decrypter = new DecrypterWPF.Decrypter();
            decrypter.IsConsiderLetterCase = false;
            decrypter.IsEncodeText = false;
            

            string key = "скорпион";
            for (int i = 0; i < testSet[key].Count; i++)
            {
                string output = decrypter.ConvertText(testSet[key][i], key);
                Assert.AreEqual(output, ExpectedItemsDecode[i].ToLower());
            }

            decrypter.ROT = 1;
            key = "1а";
            for (int i = 0; i < testSet[key].Count; i++)
            {
                string output = decrypter.ConvertText(testSet[key][i], key);
                Assert.AreEqual(output, ExpectedItemsDecode[i].ToLower());
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            DecrypterWPF.Decrypter decrypter = new DecrypterWPF.Decrypter();
            decrypter.IsConsiderLetterCase = false;
            decrypter.IsEncodeText = true;

            string key = "скорпион";
            for (int i = 0; i < testSet[key].Count; i++)
            {
                string output = decrypter.ConvertText(ExpectedItemsDecode[i], key);
                Assert.AreEqual(output, testSet[key][i].ToLower());
            }

            decrypter.ROT = 1;
            key = "1а";
            for (int i = 0; i < testSet[key].Count; i++)
            {
                string output = decrypter.ConvertText(ExpectedItemsDecode[i], key);
                Assert.AreEqual(output, testSet[key][i].ToLower());
            }
            //string output = decrypter.ConvertText()
        }


    }
}