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

namespace XML
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ciao");
             MessageBox.Show("Hello");
             MessageBox.Show("Check");
             
        }

        private void btnLocale_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Oaic");
            MessageBox.Show("olleH");
        }

        private void btnBranch_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Lucchi");
        }

        private void btnLab39_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Laboratorio 13");
        }
    }
}
