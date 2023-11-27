using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadAlphabet();
        }
        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            string input = txtInput.Text;
            int sum = 0;

            foreach (char c in input)
            {
                sum += (int)c;
            }

            txtResult.Text = $"Sum: {sum}";
        }

        private void LoadAlphabet()
        {
            for (int i = 'А'; i <= 'Я'; i++)
            {
                alphabetListBox.Items.Add(((char)i).ToString());
            }
        }

        private void AlphabetListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            resultTextBox.Text = alphabetListBox.SelectedItem.ToString();
        }

        private void BuildStringButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in alphabetListBox.Items)
            {
                stringBuilder.Append(item.ToString());
            }
            resultTextBox.Text = stringBuilder.ToString();
        }
    }
}

