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
                    int PlayerID = int.Parse(Number.Text);
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

        private void ShowTeam_Click(object sender, RoutedEventArgs e)
        {
            if (Team.Items.Count != 0 && Team.Visibility != Visibility.Collapsed)
            {
                Team.Visibility = Visibility.Collapsed;
                Team.Items.Clear();
            }
            else
            {
                Team.Visibility = Visibility.Visible;
                SqlDataReader reader = null;
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
                {


                    SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Table] ", connection);

                    connection.Open();

                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Team.Items.Add(reader[1]);
                    }
                    reader.Close();
                }
            }
        }

        private void UpdateDescription_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Number.Text)) MessageBox.Show("Enter an ID");
            else
            {
                var connection = new SqlConnection(@"data source = (LocalDB)\MSSQLLocalDB; Integrated Security = True; initial catalog = SoccerPalyers");
                var command = new SqlCommand();
                if (FirstLastNAme.Text.Count(c => c == ' ') > 1)
                {
                    MessageBox.Show("Not a valid format");
                    return;
                }
                else if (!FirstLastNAme.Text.Contains(' '))
                {
                    command = new SqlCommand($"update customers set fname = '{FirstLastNAme.Text}' where customerno = {Number.Text}", connection);
                }
                else if (FirstLastNAme.Text.Count(c => c == ' ') == 1)
                {
                    var split = FirstLastNAme.Text.Split(' ');
                    command = new SqlCommand($"update customers set fname = '{split[0]}', lname = '{split[1]}' where customerno = {Number.Text}", connection);
                }

                try
                {
                    connection.Open();

                    command.Transaction = connection.BeginTransaction();

                    command.ExecuteNonQuery();

                    command.Transaction.Commit();
                    MessageBox.Show("Transaction commited");
                }
                catch (Exception)
                {
                    command.Transaction.Rollback();
                    MessageBox.Show("transaction rolled back");
                }
            }
        }
    }
}
