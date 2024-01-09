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
    public partial class Users : Form
    {
        public int ID { get; private set; }

        public Users()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (UsernameBox.Text != string.Empty && PassBox.Text != string.Empty && ConfirmBox.Text != string.Empty)
            {
                if (PassBox.Text == ConfirmBox.Text)
                {
                    Query();
                }
                else { MessageBox.Show("Password and Confirm Password Does not Match"); }

            }
            else { MessageBox.Show("Please Fill All the Boxes to Continue"); }
        }


        void Query()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(AppSettings.ConString()))
                {
                    con.Open();
                    string SqlQuery = "INSERT INTO Users (ID,Username, Password) VALUES (@ID,@Username,@Password);";

                    MySqlCommand cmd = new MySqlCommand(SqlQuery, con);

                    cmd.Parameters.AddWithValue("@ID", (getLastID() + 1));
                    cmd.Parameters.AddWithValue("@Username", UsernameBox.Text);
                    cmd.Parameters.AddWithValue("@Password", PassBox.Text);

                    cmd.ExecuteNonQuery();
                    con.Close();


                    MessageBox.Show("Data Inserted Successfly", "Caution!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {

                if (ex.Message.Contains($"Duplicate entry '{UsernameBox.Text}' for key 'Name'"))
                {
                    MessageBox.Show("This Name is Already been Registered", "Caution!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (ex.Message.Contains($"Duplicate entry '{PassBox.Text}' for key 'Phone'"))
                {
                    MessageBox.Show("This Phone No. is Already been Registered", "Caution!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error: " + ex.Message, "Customer Query", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally { LoadData(); }
        }

        void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection(AppSettings.ConString()))
            {
                conn.Open();

                string mySql = "SELECT * FROM users ORDER BY ID DESC;";

                MySqlCommand cmd = new MySqlCommand(mySql, conn);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    UsersDataGridView.DataSource = dt;
                }
            }
        }

        private int getLastID()
        {
            int lastID = 0;
            try
            {

                using (MySqlConnection con = new MySqlConnection(AppSettings.ConString()))
                {
                    con.Open();
                    string sqlQuery = "SELECT ID from users ORDER BY ID DESC LIMIT 1; ";

                    MySqlCommand cmd = new MySqlCommand(sqlQuery, con);
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        lastID = Convert.ToInt32(result);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Get Last ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return lastID;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (UsernameBox.Text != string.Empty && PassBox.Text != string.Empty && ConfirmBox.Text != string.Empty)
            {
                if (PassBox.Text == ConfirmBox.Text)
                {
                    UpdateData();
                }
                else { MessageBox.Show("Password and Confirm Password Does not Match"); }

            }
            else { MessageBox.Show("Please Fill All the Boxes to Continue"); }
        }

        void UpdateData()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(AppSettings.ConString()))
                {
                    con.Open();

                    string query = "UPDATE users SET Username = @Username, Password = @Password WHERE ID = @ID";

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@Username", UsernameBox.Text);
                    cmd.Parameters.AddWithValue("@Password", PassBox.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Updated Successfully", "Update ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LoadData();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        void Remove()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(AppSettings.ConString()))
                {
                    con.Open();

                    string query = "DELETE FROM users WHERE ID = @ID";

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@ID", UsersDataGridView.SelectedRows[0].Cells[0].Value.ToString());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"Customer '{UsersDataGridView.SelectedRows[0].Cells[1].Value}' Data Removed Successfully", "Remove ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LoadData();
                ClearBox();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        void ClearBox()
        {
            UsernameBox.Clear();
            PassBox.Clear();
            ConfirmBox.Clear();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearBox();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            Remove();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void UsersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(UsersDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            UsernameBox.Text = UsersDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            PassBox.Text = UsersDataGridView.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void ConfirmBox_OnIconRightClick(object sender, EventArgs e)
        {
            if (ConfirmBox.UseSystemPasswordChar == true)
            {
                ConfirmBox.UseSystemPasswordChar = false;
                ConfirmBox.PasswordChar = '\0';

            }
            else
            {
                ConfirmBox.UseSystemPasswordChar = true;
                ConfirmBox.PasswordChar = '●';
            }
        }

        private void PassBox_OnIconRightClick(object sender, EventArgs e)
        {

        }
    }
}
