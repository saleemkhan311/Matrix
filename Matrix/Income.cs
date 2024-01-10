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
    public partial class Income : Form
    {
        public object Id2 { get; private set; }
        public object Id1 { get; private set; }

        public Income()
        {
            InitializeComponent();
        }

        private void Income_Load(object sender, EventArgs e)
        {
            LoadDataMonthly();
            MonthDropDown.SelectedIndex = 0;

           /* DailyLabel.Text = $"Today's Income: {DailyIncome()}";
            string CurrentMonth = DateTime.Now.ToString("MMMM");
            MonthlyLabel.Text = $"{CurrentMonth}'s Income: {MonthlyIncome()}";*/
        }

        private void LoadDataDaily()
        {
            try
            {
                int m = (MonthDropDown.SelectedIndex)+1;
                //MessageBox.Show(m.ToString());
                using (MySqlConnection con = new MySqlConnection(AppSettings.ConString()))
                {
                    con.Open();
                    string query = $"SELECT \r\n    SUM(Fee_Paid) AS Amount,\r\n    DATE(Payment_Date) AS Date\r\nFROM \r\n    payment \r\nWHERE \r\n    MONTH(Payment_Date) = {m}\r\nGROUP BY \r\n    DATE(Payment_Date)\r\nORDER BY \r\n    DATE(Payment_Date) ASC;";
                    //MessageBox.Show(query);
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    if (dt.Rows.Count > 0)
                    {
                        DailyDataGrid.DataSource = dt;
                    }
                }


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void LoadDataMonthly()
        {
            try
            {


                using (MySqlConnection con = new MySqlConnection(AppSettings.ConString()))
                {

                    con.Open();
                    string query = $"SELECT \r\n    SUM(Fee_Paid) AS Amount,\r\n    DATE(Payment_Date) AS Date,\r\n    MONTH(Payment_Date) AS Month\r\nFROM \r\n    payment \r\nWHERE \r\n    YEAR(Payment_Date) = {YearBox.Value}\r\nGROUP BY \r\n    YEAR(Payment_Date),\r\n    MONTH(Payment_Date)\r\nORDER BY \r\n    MONTH(Payment_Date) ASC;";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    if (dt.Rows.Count > 0)
                    {
                        MonthlyDataGrid.DataSource = dt;
                    }
                }


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            QueryDaily();
        }
        private void QueryDaily()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(AppSettings.ConString()))
                {
                    con.Open();

                    string query = "INSERT INTO dailyincome (ID,Amount,Date) VALUES (@ID,@Amount,@Date)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ID", (GetLastID_Daily() + 1));
                    cmd.Parameters.AddWithValue("@Amount", DailyAmountBox.Text);
                    cmd.Parameters.AddWithValue("@Date",DailyIncomeDate.Value);
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Records Inserted Succesfully");
                    LoadDataDaily();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void QueryMonthly()
        {
            /*try
            {*/
                using (MySqlConnection con = new MySqlConnection(AppSettings.ConString()))
                {
                    con.Open();

                    string query = "INSERT INTO monthlyincome (ID,Amount,Month,Date) VALUES (@ID,@Amount,@Month,@Date)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ID", (GetLastID_Monthly() + 1));
                    cmd.Parameters.AddWithValue("@Amount", MonthlyAmountBox.Text);
                    cmd.Parameters.AddWithValue("@Month", MonthBox.Text);
                    cmd.Parameters.AddWithValue("@Date", MonthlyIncomeDate.Value);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Records Inserted Succesfully");
                    LoadDataMonthly();
                }
            /*}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private int GetLastID_Daily()
        {
            int lastID = 0;
            try
            {
                using (MySqlConnection con = new MySqlConnection(AppSettings.ConString()))
                {
                    con.Open();
                    string query = "SELECT ID FROM dailyincome ORDER BY ID DESC LIMIT 1;";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                        lastID = Convert.ToInt32(result);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return lastID;
        }

        private int GetLastID_Monthly()
        {
            int lastID = 0;
            try
            {
                using (MySqlConnection con = new MySqlConnection(AppSettings.ConString()))
                {
                    con.Open();
                    string query = "SELECT ID FROM Monthlyincome ORDER BY ID DESC LIMIT 1;";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                        lastID = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return lastID;
        }

        private void AddMonthlyButton_Click(object sender, EventArgs e)
        {
            QueryMonthly();
        }

        private void removeDaily()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(AppSettings.ConString()))
                {
                    con.Open();
                    string query = "DELETE FROM dailyincome WHERE ID = @ID;";

                    MySqlCommand cmd;

                    cmd = con.CreateCommand();

                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@ID", Id1);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    LoadDataDaily();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void removeMonthly()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(AppSettings.ConString()))
                {
                    con.Open();
                    string query = "DELETE FROM monthlyincome WHERE ID = @ID;";

                    MySqlCommand cmd;

                    cmd = con.CreateCommand();

                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@ID", Id2);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    LoadDataMonthly();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteDailyButton_Click(object sender, EventArgs e)
        {
            removeDaily();
        }

        private void DeleteMonthlyButton_Click(object sender, EventArgs e)
        {
            removeMonthly();
        }

        private void UpdateDailyButton_Click(object sender, EventArgs e)
        {
            UpdateDaily();
        }

        private void UpdateDaily()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(AppSettings.ConString()))
                {
                    con.Open();
                    string query = "UPDATE dailyincome SET ID=@ID,Amount=@Amount,Date=@Date WHERE ID=@ID ";
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@ID", Id1);
                    cmd.Parameters.AddWithValue("@Amount", DailyAmountBox.Text);
                    cmd.Parameters.AddWithValue("@Date", DailyIncomeDate.Value);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Updated Succesfully");
                    LoadDataDaily();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateMonthly()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(AppSettings.ConString()))
                {
                    con.Open();
                    string query = "UPDATE monthlyincome SET ID=@ID,Amount=@Amount,Month=@Month,Date=@Date WHERE ID=@ID ";
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@ID", Id2);
                    cmd.Parameters.AddWithValue("@Amount", MonthlyAmountBox.Text);
                    cmd.Parameters.AddWithValue("@Month", MonthBox.Text);
                    cmd.Parameters.AddWithValue("@Date",MonthlyIncomeDate.Value);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Updated Succesfully");
                    LoadDataMonthly();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateMonthlyButton_Click(object sender, EventArgs e)
        {
            UpdateMonthly();
        }

        private void DailyDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Id1 = Convert.ToInt32(DailyDataGrid.SelectedRows[0].Cells[0].Value.ToString());
                DailyAmountBox.Text = DailyDataGrid.SelectedRows[0].Cells[1].Value.ToString();

                object expenseDateValue = DailyDataGrid.SelectedRows[0].Cells[2].Value;
                DateTime selectedIncomeDate;

                if (DateTime.TryParse(expenseDateValue.ToString(), out selectedIncomeDate))
                {
                    DailyIncomeDate.Value = selectedIncomeDate;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MonthlyDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Id2 = Convert.ToInt32(MonthlyDataGrid.SelectedRows[0].Cells[0].Value.ToString());
                MonthlyAmountBox.Text = MonthlyDataGrid.SelectedRows[0].Cells[1].Value.ToString();
                MonthBox.Text = MonthlyDataGrid.SelectedRows[0].Cells[2].Value.ToString();

                object expenseDateValue = MonthlyDataGrid.SelectedRows[0].Cells[3].Value;
                DateTime selectedIncomeDate;

                if (DateTime.TryParse(expenseDateValue.ToString(), out selectedIncomeDate))
                {
                    MonthlyIncomeDate.Value = selectedIncomeDate;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int DailyIncome()
        {
            int daily = 0;
            try
            {
                using (MySqlConnection con = new MySqlConnection(AppSettings.ConString()))
                {
                    con.Open();
                    string query = "SELECT Fee_Paid FROM addmembers WHERE Payment_Date = CURRENT_DATE;\r\n";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                        daily = Convert.ToInt32(result);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return daily;
        }

        private int MonthlyIncome()
        {
            int Monthly = 0;
            try
            {
                using (MySqlConnection con = new MySqlConnection(AppSettings.ConString()))
                {
                    con.Open();
                    string query = @"SELECT SUM(Fee_Paid) AS Monthly_Income
                                        FROM addmembers
                                        WHERE MONTH(Payment_Date) = MONTH(CURRENT_DATE);";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                        Monthly = Convert.ToInt32(result);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return Monthly;
        }

        private void DailyLabel_Click(object sender, EventArgs e)
        {
            DailyAmountBox.Text = DailyIncome().ToString();
            DailyIncomeDate.Value = DateTime.Now;
        }

        private void MonthlyLabel_Click(object sender, EventArgs e)
        {
            MonthlyAmountBox.Text = MonthlyIncome().ToString();
            MonthBox.Text = DateTime.Now.ToString("MMMM");
            MonthlyIncomeDate.Value = DateTime.Now;
        }

        private void MonthDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataDaily();
        }

        private void YearBox_ValueChanged(object sender, EventArgs e)
        {
            LoadDataMonthly();
        }
    }
}
