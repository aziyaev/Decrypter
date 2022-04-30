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

namespace MSTestDecrypter
{
    [TestClass]
    public class UnitTest1
    {
        private List<string> ExpectedItemsEncode = new List<string>()
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
        private List<string> ExpectedItemsDecode = new List<string>()
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

        private const string keyword = "��������";

        [TestMethod]
        public void TestMethod1()
        {
            DecrypterWPF.Decrypter decrypter = new DecrypterWPF.Decrypter();
            decrypter.IsConsiderLetterCase = false;
            decrypter.IsEncodeText = false;

            for (int i = 0; i < ExpectedItemsEncode.Count; i++)
            {
                string output = decrypter.ConvertText(ExpectedItemsEncode[i], keyword);
                Assert.AreEqual(output, ExpectedItemsDecode[i].ToLower());
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            DecrypterWPF.Decrypter decrypter = new DecrypterWPF.Decrypter();
            decrypter.IsConsiderLetterCase = false;
            decrypter.IsEncodeText = true;

            for (int i = 0; i < ExpectedItemsEncode.Count; i++)
            {
                string output = decrypter.ConvertText(ExpectedItemsDecode[i], keyword);
                Assert.AreEqual(output, ExpectedItemsEncode[i].ToLower());
            }
            //string output = decrypter.ConvertText()
        }

        [TestMethod]
        public void TestMethod3()
        {
            var expectedFileContent = "�����, ��� ��������. ���� ��� ��� ������, �� ���� ������ ����";
            var expectedFileName = "filename.txt";

            var fileSystem = new Mock<IFileSystem>();
            fileSystem.Setup(_ => _.ReadAllText(expectedFileName))
            .Returns(expectedFileContent)
            .Verifiable();

            var openFileDialog = new Mock<IOpenFileDialog>();
            openFileDialog.Setup(_ => _.ShowDialog()).Returns(DialogResult.OK).Verifiable();
            openFileDialog.Setup(_ => _.FileName).Returns(expectedFileName).Verifiable();

            DecrypterWPF.TextFileService sut = new DecrypterWPF.TextFileService();


            
        }


    }
}