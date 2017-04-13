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

namespace BindingWPFtoDataBase
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        modelPlayer db = new modelPlayer();
        public MainWindow()
        {
            InitializeComponent();
          
        }

        private void Autor_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void ShowInNumber_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = db.DataPlayers.FirstOrDefault().Name;
        }
    }
}
