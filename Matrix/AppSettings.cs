using Bunifu.UI.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        /*public static void SearchDate(string Query,DataTable dt)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConString()))
                {
                    con.Open();
                    string searchQuery = $"SELECT * FROM {tableName} WHERE {by} LIKE '%{value}%'";
                    //MessageBox.Show(searchQuery);
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = searchQuery;
                    cmd.Parameters.AddWithValue(value, by);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    dataTable.Load(dr);
                    con.Close();
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }*/

        public static void SearchControl (string tableName,string by,string value,DataTable dataTable, bool date) 
        {
            try
            {
                using(MySqlConnection con = new MySqlConnection(ConString()))
                {
                    string searchQuery;
                    con.Open();
                    if(date)
                    {
                         searchQuery = $"SELECT * FROM {tableName} WHERE {by} = '{value}'";
                    }
                    else { searchQuery = $"SELECT * FROM {tableName} WHERE {by} LIKE '%{value}%'"; }
                    
                   /* if(month)
                    {
                        searchQuery = $"SELECT * FROM {tableName} WHERE {by} LIKE '{value}'";
                    }
                    else { searchQuery = $"SELECT * FROM {tableName} WHERE {by} LIKE '%{value}%'"; }*/

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

        public static void NumericOnly(BunifuTextBox textbox)
        {
            string text = textbox.Text;
            int originalSelectionStart = textbox.SelectionStart;
            if (Regex.IsMatch(text, "[a-zA-Z]"))
            {
                text = Regex.Replace(text, "[a-zA-Z]", "");
                textbox.Text = text;
                textbox.SelectionStart = originalSelectionStart;
            }
        }
    }
}
