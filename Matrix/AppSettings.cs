using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix
{
    internal class AppSettings
    {

        public static string ConString()
        {
            string connectString = "server=localhost;Database=gym_matrix;Uid=root;Pwd=''";

            return connectString;
        }

        public static void SearchControl (string tableName,string by,string value,DataTable dataTable) 
        {
            try
            {
                using(MySqlConnection con = new MySqlConnection(ConString()))
                {
                    con.Open();
                    string searchQuery = $"SELECT * FROM {tableName} WHERE {by} LIKE '{value}%'";
                    //MessageBox.Show(searchQuery);
                    MySqlCommand cmd = con.CreateCommand ();
                    cmd.CommandText = searchQuery;
                    cmd.Parameters.AddWithValue(value, by);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    dataTable.Load (dr);
                    con.Close ();
                }
            }catch (Exception e) { MessageBox.Show(e.Message); }
        }
    }
}
