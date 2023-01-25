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

namespace WpfApp1
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

        private void AdditionClick(object sender, RoutedEventArgs e)
        {
            String result = $"{Convert.ToDouble(firstNumberText.Text) + Convert.ToDouble(secondNumberText.Text) }";
            MessageBox.Show($"Az összeadás eredménye: {result}");
            resultsBox.Items.Add(result);
        }

        private void SubtractionClick(object sender, RoutedEventArgs e)
        {
            String result = $"{Convert.ToDouble(firstNumberText.Text) - Convert.ToDouble(secondNumberText.Text)}";
            MessageBox.Show($"A kivonás eredménye: {result}");
            resultsBox.Items.Add(result);
        }

        private void DivisionClick(object sender, RoutedEventArgs e)
        {
            String result = $"{Convert.ToDouble(firstNumberText.Text) * Convert.ToDouble(secondNumberText.Text)}";
            MessageBox.Show($"A szorzás eredménye: {result}");
            resultsBox.Items.Add(result);
        }

        private void MultiplyClick(object sender, RoutedEventArgs e)
        {
            if (Convert.ToDouble(secondNumberText.Text) == 0)
            {
                MessageBox.Show("0-val nem osztunk");
            }
            else
            {
                String result = $"{Convert.ToDouble(firstNumberText.Text) / Convert.ToDouble(secondNumberText.Text)}";
                MessageBox.Show($"A kivonás eredménye: {result}");
                resultsBox.Items.Add(result);
            }
        }
    }
}
