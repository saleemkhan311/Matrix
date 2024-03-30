using Bunifu.UI.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Matrix
{
    public partial class AddMembers : Form
    {
        private string img_Dir="";

        public AddMembers()
        {
            InitializeComponent();
        }
        

        private void bunifuDatePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            
            if (notEmpty())
            {
                Query();
                ClearBox();
            }
            else
            { MessageBox.Show("Fill out necessary Boxes"); }
            
        }

        private bool notEmpty()
        {
            BunifuTextBox[] boxes = { NameBox, WeightBox, PaidBox, DuesBox, PhoneBox };
            bool notEmty = false;
            if (GenderBox.SelectedIndex >=0 && MembershipBox.SelectedIndex >= 0)
            {
                foreach (BunifuTextBox box in boxes)
                {
                    if (box.Text == string.Empty)
                    {
                        notEmty = false;
                    }
                    else{ notEmty = true; }

                }
            }
            return notEmty;
        }



        void Query()
        {
            /*try
            {*/

                MySqlConnection con = new MySqlConnection(AppSettings.ConString());
                con.Open();
                MySqlCommand cmd;
                cmd = con.CreateCommand();

                cmd.CommandText = "INSERT INTO addmembers(ID, Member_Name, Member_Father_Name, Member_phone,Gender,Weight,Membership_type,Fee_Paid,Dues,Payment_Date,Renewal_Date,Addmission_Date,Payment_Type,Description,Image_Dir,receivedby) VALUES (@ID,@Member_Name,@Member_Father_Name,@Member_phone,@Gender,@Weight,@Membership_type,@Fee_Paid,@Dues,@Payment_Date,@Renewal_Date,@Addmission_Date,@Payment_Type,@Description,@Image_Dir,@receivedby);";

                cmd.Parameters.AddWithValue("@ID", (GetLastID()+1));
                cmd.Parameters.AddWithValue("@Member_Name", NameBox.Text);
                cmd.Parameters.AddWithValue("@Member_Father_Name", FatherBox.Text);
                cmd.Parameters.AddWithValue("@Member_Phone", PhoneBox.Text);
                cmd.Parameters.AddWithValue("@Gender", GenderBox.Text);
                cmd.Parameters.AddWithValue("@Weight", WeightBox.Text);
                cmd.Parameters.AddWithValue("@Membership_type", MembershipBox.Text);
                cmd.Parameters.AddWithValue("@Fee_Paid", PaidBox.Text);
                cmd.Parameters.AddWithValue("@Dues", DuesBox.Text);
                cmd.Parameters.AddWithValue("@Payment_Type", PaymentType.Text);
                cmd.Parameters.AddWithValue("@Description", Description.Text);
                cmd.Parameters.AddWithValue("@Payment_Date", PaymentDate.Value);
                cmd.Parameters.AddWithValue("@Renewal_Date", RenewalDate.Value);
                cmd.Parameters.AddWithValue("@Addmission_Date", AddmissionDate.Value);
                cmd.Parameters.AddWithValue("@receivedby", LoginPage.username);
                cmd.Parameters.AddWithValue("@Image_Dir", img_Dir);
                cmd.ExecuteNonQuery();
                QueryPayment();
                MessageBox.Show("Data Inserted Succesfully");
            //}catch(Exception ex) { MessageBox.Show(ex.Message,"Query Payment"); }
        }

        private int GetLastID()
        {
            int lastID = 1;

            try
            {
                using(MySqlConnection con = new MySqlConnection(AppSettings.ConString()))
                {
                    con.Open();
                    string query = "SELECT ID FROM addmembers ORDER BY ID DESC LIMIT 1;";

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {

                        lastID = (int)result;
                    }
                }

            }catch(Exception ex) { MessageBox.Show(ex.Message, "GetLastID");}

            return lastID;
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
                cmd.Parameters.AddWithValue("@Ref_No",(GetLastID() + 1));
                cmd.Parameters.AddWithValue("@Member_Name", NameBox.Text);
                cmd.Parameters.AddWithValue("@Member_Father", FatherBox.Text);
                cmd.Parameters.AddWithValue("@Member_Phone", PhoneBox.Text);
                cmd.Parameters.AddWithValue("@Gender", GenderBox.Text);
                cmd.Parameters.AddWithValue("@Membership_type", MembershipBox.Text);
                cmd.Parameters.AddWithValue("@Fee_Paid", PaidBox.Text);
                cmd.Parameters.AddWithValue("@Payment_Date", PaymentDate.Value);
                cmd.Parameters.AddWithValue("@Payment_Type", PaymentType.Text);
                cmd.Parameters.AddWithValue("@Description", Description.Text);
                cmd.Parameters.AddWithValue("@receivedby", LoginPage.username);
                cmd.Parameters.AddWithValue("@Image_Dir", img_Dir);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted into Payment Ledger Succesfully");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Query Payment"); }
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
                    {

                        lastID = (int)result;
                    }
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "GetLastPayID"); }

            return lastID;
        }

        private void AddPicButton_Click(object sender, EventArgs e)
        {
            if (NameBox.Text != string.Empty)
            { pic(); }
            else { MessageBox.Show("Fill the Name Box to take Picture"); }
        }
        private void pic()
        {
            ProfilePanel profilePanel = new ProfilePanel(NameBox.Text);
            profilePanel.ShowDialog();
            if (ProfilePanel.img_Dir != null && ProfilePanel.img_Dir.Length > 20)
            {
                img_Dir = ProfilePanel.img_Dir;
                ProfileBox.Image = System.Drawing.Image.FromFile(img_Dir);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearBox();
        }

        void ClearBox()
        {
            BunifuTextBox[] boxes = { NameBox,FatherBox,  WeightBox, PaidBox, DuesBox, PhoneBox };
            foreach (BunifuTextBox box in boxes)
            {
                box.Clear();

            }
            GenderBox.Text = "";
            MembershipBox.Text = string.Empty;
            ProfileBox.Image = null;
        }

        private void ReceiptButton_Click(object sender, EventArgs e)
        {
            if(notEmpty())
            { GenReceipt(); }
            else { MessageBox.Show("Fill out the form to Generate Receipt"); }

        }

        private void GenReceipt()
        {
            ReceiptPanel receipt = new ReceiptPanel();

            receipt.payment = PaymentDate.Value.ToString("dd-MM-yyyy");
            receipt.renewal = RenewalDate.Value.ToString("dd-MM-yyyy");
            receipt.member_Name = NameBox.Text;
            receipt.weight = WeightBox.Text;
            receipt.Fees = PaidBox.Text;
            receipt.dues = DuesBox.Text;
            receipt.Membership = MembershipBox.Text;
            receipt.total = PaidBox.Text;
            receipt.received = LoginPage.username;
            receipt.ShowDialog();
        }

        private void PaidBox_TextChanged(object sender, EventArgs e)
        {
            AppSettings.NumericOnly(PaidBox);
        }

        private void PhoneBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DuesBox_TextChanged(object sender, EventArgs e)
        {
            AppSettings.NumericOnly(DuesBox);
        }

        private void WeightBox_TextChanged(object sender, EventArgs e)
        {
            AppSettings.NumericOnly(WeightBox);
        }

   
        private void PaymentDate_ValueChanged(object sender, EventArgs e)
        {
           RenewalDate.Value = PaymentDate.Value.AddMonths(1);
        }

        private void bunifuLabel8_Click(object sender, EventArgs e)
        {

        }
    }
}
