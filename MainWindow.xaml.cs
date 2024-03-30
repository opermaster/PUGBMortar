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


namespace PUGBMortar
{
    /// <summary>
    /// MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() {
            InitializeComponent();
        }

        private void Btn_Calculate_Click(object sender, RoutedEventArgs e) {
            int a, b, result;
            try {
                a = Convert.ToInt32(Text_A.Text);
                b = Convert.ToInt32(Text_B.Text);
                result = (int)Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                Result.Text = $"Result= {result}";
            }
            catch {
                Result.Text = $"Result= {0}";
            }

            
        }
    }
}
