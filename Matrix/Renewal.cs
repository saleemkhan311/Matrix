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
    public partial class Renewal : Form
    {
        public Renewal()
        {
            InitializeComponent();
        }
        private string img_Dir;
        int ID;
        private void LoadData()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(AppSettings.ConString()))
                {
                    con.Open();

                    string query = "SELECT * FROM addmembers ORDER BY Member_Name ASC;";

                    MySqlCommand cmd = con.CreateCommand();    
                    cmd.CommandText = query;

                    MySqlDataReader dr = cmd.ExecuteReader();
                     DataTable dt = new DataTable();    
                    dt.Load(dr);

                    if(dt.Rows.Count > 0)
                    {
                        MembersDataGrid.DataSource = dt;
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"LoadData");
            }
}

        private void Renewal_Load(object sender, EventArgs e)
        {
            LoadData();
            MembersDataGrid.DefaultCellStyle.Font = new Font("Segoe UI", 10,FontStyle.Bold);
        }

        private void MembersDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(MembersDataGrid.SelectedRows[0].Cells[0].Value.ToString());
            NameBox.Text = MembersDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            FatherBox.Text = MembersDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            PhoneBox.Text = MembersDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            GenderBox.Text = MembersDataGrid.SelectedRows[0].Cells[4].Value.ToString();
            WeightBox.Text = MembersDataGrid.SelectedRows[0].Cells[5].Value.ToString();
            MembershipBox.Text = MembersDataGrid.SelectedRows[0].Cells[6].Value.ToString();
            AgeBox.Text = MembersDataGrid.SelectedRows[0].Cells[7].Value.ToString();
            PaidBox.Text = MembersDataGrid.SelectedRows[0].Cells[8].Value.ToString();
            DuesBox.Text = MembersDataGrid.SelectedRows[0].Cells[9].Value.ToString();
            string img = MembersDataGrid.SelectedRows[0].Cells[14].Value.ToString();
            img_Dir = img;
            if(img != null && img.Length > 20)
            { ProfileBox.Image = Image.FromFile(img); }
            else { ProfileBox.Image = null; }
           
            object joiningDateValue = MembersDataGrid.SelectedRows[0].Cells[10].Value;
            DateTime selectedJoiningDate;
            if (DateTime.TryParse(joiningDateValue.ToString(), out selectedJoiningDate))
            {
                PaymentDate.Value = selectedJoiningDate;
            }
            object RenewaldateValue = MembersDataGrid.SelectedRows[0].Cells[11].Value;

            DateTime selectedDate;

            if (DateTime.TryParse(RenewaldateValue.ToString(), out selectedDate))
            {
                RenewalDate.Value = selectedDate;
            }

            object AddmissiondateValue = MembersDataGrid.SelectedRows[0].Cells[12].Value;

            DateTime selectedAddmisionDate;

            if (DateTime.TryParse(AddmissiondateValue.ToString(), out selectedAddmisionDate))
            {
                AddmissionDate.Value = selectedAddmisionDate;
            }
        }
        void QueryPayment()
        {
            try
            {


                MySqlConnection con = new MySqlConnection(AppSettings.ConString());
                con.Open();
                MySqlCommand cmd;
                cmd = con.CreateCommand();

                cmd.CommandText = "INSERT INTO payment (ID, Ref_No, Member_Name, Member_Father, Member_phone,Gender,Membership_type,Fee_Paid,Payment_Date,receivedby,Image_Dir) VALUES (@ID,@Ref_No,@Member_Name,@Member_Father,@Member_phone,@Gender,@Membership_type,@Fee_Paid,@Payment_Date,@receivedby,@Image_Dir);";

                cmd.Parameters.AddWithValue("@ID", (GetLastPayID() + 1));
                cmd.Parameters.AddWithValue("@Ref_No", ID);
                cmd.Parameters.AddWithValue("@Member_Name", NameBox.Text);
                cmd.Parameters.AddWithValue("@Member_Father", FatherBox.Text);
                cmd.Parameters.AddWithValue("@Member_Phone", PhoneBox.Text);
                cmd.Parameters.AddWithValue("@Gender", GenderBox.Text);
                cmd.Parameters.AddWithValue("@Membership_type", MembershipBox.Text);
                cmd.Parameters.AddWithValue("@Fee_Paid", PaidBox.Text);
                cmd.Parameters.AddWithValue("@Payment_Date", PaymentDate.Value);
                cmd.Parameters.AddWithValue("@receivedby", LoginPage.username);
                cmd.Parameters.AddWithValue("@Image_Dir", img_Dir);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted into Payment Ledger Succesfully");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message,"Query Payment"); }
        }

        private int GetLastPayID()
        {
            int lastID = 1;
            try
            {
                using (MySqlConnection con = new MySqlConnection(AppSettings.ConString()))
                {
                    con.Open();
                    string query = "SELECT ID FROM payment ORDER BY ID DESC LIMIT 1;";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                        lastID = (int)result;
                }
                }catch (Exception ex) { MessageBox.Show(ex.Message,"Get Last Pay ID"); }
                return lastID;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(AppSettings.ConString());
                con.Open();
                MySqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE addmembers SET ID=@ID, Member_Name=@Member_Name, Member_Father_Name=@Member_Father_Name, Member_phone=@Member_phone,Gender=@Gender,Weight=@Weight,Membership_type=@Membership_type,Member_Age=@Member_Age,Fee_Paid=@Fee_Paid,Dues=@Dues,Payment_Date=@Payment_Date,Renewal_Date=@Renewal_Date,Addmission_Date=@Addmission_Date,Image_Dir=@Image_Dir WHERE ID= @ID;";
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@Member_Name", NameBox.Text);
                cmd.Parameters.AddWithValue("@Member_Father_Name", FatherBox.Text);
                cmd.Parameters.AddWithValue("@Member_Phone", PhoneBox.Text);
                cmd.Parameters.AddWithValue("@Gender", GenderBox.Text);
                cmd.Parameters.AddWithValue("@Weight", WeightBox.Text);
                cmd.Parameters.AddWithValue("@Membership_type", MembershipBox.Text);
                cmd.Parameters.AddWithValue("@Member_Age", AgeBox.Text);
                cmd.Parameters.AddWithValue("@Fee_Paid", PaidBox.Text);
                cmd.Parameters.AddWithValue("@Dues", DuesBox.Text);
                cmd.Parameters.AddWithValue("@Payment_Date", PaymentDate.Value);
                cmd.Parameters.AddWithValue("@Renewal_Date", RenewalDate.Value);
                cmd.Parameters.AddWithValue("@Addmission_Date", AddmissionDate.Value);
                cmd.Parameters.AddWithValue("@Image_Dir", img_Dir);
                cmd.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("Data Updated Succesfully");
                QueryPayment();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Update");
            }
        }

        private void AddPicButton_Click(object sender, EventArgs e)
        {
            ProfilePanel profilePanel = new ProfilePanel(NameBox.Text);

            profilePanel.ShowDialog();
            img_Dir = ProfilePanel.img_Dir;
            ProfileBox.Image = Image.FromFile(img_Dir);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(AppSettings.ConString());
                con.Open();
                MySqlCommand cmd;

                cmd = con.CreateCommand();

                cmd.CommandText = "DELETE FROM addmembers WHERE ID=@ID;";
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                LoadData();
                ClearBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void ClearBox()
        {
            BunifuTextBox[] boxes = { NameBox, AgeBox, WeightBox, PaidBox, DuesBox, PhoneBox };
            foreach (BunifuTextBox box in boxes)
            {
                box.Clear();

            }
            GenderBox.Text = string.Empty;
            MembershipBox.Text = string.Empty;
            ProfileBox.Image = null;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearBox(); 
        }

        private void searchCon()
        {
            
            DataTable dataTable = new DataTable();
            if(SearchDateRad.Checked)
            {
                string x = SearchDate.Value.Date.ToString("yyyy-MM-dd");
               
                AppSettings.SearchControl("addmembers", "Payment_Date",x, dataTable);
            }else if(SearchNameRad.Checked)
            {
                AppSettings.SearchControl("addmembers", "Member_Name", SearchBox.Text, dataTable);
            }
            
            if(dataTable.Rows.Count > 0 )
            {
                MembersDataGrid.DataSource = dataTable;
            }
            else { LoadData(); }
        }

        private void SearchBox_OnIconRightClick(object sender, EventArgs e)
        {
            searchCon();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchBox.Text == string.Empty)
                LoadData();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            searchCon();
        }
    }
}
