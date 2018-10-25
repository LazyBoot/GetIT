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

namespace WpfBasics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ApplyButton_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"The description is: {DescriptionText.Text}");
        }

        private void ResetButton_OnClick(object sender, RoutedEventArgs e)
        {
            foreach (var stackPanel in Checkboxes.Children.OfType<StackPanel>())
            {
                foreach (var checkbox in stackPanel.Children.OfType<CheckBox>())
                {
                    checkbox.IsChecked = false;
                }
            }
        }

        private void CheckBox_OnChecked(object sender, RoutedEventArgs e)
        {
            LengthText.Text += ((CheckBox)sender).Content;
        }

        private void CheckBox_OnUnchecked(object sender, RoutedEventArgs e)
        {
            //var content = ((CheckBox)sender).Content.ToString();
            //var index = LengthText.Text.IndexOf(content, StringComparison.Ordinal);
            //LengthText.Text = LengthText.Text.Remove(index, content.Length);
            LengthText.Text = LengthText.Text.Replace(((CheckBox)sender).Content.ToString(), string.Empty);
        }
    }
}
