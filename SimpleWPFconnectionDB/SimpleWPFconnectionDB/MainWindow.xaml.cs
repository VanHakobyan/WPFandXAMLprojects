using System;
using System.Collections.Generic;
using System.Data.Common;
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

namespace SimpleWPFconnectionDB
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (ListBox.Items.Count != 0 && ListBox.Visibility != Visibility.Collapsed)
            {
                ListBox.Visibility = Visibility.Collapsed;
                ListBox.Items.Clear();
            }
            else
            {

                ListBox.Visibility = Visibility.Visible;
                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Anhaves.mdf;Integrated Security=True");
                using (connection)
                {
                    SqlCommand command = new SqlCommand(
                      "SELECT Id,FirstName,LastName,Age FROM CustomerSet;",
                      connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {


                        while (reader.Read())
                        {

                            ListBox.Items.Add(reader[1].ToString() + " " + reader[2] + " " + reader[3].ToString());

                        }

                    }
                    else
                    {
                        Console.WriteLine("No rows found.");
                    }
                    reader.Close();
                }

            }
        }

       
    }
}
