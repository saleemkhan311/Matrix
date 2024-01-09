using Bunifu.UI.WinForms;
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
    public partial class Expenses : Form
    {
        public Expenses()
        {
            InitializeComponent();
        }

        int ID;
        private void Query()
        {
            try
            {

                using (MySqlConnection con = new MySqlConnection(AppSettings.ConString()))
                {
                    con.Open();

                    string query = "INSERT INTO expenses(ID,Expense_Name,Expense_Amount,Expense_Type,Discription,Expense_Date) VALUES (@ID,@Expense_Name,@Expense_Amount,@Expense_Type,@Discription,@Expense_Date)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Expense_Name", NameBox.Text);
                    cmd.Parameters.AddWithValue("@Expense_Amount", AmountBox.Text);
                    cmd.Parameters.AddWithValue("@Expense_Type", ExpenseTypeBox.Text);
                    cmd.Parameters.AddWithValue("@Discription", DescriptionBox.Text);
                    cmd.Parameters.AddWithValue("@Expense_Date", ExpenseDate.Value);
                    cmd.Parameters.AddWithValue("@ID", (GetLastID()+1));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Records Inserted Succesfully");
                    LoadData();
                }


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadData()
        {
            try
            {

                using (MySqlConnection con = new MySqlConnection(AppSettings.ConString()))
                {
                    con.Open();
                    string query = "SELECT * FROM expenses ORDER BY Expense_Date DESC;";
                    MySqlCommand cmd = new MySqlCommand(query,con);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    if(dt.Rows.Count > 0)
                    {
                        ExpenseDataGrid.DataSource = dt;
                    }
                }


            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private int GetLastID()
        {
            int lastID = 0;
            try
            {
                using (MySqlConnection con = new MySqlConnection(AppSettings.ConString()))
                {
                    con.Open();
                    string query = "SELECT ID FROM expenses ORDER BY ID DESC LIMIT 1;";

                    MySqlCommand cmd  = new MySqlCommand(query,con);

                    object result = cmd.ExecuteScalar();

                    if(result != null && result != DBNull.Value)
                    {
                        lastID = Convert.ToInt32(result);
                    }
                }


            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return lastID;
        }

        private void Expenses_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Query();
        }

        private void ExpenseDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32( ExpenseDataGrid.SelectedRows[0].Cells[0].Value.ToString());
                NameBox.Text = ExpenseDataGrid.SelectedRows[0].Cells[1].Value.ToString();
                AmountBox.Text = ExpenseDataGrid.SelectedRows[0].Cells[2].Value.ToString();
                ExpenseTypeBox.Text = ExpenseDataGrid.SelectedRows[0].Cells[3].Value.ToString();
                DescriptionBox.Text = ExpenseDataGrid.SelectedRows[0].Cells[4].Value.ToString();

                object expenseDateValue = ExpenseDataGrid.SelectedRows[0].Cells[5].Value;
                DateTime selectedExpenseDate;

                if(DateTime.TryParse(expenseDateValue.ToString(),out selectedExpenseDate))
                {
                    ExpenseDate.Value = selectedExpenseDate;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            remove();
        }

        private void remove()
        {
            try
            {
                using(MySqlConnection con = new MySqlConnection(AppSettings.ConString()))
                {
                    con.Open();
                    string query = "DELETE FROM expenses WHERE ID = @ID;";

                    MySqlCommand cmd;

                    cmd = con.CreateCommand();

                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    LoadData();
                    ClearBox();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearBox()
        {
            BunifuTextBox[] boxes = {NameBox, DescriptionBox,AmountBox};
            foreach(BunifuTextBox box in boxes)
            {
                box.Clear();
            }

            ExpenseTypeBox.Text = string.Empty;
            ExpenseDate.Value = DateTime.Now;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateValue();
        }

        private void UpdateValue()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(AppSettings.ConString()))
                {
                    con.Open();
                    string query = "UPDATE expenses SET ID=@ID , Expense_Name=@Expense_Name,Expense_Amount=@Expense_Amount,Expense_Type=@Expense_Type, Discription=@Discription, Expense_Date=@Expense_Date WHERE ID=@ID ";
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@Expense_Name", NameBox.Text);
                    cmd.Parameters.AddWithValue("@Expense_Amount", AmountBox.Text);
                    cmd.Parameters.AddWithValue("@Expense_Type", ExpenseTypeBox.Text);
                    cmd.Parameters.AddWithValue("@Discription", DescriptionBox.Text);
                    cmd.Parameters.AddWithValue("@Expense_Date", ExpenseDate.Value);
                   
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Updated Succesfully");
                    LoadData();
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearBox();
        }
    }
}
