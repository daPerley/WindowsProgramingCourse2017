using Microsoft.Win32;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace ExerciseForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string extent;
        private string languages;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void BtnSend_Click(object sender, RoutedEventArgs e)
        {
            string fileText = tbName.Text + ";" + extent + ";" + languages + ";" + cbRole.Text + ";" + cStart;

            SaveFileDialog dialog = new SaveFileDialog()
            {
                Filter = "Text Files(*.txt)|*.txt|All(*.*)|*"
            };

            if (dialog.ShowDialog() == true)
            {
                File.WriteAllText(dialog.FileName, fileText);
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            var radioButton = sender as RadioButton;

            extent = radioButton.Content.ToString();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            var checkBox = sender as CheckBox;

            if (languages != null)
                languages += "," + checkBox.Content.ToString();
            else
            {
                languages = checkBox.Content.ToString();
            }
        }
    }
}
