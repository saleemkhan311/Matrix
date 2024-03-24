using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix
{
    public partial class ReceiptPanel : Form
    {
        public ReceiptPanel()
        {
            InitializeComponent();
        }

       
        public string member_Name 
        {
            get { return NameLabel.Text; } 
            set {  NameLabel.Text = value; } 
        }

        public string weight
        {
            get { return WeightLabel.Text; }
            set { WeightLabel.Text = value; }
        }

        public string Fees
        {
            get { return FeesLabel.Text; }
            set { FeesLabel.Text = value; }
        }

        public string dues
        {
            get { return DuesLabel.Text; }
            set { DuesLabel.Text = value; }
        }

        public string total
        {
            get { return TotalLabel.Text; }
            set { TotalLabel.Text = value; }
        }

        public string Membership
        {
            get { return MembershipLabel.Text; }
            set { MembershipLabel.Text = value; }
        }

        public string received
        {
            get { return ReceivedByLabel.Text; }
            set { ReceivedByLabel.Text = value; }
        }

        public string payment
        {
            get { return PaymentLabel.Text; }
            set { PaymentLabel.Text = value; }
        }

        public string renewal
        {
            get { return RenewalLabel.Text; }
            set { RenewalLabel.Text = value; }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void SaveReceiptButton_Click(object sender, EventArgs e)
        {
            try
            {
                string receipt_dir = "C:\\GYM_Matrix\\MembersReceipts\\" + member_Name + ".png";
                ImageFormat imgFormat = ImageFormat.Png;
                int width = ReceiptP.Width * 2;
                int height = ReceiptP.Height * 2; 

                Bitmap bmp = new Bitmap(ReceiptP.Width,ReceiptP.Height);

                using (Graphics g = Graphics.FromImage(bmp))
                {
                    //g.DrawImage(ReceiptP,0,0,width,hiegth);
                    g.ScaleTransform(2, 2);
                    ReceiptP.DrawToBitmap(bmp, new Rectangle(0, 0, ReceiptP.Width, ReceiptP.Height));
                }

                bmp.Save(receipt_dir,imgFormat);

                MessageBox.Show($"Receipt Has been Saved to {receipt_dir}");
                this.Close();
            }catch(Exception ex) {  MessageBox.Show(ex.Message,"Receipt Save"); }
        }

        private void PaymentLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
