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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            FullDataPanel.Hide();
            ExpiringBox.Value = 4;
            
            GetTotalValues();
            GetIncome();
            GetCurrentRevenue();
            GetExpiring();
            GetExpired();
            GetDues();
        }

        private void GetCurrentRevenue()
        {
            try
            {
                int revenue = 0;
                using(MySqlConnection conn = new MySqlConnection(AppSettings.ConString()))
                {
                    conn.Open();
                    string query = @"SELECT
                                    ((SELECT SUM(Fee_Paid) FROM payment WHERE MONTH(Payment_Date) = MONTH(CURRENT_DATE)) - 
                                     (SELECT SUM(Expense_Amount) FROM expenses WHERE MONTH(Expense_Date) = MONTH(CURRENT_DATE))) AS Revenue;";

                    MySqlCommand cmd = new MySqlCommand(query,conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        revenue = reader.GetInt32(0);
                    }
                }

                RevenueLabel.Text = revenue.ToString("C");

            }catch (Exception ex) { MessageBox.Show(ex.Message, "Get Current Revenue"); }
        }

        private void GetIncome()
        {
            int totalMale = 0;
            int totalFemale=0;
            try
            {
                using(MySqlConnection conn = new MySqlConnection(AppSettings.ConString()))
                {
                    conn.Open();
                    string query = @"SELECT 
	                                SUM(CASE WHEN Gender='Female'AND MONTH(Payment_Date)=MONTH(CURRENT_DATE) THEN Fee_Paid ELSE 0 END) AS Income_Ladies,
                                    SUM(CASE WHEN Gender='Male'AND MONTH(Payment_Date)=MONTH(CURRENT_DATE) THEN Fee_Paid ELSE 0 END) AS Income_Gents
                                    FROM
                                    payment;";

                    MySqlCommand cmd = new MySqlCommand(query, conn);   

                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        totalFemale = reader.GetInt32(0);
                        totalMale = reader.GetInt32(1);
                    }

                    IncomeGentsLabel.Text = totalMale.ToString("C");
                    IncomeLadiesLabel.Text = totalFemale.ToString("C");

                }
            }catch (Exception ex) { MessageBox.Show(ex.Message, "GetIncome"); }
        }

        private void GetTotalValues()
        {
            int total = 0;
            int male=0;
            int female = 0;
            try
            {
                using (MySqlConnection con = new MySqlConnection(AppSettings.ConString()))
                {
                    con.Open();
                    string query = @"SELECT 
                                        COUNT(Member_Name) AS Total_Members,
                                        SUM(CASE WHEN Gender = 'Male' THEN 1 ELSE 0 END) AS Total_Male_Members,
                                        SUM(CASE WHEN Gender = 'Female' THEN 1 ELSE 0 END) AS Total_Female_Members
                                    FROM 
                                        addmembers; ";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if(reader.Read())
                    {
                        total = reader.GetInt32(0);
                        male = reader.GetInt32(1);
                        female = reader.GetInt32(2);
                    }

                }

              
                TotalMembersLabel.Text = total.ToString();
                TotalFemaleLabel.Text = female.ToString();
                TotalMaleLabel.Text = male.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Values");
            }
        }

        private void GetExpiring()
        {
            try
            {
                using(MySqlConnection con = new MySqlConnection(AppSettings.ConString()))
                { con.Open();
                    int dif = (int)ExpiringBox.Value;
                    string query = $"SELECT * FROM addmembers WHERE DATEDIFF(Renewal_Date, CURRENT_DATE) >= 0 AND DATEDIFF(Renewal_Date, CURRENT_DATE)<= {dif};";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    if(dt.Rows.Count > 0 )
                    {
                        ExpiringDataGrid.DataSource = dt;
                        ExpiringFDataGrid.DataSource = dt;
                    }
                }

            }catch(Exception ex) { MessageBox.Show(ex.Message, "GetExpiring"); }

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
                        ExpiredDataGrid.DataSource = dt;
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
                        DuesDataGrid.DataSource = dt;
                        DuesFDataGrid.DataSource = dt;
                    }
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "GetDues"); }

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            GetTotalValues();
            GetIncome();
            GetCurrentRevenue();
            GetExpiring();
            GetExpired();
            GetDues();
        }

        private void FullDataButton_Click(object sender, EventArgs e)
        {
            FullDataPanel.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            FullDataPanel.Hide();
        }

        private void Expiring_ValueChanged(object sender, EventArgs e)
        {
            GetExpiring();
            ExpiringLabel.Text = $"Members Expiring in {ExpiringBox.Value} days";
        }
    }
}