using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace LoginPassword
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// 
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if ((Login.Text == string.Empty && Password.Password == string.Empty) ||( Password.Password.Length <= 6 && Password.Password.Length >= 15))
            {
                MessageBox.Show("Please correctly enter the Login");
            }
            else
            {
                MessageBox.Show($"Hello {Login.Text} i miss you bebe !!!");
            }
        }
    }
}
