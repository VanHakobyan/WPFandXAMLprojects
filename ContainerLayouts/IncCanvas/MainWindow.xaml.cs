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

namespace IncCanvas
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

        private void INK_Gesture(object sender, InkCanvasGestureEventArgs e)
        {
            string s = string.Empty;
            foreach (var res in e.GetGestureRecognitionResults())
            {
                s += res.ApplicationGesture.ToString() + "; ";
            }
            Guest.Name = s;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var mode in Enum.GetValues(typeof(InkCanvasEditingMode)))
            {
                Combo.Items.Add(mode);
            }
            Combo.SelectedItem = INK.EditingMode;
        }
    }
}
