using Microsoft.Win32;
using System;
using System.IO;
using System.Text;
using Xceed.Words.NET;

namespace DecrypterWPF
{
    public class TextFileService
    {
        public TextFileService()
        {

        }

        public Tuple<string, string> OpenTextFile(OpenFileDialog openFileDialog)
        {
            openFileDialog.Filter = "Text File (.txt)|*.txt|Word File (.docx ,.doc)|*.docx;*.doc";

            bool? result = openFileDialog.ShowDialog();

            if (result.GetValueOrDefault(false))
                if(openFileDialog.FilterIndex == 1)
                    return Tuple.Create(File.ReadAllText(openFileDialog.FileName, Encoding.Default), openFileDialog.FileName);
                else
                {
                    var docx = DocX.Load(openFileDialog.FileName);
                    return Tuple.Create(docx.Text, openFileDialog.FileName);
                }
            else
                return null;
        }

        public void SaveTextFile(SaveFileDialog saveFileDialog, string content)
        {
            saveFileDialog.Filter = "Text File (.txt)|*.txt|Word File (.docx ,.doc)|*.docx;*.doc";

            bool? result = saveFileDialog.ShowDialog();

            if (result.GetValueOrDefault(false))
                if (saveFileDialog.FilterIndex == 1)
                {
                    File.WriteAllText(saveFileDialog.FileName, content, Encoding.UTF8);
                }
                else
                {
                    var docx = DocX.Create(saveFileDialog.FileName);
                    docx.InsertParagraphs(content);
                    docx.Save();
                }
        }
    }

}
