using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix
{
    public partial class FullData : Form
    {
        public FullData()
        {
            InitializeComponent();
        }

        private void FullData_Load(object sender, EventArgs e)
        {
            GetExpiring();
            GetExpired();
            GetDues();
        }

        private void GetExpiring()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(AppSettings.ConString()))
                {
                    con.Open();
                    string query = "SELECT * FROM addmembers WHERE Date(Renewal_Date) - Date(CURRENT_DATE) = 4;";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    if (dt.Rows.Count > 0)
                    {
                        ExpiringFDataGrid.DataSource = dt;
                    }
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "GetExpiring"); }

        }


        private void GetExpired()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(AppSettings.ConString()))
                {
                    con.Open();
                    string query = "SELECT * FROM addmembers WHERE DATEDIFF(Renewal_Date,CURRENT_DATE) <= 0;";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    if (dt.Rows.Count > 0)
                    {
                        ExpiredFDataGrid.DataSource = dt;
                    }
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "GetExpired"); }

        }

        private void GetDues()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(AppSettings.ConString()))
                {
                    con.Open();
                    string query = "SELECT * FROM addmembers WHERE Dues >0;";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    if (dt.Rows.Count > 0)
                    {
                        DuesFDataGrid.DataSource = dt;
                    }
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "GetDues"); }

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
