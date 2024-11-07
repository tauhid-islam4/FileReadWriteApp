using System;
using System.IO;
using System.Windows;

namespace FileReadWriteApp
{
    public partial class MainWindow : Window
    {
        private string filePath = "sample2.txt"; // Path of the file to read/write

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SaveToFile_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Write the text from TextInput to the file
                File.WriteAllText(filePath, TextInput.Text);
                MessageBox.Show("Text saved to file successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving to file: " + ex.Message);
            }
        }

        private void ReadFromFile_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Read text from the file and display it in FileContentDisplay
                if (File.Exists(filePath))
                {
                    string fileContent = File.ReadAllText(filePath);
                    FileContentDisplay.Text = fileContent;
                }
                else
                {
                    MessageBox.Show("File does not exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading from file: " + ex.Message);
            }
        }
    }
}
