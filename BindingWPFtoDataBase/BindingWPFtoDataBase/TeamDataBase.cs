using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingWPFtoDataBase
{
    class TeamDataBase
    {
        public List<Player> GetAllPlayer()
        {
            List<Player> players = new List<Player>();
            SqlDataReader reader = null;
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Books", connection);
                try
                {
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Player book = new Player()
                        {
                            NamePlayer = reader[1].ToString(),
                            About = reader[2].ToString(),
                            
                        };
                        players.Add(book);
                    }
                }
                catch (Exception ex)
                {
                    reader.Close();
                    throw ex;
                }
                connection.Close();
            }
            return players;
        }
    }
}
