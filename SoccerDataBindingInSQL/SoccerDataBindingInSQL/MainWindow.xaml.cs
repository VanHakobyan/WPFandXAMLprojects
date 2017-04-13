using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace SoccerDataBindingInSQL
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

        private void Author_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Created by VH Production LLC");
        }

        private void ShowInNumber_Click(object sender, RoutedEventArgs e)
        {

            SqlDataReader reader = null;
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {

                try
                {
                    int PlayerID = int.Parse(Namber.Text);
                    SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Table] WHERE ID=@id", connection);
                    command.Parameters.AddWithValue("id", PlayerID);
                    connection.Open();

                    reader = command.ExecuteReader();
                    reader.Read();

                    FirstLastNAme.Text = reader[1].ToString();
                    AboutIn.Text = reader[2].ToString();

                    reader.Close();
                }
                catch
                {
                    MessageBox.Show("Imput Corcect number !!!");
                }
            }
        }
    }
}
