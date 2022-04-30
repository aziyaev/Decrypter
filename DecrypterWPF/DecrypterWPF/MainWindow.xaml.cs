using Microsoft.Win32;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DecrypterWPF
{

    public partial class MainWindow : Window
    {
        private Decrypter decrypter;

        public MainWindow()
        {
            decrypter = new Decrypter();
            InitializeComponent();
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(e.Uri.AbsoluteUri);
        }

        private void ROT0_Click(object sender, RoutedEventArgs e)
        {
            this.ROT0.IsChecked = true;
            this.ROT1.IsChecked = false;
            decrypter.ROT = 0;
        }

        private void ROT1_Click(object sender, RoutedEventArgs e)
        {
            this.ROT0.IsChecked = false;
            this.ROT1.IsChecked = true;
            decrypter.ROT = 1;
        }

        private void TextBox_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }

        private void Encode_Click(object sender, RoutedEventArgs e)
        {
            this.Encode.IsChecked = true;
            this.Decode.IsChecked = false;
            decrypter.IsEncodeText = true;
        }

        private void Decode_Click(object sender, RoutedEventArgs e)
        {
            this.Encode.IsChecked = false;
            this.Decode.IsChecked = true;
            decrypter.IsEncodeText = false;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;

            switch (selectedItem.Content)
            {
                case "Русский":
                    decrypter.CurrentAlphabet = Alphabet.rus;
                    break;
                case "Английский":
                    decrypter.CurrentAlphabet = Alphabet.eng;
                    break;
                default:
                    decrypter.CurrentAlphabet = Alphabet.rus;
                    break;
            }

        }

        private void ConvertButton_Click(object sender, RoutedEventArgs e)
        {
            var inputText = this.InputTextBox.Text;
            var keyword = this.KeywordTextBox.Text;

            if (string.IsNullOrEmpty(keyword) || string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Пустой ключ!");
                return;
            }

            this.OutputTextBox.Text = decrypter.ConvertText(inputText, keyword);
        }

        private void UploadButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            TextFileService textFileService = new TextFileService();

            this.InputTextBox.Text = textFileService.OpenTextFile(dlg).Item1;

            /*dlg.Filter = "Text File (.txt)|*.txt|Word File (.docx ,.doc)|*.docx;*.doc";

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                string filename = dlg.FileName;

                if(dlg.FilterIndex == 1)
                {
                    this.InputTextBox.Text = File.ReadAllText(filename, Encoding.Default);
                }
                else
                {
                    var docx = DocX.Load(filename);
                    this.InputTextBox.Text = docx.Text;
                }
            }*/
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            TextFileService textFileService = new TextFileService();

            textFileService.SaveTextFile(dlg, this.OutputTextBox.Text);

/*            dlg.Filter = "Text File (.txt)|*.txt|Word File (.docx ,.doc)|*.docx;*.doc";

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                string filename = dlg.FileName;

                if (dlg.FilterIndex == 1)
                {
                    File.WriteAllText(filename, this.OutputTextBox.Text, Encoding.UTF8);
                }
                else
                {
                    var docx = DocX.Create(filename);
                    docx.InsertParagraphs(this.OutputTextBox.Text);
                    docx.Save();
                }
            }*/
        }

        private void CheckBoxRegister_Click(object sender, RoutedEventArgs e)
        {
            if (this.CheckBoxRegister.IsChecked == true)
            {
                decrypter.IsConsiderLetterCase = false;
                this.StatusRegisterTextBox.Text = "Регистр не учитывается";
            }
            else
            {
                decrypter.IsConsiderLetterCase = true;
                this.StatusRegisterTextBox.Text = "Регистр учитывается";
            }
        }
    }
}
