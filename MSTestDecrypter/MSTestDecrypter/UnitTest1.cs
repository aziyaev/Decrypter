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
            "���� � ���� ����� �������",
            "� � ��� ���� � ���� �� ����?",
            "��� � ���� ��� �������?",
            "������, � ����, � ����� ����",
            "���� ���������� ��������.",
            "�� ��, � ���� ���������� ����",
            "���� ����� ������� �����,",
            "� �� �������� ����."

        };

        private static List<string> ExpectedItemsEncode1a = new List<string>()
        {
            "���� � ����� ����� �������",
            "� � ��� ���� � ���� � ���?",
            "��� � ���� ��� �������?",
            "����, � ����, � ����� ���",
            "��� �������� ��������.",
            "�� ��, � ��� ��������� ���",
            "���� ����� ������� �����,",
            "�� � ������� ���."

        };

        private static List<string> ExpectedItemsDecode = new List<string>()
        {
            "���� � ����� ����� �������",
            "� � ��� ���� � ���� �� ����?",
            "��� � ���� ��� �������?",
            "������, � ����, � ����� ����",
            "���� ���������� ��������.",
            "�� ��, � ���� ���������� ����",
            "���� ����� ������� �����,",
            "�� �� �������� ����."
        };


        private static Dictionary<string, List<string>> testSet = new Dictionary<string, List<string>>()
        {
            {
                "��������", ExpectedItemsEncodeSorpion
            },
            {
                "1�" , ExpectedItemsEncode1a
            }
        };



        [TestMethod]
        public void TestMethod1()
        {
            DecrypterWPF.Decrypter decrypter = new DecrypterWPF.Decrypter();
            decrypter.IsConsiderLetterCase = false;
            decrypter.IsEncodeText = false;
            

            string key = "��������";
            for (int i = 0; i < testSet[key].Count; i++)
            {
                string output = decrypter.ConvertText(testSet[key][i], key);
                Assert.AreEqual(output, ExpectedItemsDecode[i].ToLower());
            }

            decrypter.ROT = 1;
            key = "1�";
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

            string key = "��������";
            for (int i = 0; i < testSet[key].Count; i++)
            {
                string output = decrypter.ConvertText(ExpectedItemsDecode[i], key);
                Assert.AreEqual(output, testSet[key][i].ToLower());
            }

            decrypter.ROT = 1;
            key = "1�";
            for (int i = 0; i < testSet[key].Count; i++)
            {
                string output = decrypter.ConvertText(ExpectedItemsDecode[i], key);
                Assert.AreEqual(output, testSet[key][i].ToLower());
            }
            //string output = decrypter.ConvertText()
        }


    }
}