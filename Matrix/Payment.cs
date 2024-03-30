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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        public int ID { get; private set; }

        private void MembersDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(MembersDataGrid.SelectedRows[0].Cells[0].Value.ToString());
            NameBox.Text = MembersDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            FatherBox.Text = MembersDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            PhoneBox.Text = MembersDataGrid.SelectedRows[0].Cells[4].Value.ToString();
            GenderBox.Text = MembersDataGrid.SelectedRows[0].Cells[5].Value.ToString();
            MembershipBox.Text = MembersDataGrid.SelectedRows[0].Cells[6].Value.ToString();
            PaidBox.Text = MembersDataGrid.SelectedRows[0].Cells[7].Value.ToString();

            object paymentDateValue = MembersDataGrid.SelectedRows[0].Cells[8].Value;
            DateTime selectedpaymentDate;
            if (DateTime.TryParse(paymentDateValue.ToString(), out selectedpaymentDate))
            {
                PaymentDate.Value = selectedpaymentDate;
            }


            string img = MembersDataGrid.SelectedRows[0].Cells[10].Value.ToString();
            if (img != null && img.Length > 20)
            { ProfileBox.Image = Image.FromFile(img); }
            else { ProfileBox.Image = null; }
        }

        private void LoadData()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(AppSettings.ConString()))
                {
                    con.Open();

                    string query = "SELECT * FROM `payment` ORDER BY Payment_Date DESC;";

                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = query;

                    MySqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);

                    if (dt.Rows.Count > 0)
                    {
                        MembersDataGrid.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            searchCon();
        }
        private void searchCon()
        {

            DataTable dataTable = new DataTable();
            if (SearchDateRad.Checked)
            {
                string x = SearchDate.Value.Date.ToString("yyyy-MM-dd");

                AppSettings.SearchControl("payment", "Payment_Date", x, dataTable, true);
            }
            else if (SearchNameRad.Checked)
            {
                AppSettings.SearchControl("payment", "Member_Name", SearchBox.Text, dataTable, false);
            }
            else if (SearchMonthRad.Checked)
            {
                string x = SearchDate.Value.Date.ToString("yyyy-MM-dd");

                AppSettings.SearchControl("payment", "Month(Payment_Date)", MonthSearchBox.Text, dataTable, true);
            }

            if (dataTable.Rows.Count > 0)
            {
                MembersDataGrid.DataSource = dataTable;
            }
            else { LoadData(); }
        }
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            /*if (SearchBox.Text == string.Empty)
            { LoadData(); }
            else { searchCon(); }*/
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(AppSettings.ConString());
                con.Open();
                MySqlCommand cmd;
                cmd = con.CreateCommand();

                cmd.CommandText = "DELETE FROM payment WHERE ID=@ID;";
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(AppSettings.ConString());
                con.Open();
                MySqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE payment SET ID=@ID, Member_Name=@Member_Name, Member_Father=@Member_Father, Gender=@Gender,Membership_type=@Membership_type,Fee_Paid=@Fee_Paid,Payment_Date=@Payment_Date WHERE ID= @ID;";
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@Member_Name", NameBox.Text);
                cmd.Parameters.AddWithValue("@Member_Father", FatherBox.Text);
                cmd.Parameters.AddWithValue("@Member_Phone", PhoneBox.Text);
                cmd.Parameters.AddWithValue("@Gender", GenderBox.Text);
                cmd.Parameters.AddWithValue("@Membership_type", MembershipBox.Text);
                cmd.Parameters.AddWithValue("@Fee_Paid", PaidBox.Text);
                cmd.Parameters.AddWithValue("@Payment_Date", PaymentDate.Value);
                cmd.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("Data Updated Succesfully");
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update");
            }
}

        private void SearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrWhiteSpace(SearchBox.Text))
            {
                searchCon();
            }
        }
    }
}
