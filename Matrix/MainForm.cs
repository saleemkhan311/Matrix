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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void loadForm(object Form)
        {
            if (this.MainPanel.Controls.Count > 0)
            {
                this.MainPanel.Controls.RemoveAt(0);

            }
            Form f = Form as Form;

            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = f;
            f.Show();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loadForm(new Dashboard());
            //DashboardButton.ActiveControl =true;
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            loadForm(new Dashboard());
        }

        private void MembersButton_Click(object sender, EventArgs e)
        {
            loadForm(new AddMembers()); 
        }

        private void RenewButton_Click(object sender, EventArgs e)
        {
            loadForm(new Renewal());
        }

        private void ExpenseButton_Click(object sender, EventArgs e)
        {
            loadForm(new Expenses());
        }

        private void IncomeButton_Click(object sender, EventArgs e)
        {
            loadForm(new Income());
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            loadForm(new Users());
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeAppButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PaymentButton_Click(object sender, EventArgs e)
        {
            loadForm(new Payment());
        }

        private void Update_Click(object sender, EventArgs e)
        {
            loadForm(new Update());
        }
    }
}
