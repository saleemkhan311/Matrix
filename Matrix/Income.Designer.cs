namespace Matrix
{
    partial class Income
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Income));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.DailyDataGrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MonthlyDataGrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.DailyLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.MonthlyLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.YearBox = new System.Windows.Forms.NumericUpDown();
            this.MonthDropDown = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DailyDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MonthlyDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearBox)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Bebas Neue", 18F);
            this.bunifuLabel1.Location = new System.Drawing.Point(10, 12);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(150, 36);
            this.bunifuLabel1.TabIndex = 19;
            this.bunifuLabel1.Text = "Manage Income";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // DailyDataGrid
            // 
            this.DailyDataGrid.AllowCustomTheming = false;
            this.DailyDataGrid.AllowUserToAddRows = false;
            this.DailyDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(196)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.DailyDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DailyDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DailyDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.DailyDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DailyDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DailyDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DailyDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DailyDataGrid.ColumnHeadersHeight = 40;
            this.DailyDataGrid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(196)))), ((int)(((byte)(206)))));
            this.DailyDataGrid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DailyDataGrid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DailyDataGrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(114)))), ((int)(((byte)(138)))));
            this.DailyDataGrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DailyDataGrid.CurrentTheme.BackColor = System.Drawing.Color.Crimson;
            this.DailyDataGrid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(184)))), ((int)(((byte)(196)))));
            this.DailyDataGrid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Crimson;
            this.DailyDataGrid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.DailyDataGrid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DailyDataGrid.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.DailyDataGrid.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DailyDataGrid.CurrentTheme.Name = null;
            this.DailyDataGrid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(208)))), ((int)(((byte)(216)))));
            this.DailyDataGrid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DailyDataGrid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DailyDataGrid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(114)))), ((int)(((byte)(138)))));
            this.DailyDataGrid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(208)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(114)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DailyDataGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.DailyDataGrid.EnableHeadersVisualStyles = false;
            this.DailyDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(184)))), ((int)(((byte)(196)))));
            this.DailyDataGrid.HeaderBackColor = System.Drawing.Color.Crimson;
            this.DailyDataGrid.HeaderBgColor = System.Drawing.Color.Empty;
            this.DailyDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.DailyDataGrid.Location = new System.Drawing.Point(7, 29);
            this.DailyDataGrid.Name = "DailyDataGrid";
            this.DailyDataGrid.ReadOnly = true;
            this.DailyDataGrid.RowHeadersVisible = false;
            this.DailyDataGrid.RowHeadersWidth = 51;
            this.DailyDataGrid.RowTemplate.Height = 40;
            this.DailyDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DailyDataGrid.Size = new System.Drawing.Size(354, 552);
            this.DailyDataGrid.TabIndex = 21;
            this.DailyDataGrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Crimson;
            this.DailyDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DailyDataGrid_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DailyDataGrid);
            this.groupBox1.Font = new System.Drawing.Font("Bebas Neue", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 588);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daily Income";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MonthlyDataGrid);
            this.groupBox2.Font = new System.Drawing.Font("Bebas Neue", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(403, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 588);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Monthly Income";
            // 
            // MonthlyDataGrid
            // 
            this.MonthlyDataGrid.AllowCustomTheming = false;
            this.MonthlyDataGrid.AllowUserToAddRows = false;
            this.MonthlyDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(196)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.MonthlyDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MonthlyDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.MonthlyDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.MonthlyDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MonthlyDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MonthlyDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bebas Neue", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MonthlyDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.MonthlyDataGrid.ColumnHeadersHeight = 40;
            this.MonthlyDataGrid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(196)))), ((int)(((byte)(206)))));
            this.MonthlyDataGrid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.MonthlyDataGrid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.MonthlyDataGrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(114)))), ((int)(((byte)(138)))));
            this.MonthlyDataGrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.MonthlyDataGrid.CurrentTheme.BackColor = System.Drawing.Color.Crimson;
            this.MonthlyDataGrid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(184)))), ((int)(((byte)(196)))));
            this.MonthlyDataGrid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Crimson;
            this.MonthlyDataGrid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.MonthlyDataGrid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.MonthlyDataGrid.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.MonthlyDataGrid.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.MonthlyDataGrid.CurrentTheme.Name = null;
            this.MonthlyDataGrid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(208)))), ((int)(((byte)(216)))));
            this.MonthlyDataGrid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.MonthlyDataGrid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.MonthlyDataGrid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(114)))), ((int)(((byte)(138)))));
            this.MonthlyDataGrid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(208)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(114)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MonthlyDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.MonthlyDataGrid.EnableHeadersVisualStyles = false;
            this.MonthlyDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(184)))), ((int)(((byte)(196)))));
            this.MonthlyDataGrid.HeaderBackColor = System.Drawing.Color.Crimson;
            this.MonthlyDataGrid.HeaderBgColor = System.Drawing.Color.Empty;
            this.MonthlyDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.MonthlyDataGrid.Location = new System.Drawing.Point(13, 29);
            this.MonthlyDataGrid.Name = "MonthlyDataGrid";
            this.MonthlyDataGrid.ReadOnly = true;
            this.MonthlyDataGrid.RowHeadersVisible = false;
            this.MonthlyDataGrid.RowHeadersWidth = 51;
            this.MonthlyDataGrid.RowTemplate.Height = 40;
            this.MonthlyDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MonthlyDataGrid.Size = new System.Drawing.Size(354, 552);
            this.MonthlyDataGrid.TabIndex = 21;
            this.MonthlyDataGrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Crimson;
            this.MonthlyDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MonthlyDataGrid_CellClick);
            // 
            // DailyLabel
            // 
            this.DailyLabel.AllowParentOverrides = false;
            this.DailyLabel.AutoEllipsis = false;
            this.DailyLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.DailyLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.DailyLabel.Font = new System.Drawing.Font("Bebas Neue", 13.8F);
            this.DailyLabel.Location = new System.Drawing.Point(22, 59);
            this.DailyLabel.Name = "DailyLabel";
            this.DailyLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DailyLabel.Size = new System.Drawing.Size(107, 28);
            this.DailyLabel.TabIndex = 19;
            this.DailyLabel.Text = "Select Month:";
            this.DailyLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.DailyLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // MonthlyLabel
            // 
            this.MonthlyLabel.AllowParentOverrides = false;
            this.MonthlyLabel.AutoEllipsis = false;
            this.MonthlyLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.MonthlyLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.MonthlyLabel.Font = new System.Drawing.Font("Bebas Neue", 13.8F);
            this.MonthlyLabel.Location = new System.Drawing.Point(403, 59);
            this.MonthlyLabel.Name = "MonthlyLabel";
            this.MonthlyLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MonthlyLabel.Size = new System.Drawing.Size(93, 28);
            this.MonthlyLabel.TabIndex = 19;
            this.MonthlyLabel.Text = "Select Year:";
            this.MonthlyLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.MonthlyLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(10, 39);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(768, 14);
            this.bunifuSeparator1.TabIndex = 23;
            // 
            // YearBox
            // 
            this.YearBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearBox.Location = new System.Drawing.Point(502, 53);
            this.YearBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(120, 34);
            this.YearBox.TabIndex = 25;
            this.YearBox.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.YearBox.ValueChanged += new System.EventHandler(this.YearBox_ValueChanged);
            // 
            // MonthDropDown
            // 
            this.MonthDropDown.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthDropDown.FormattingEnabled = true;
            this.MonthDropDown.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.MonthDropDown.Location = new System.Drawing.Point(135, 52);
            this.MonthDropDown.Name = "MonthDropDown";
            this.MonthDropDown.Size = new System.Drawing.Size(162, 40);
            this.MonthDropDown.TabIndex = 26;
            this.MonthDropDown.SelectedIndexChanged += new System.EventHandler(this.MonthDropDown_SelectedIndexChanged);
            // 
            // Income
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(790, 700);
            this.Controls.Add(this.MonthDropDown);
            this.Controls.Add(this.YearBox);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MonthlyLabel);
            this.Controls.Add(this.DailyLabel);
            this.Controls.Add(this.bunifuLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Income";
            this.Text = "Income";
            this.Load += new System.EventHandler(this.Income_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DailyDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MonthlyDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.UI.WinForms.BunifuDataGridView DailyDataGrid;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.UI.WinForms.BunifuDataGridView MonthlyDataGrid;
        private Bunifu.UI.WinForms.BunifuLabel MonthlyLabel;
        private Bunifu.UI.WinForms.BunifuLabel DailyLabel;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.NumericUpDown YearBox;
        private System.Windows.Forms.ComboBox MonthDropDown;
    }
}