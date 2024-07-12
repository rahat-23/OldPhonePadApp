using Avalonia.Controls;
using Avalonia.Interactivity;
using System;

namespace OldPhonePadApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ConvertButton.Click += ConvertButton_Click;
        }

        private void ConvertButton_Click(object sender, RoutedEventArgs e)
        {
            string input = InputTextBox.Text;
            string output = OldPhonePadConverter.OldPhonePad(input);
            OutputTextBox.Text = output;
        }
    }
}
