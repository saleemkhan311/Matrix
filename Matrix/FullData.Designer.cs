namespace Matrix
{
    partial class FullData
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FullData));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.DuesFDataGrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.ExpiredFDataGrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.ExpiringFDataGrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.CloseButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.ReminderFButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.DuesFDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpiredFDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpiringFDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Bebas", 15.75F);
            this.bunifuLabel3.Location = new System.Drawing.Point(12, 437);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(148, 25);
            this.bunifuLabel3.TabIndex = 8;
            this.bunifuLabel3.Text = "Members with dues";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Bebas", 15.75F);
            this.bunifuLabel2.Location = new System.Drawing.Point(12, 237);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(130, 25);
            this.bunifuLabel2.TabIndex = 9;
            this.bunifuLabel2.Text = "Expired Members";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Bebas", 15.75F);
            this.bunifuLabel1.Location = new System.Drawing.Point(12, 22);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(208, 25);
            this.bunifuLabel1.TabIndex = 10;
            this.bunifuLabel1.Text = "Members Expiring in 7 days";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // DuesFDataGrid
            // 
            this.DuesFDataGrid.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(196)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DuesFDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DuesFDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DuesFDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DuesFDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.DuesFDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DuesFDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DuesFDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DuesFDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DuesFDataGrid.ColumnHeadersHeight = 40;
            this.DuesFDataGrid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(196)))), ((int)(((byte)(206)))));
            this.DuesFDataGrid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DuesFDataGrid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DuesFDataGrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(114)))), ((int)(((byte)(138)))));
            this.DuesFDataGrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DuesFDataGrid.CurrentTheme.BackColor = System.Drawing.Color.Crimson;
            this.DuesFDataGrid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(184)))), ((int)(((byte)(196)))));
            this.DuesFDataGrid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Crimson;
            this.DuesFDataGrid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.DuesFDataGrid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DuesFDataGrid.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.DuesFDataGrid.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DuesFDataGrid.CurrentTheme.Name = null;
            this.DuesFDataGrid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(208)))), ((int)(((byte)(216)))));
            this.DuesFDataGrid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DuesFDataGrid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DuesFDataGrid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(114)))), ((int)(((byte)(138)))));
            this.DuesFDataGrid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(208)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(114)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DuesFDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.DuesFDataGrid.EnableHeadersVisualStyles = false;
            this.DuesFDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(184)))), ((int)(((byte)(196)))));
            this.DuesFDataGrid.HeaderBackColor = System.Drawing.Color.Crimson;
            this.DuesFDataGrid.HeaderBgColor = System.Drawing.Color.Empty;
            this.DuesFDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.DuesFDataGrid.Location = new System.Drawing.Point(12, 468);
            this.DuesFDataGrid.Name = "DuesFDataGrid";
            this.DuesFDataGrid.RowHeadersVisible = false;
            this.DuesFDataGrid.RowTemplate.Height = 40;
            this.DuesFDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DuesFDataGrid.Size = new System.Drawing.Size(766, 171);
            this.DuesFDataGrid.TabIndex = 5;
            this.DuesFDataGrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Crimson;
            // 
            // ExpiredFDataGrid
            // 
            this.ExpiredFDataGrid.AllowCustomTheming = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(196)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.ExpiredFDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ExpiredFDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ExpiredFDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ExpiredFDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.ExpiredFDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExpiredFDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ExpiredFDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExpiredFDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ExpiredFDataGrid.ColumnHeadersHeight = 40;
            this.ExpiredFDataGrid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(196)))), ((int)(((byte)(206)))));
            this.ExpiredFDataGrid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ExpiredFDataGrid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.ExpiredFDataGrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(114)))), ((int)(((byte)(138)))));
            this.ExpiredFDataGrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.ExpiredFDataGrid.CurrentTheme.BackColor = System.Drawing.Color.Crimson;
            this.ExpiredFDataGrid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(184)))), ((int)(((byte)(196)))));
            this.ExpiredFDataGrid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Crimson;
            this.ExpiredFDataGrid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.ExpiredFDataGrid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ExpiredFDataGrid.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.ExpiredFDataGrid.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.ExpiredFDataGrid.CurrentTheme.Name = null;
            this.ExpiredFDataGrid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(208)))), ((int)(((byte)(216)))));
            this.ExpiredFDataGrid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ExpiredFDataGrid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.ExpiredFDataGrid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(114)))), ((int)(((byte)(138)))));
            this.ExpiredFDataGrid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(208)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(114)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ExpiredFDataGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.ExpiredFDataGrid.EnableHeadersVisualStyles = false;
            this.ExpiredFDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(184)))), ((int)(((byte)(196)))));
            this.ExpiredFDataGrid.HeaderBackColor = System.Drawing.Color.Crimson;
            this.ExpiredFDataGrid.HeaderBgColor = System.Drawing.Color.Empty;
            this.ExpiredFDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.ExpiredFDataGrid.Location = new System.Drawing.Point(12, 268);
            this.ExpiredFDataGrid.Name = "ExpiredFDataGrid";
            this.ExpiredFDataGrid.RowHeadersVisible = false;
            this.ExpiredFDataGrid.RowTemplate.Height = 40;
            this.ExpiredFDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ExpiredFDataGrid.Size = new System.Drawing.Size(766, 171);
            this.ExpiredFDataGrid.TabIndex = 6;
            this.ExpiredFDataGrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Crimson;
            // 
            // ExpiringFDataGrid
            // 
            this.ExpiringFDataGrid.AllowCustomTheming = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(196)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.ExpiringFDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.ExpiringFDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ExpiringFDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ExpiringFDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.ExpiringFDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExpiringFDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ExpiringFDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExpiringFDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.ExpiringFDataGrid.ColumnHeadersHeight = 40;
            this.ExpiringFDataGrid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(196)))), ((int)(((byte)(206)))));
            this.ExpiringFDataGrid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ExpiringFDataGrid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.ExpiringFDataGrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(114)))), ((int)(((byte)(138)))));
            this.ExpiringFDataGrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.ExpiringFDataGrid.CurrentTheme.BackColor = System.Drawing.Color.Crimson;
            this.ExpiringFDataGrid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(184)))), ((int)(((byte)(196)))));
            this.ExpiringFDataGrid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Crimson;
            this.ExpiringFDataGrid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.ExpiringFDataGrid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ExpiringFDataGrid.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.ExpiringFDataGrid.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.ExpiringFDataGrid.CurrentTheme.Name = null;
            this.ExpiringFDataGrid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(208)))), ((int)(((byte)(216)))));
            this.ExpiringFDataGrid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ExpiringFDataGrid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.ExpiringFDataGrid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(114)))), ((int)(((byte)(138)))));
            this.ExpiringFDataGrid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(208)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(114)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ExpiringFDataGrid.DefaultCellStyle = dataGridViewCellStyle9;
            this.ExpiringFDataGrid.EnableHeadersVisualStyles = false;
            this.ExpiringFDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(184)))), ((int)(((byte)(196)))));
            this.ExpiringFDataGrid.HeaderBackColor = System.Drawing.Color.Crimson;
            this.ExpiringFDataGrid.HeaderBgColor = System.Drawing.Color.Empty;
            this.ExpiringFDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.ExpiringFDataGrid.Location = new System.Drawing.Point(12, 53);
            this.ExpiringFDataGrid.Name = "ExpiringFDataGrid";
            this.ExpiringFDataGrid.RowHeadersVisible = false;
            this.ExpiringFDataGrid.RowTemplate.Height = 40;
            this.ExpiringFDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ExpiringFDataGrid.Size = new System.Drawing.Size(766, 171);
            this.ExpiringFDataGrid.TabIndex = 7;
            this.ExpiringFDataGrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Crimson;
            // 
            // CloseButton
            // 
            this.CloseButton.ActiveImage = null;
            this.CloseButton.AllowAnimations = true;
            this.CloseButton.AllowBuffering = false;
            this.CloseButton.AllowToggling = false;
            this.CloseButton.AllowZooming = true;
            this.CloseButton.AllowZoomingOnFocus = false;
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CloseButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.ErrorImage")));
            this.CloseButton.FadeWhenInactive = false;
            this.CloseButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.CloseButton.Image = global::Matrix.Properties.Resources.arrow_down;
            this.CloseButton.ImageActive = null;
            this.CloseButton.ImageLocation = null;
            this.CloseButton.ImageMargin = 0;
            this.CloseButton.ImageSize = new System.Drawing.Size(29, 29);
            this.CloseButton.ImageZoomSize = new System.Drawing.Size(30, 30);
            this.CloseButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.InitialImage")));
            this.CloseButton.Location = new System.Drawing.Point(746, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Rotation = 0;
            this.CloseButton.ShowActiveImage = true;
            this.CloseButton.ShowCursorChanges = true;
            this.CloseButton.ShowImageBorders = true;
            this.CloseButton.ShowSizeMarkers = false;
            this.CloseButton.Size = new System.Drawing.Size(30, 30);
            this.CloseButton.TabIndex = 12;
            this.CloseButton.ToolTipText = "";
            this.CloseButton.WaitOnLoad = false;
            this.CloseButton.Zoom = 0;
            this.CloseButton.ZoomSpeed = 10;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ReminderFButton
            // 
            this.ReminderFButton.AllowAnimations = true;
            this.ReminderFButton.AllowMouseEffects = true;
            this.ReminderFButton.AllowToggling = false;
            this.ReminderFButton.AnimationSpeed = 200;
            this.ReminderFButton.AutoGenerateColors = false;
            this.ReminderFButton.AutoRoundBorders = false;
            this.ReminderFButton.AutoSizeLeftIcon = true;
            this.ReminderFButton.AutoSizeRightIcon = true;
            this.ReminderFButton.BackColor = System.Drawing.Color.Transparent;
            this.ReminderFButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.ReminderFButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReminderFButton.BackgroundImage")));
            this.ReminderFButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ReminderFButton.ButtonText = "Send Reminder";
            this.ReminderFButton.ButtonTextMarginLeft = 0;
            this.ReminderFButton.ColorContrastOnClick = 45;
            this.ReminderFButton.ColorContrastOnHover = 45;
            this.ReminderFButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.ReminderFButton.CustomizableEdges = borderEdges1;
            this.ReminderFButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ReminderFButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ReminderFButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ReminderFButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ReminderFButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.ReminderFButton.Font = new System.Drawing.Font("Bebas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReminderFButton.ForeColor = System.Drawing.Color.White;
            this.ReminderFButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReminderFButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.ReminderFButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.ReminderFButton.IconMarginLeft = 11;
            this.ReminderFButton.IconPadding = 10;
            this.ReminderFButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReminderFButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.ReminderFButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.ReminderFButton.IconSize = 25;
            this.ReminderFButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.ReminderFButton.IdleBorderRadius = 15;
            this.ReminderFButton.IdleBorderThickness = 1;
            this.ReminderFButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.ReminderFButton.IdleIconLeftImage = null;
            this.ReminderFButton.IdleIconRightImage = null;
            this.ReminderFButton.IndicateFocus = false;
            this.ReminderFButton.Location = new System.Drawing.Point(648, 230);
            this.ReminderFButton.Name = "ReminderFButton";
            this.ReminderFButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ReminderFButton.OnDisabledState.BorderRadius = 15;
            this.ReminderFButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ReminderFButton.OnDisabledState.BorderThickness = 1;
            this.ReminderFButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ReminderFButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ReminderFButton.OnDisabledState.IconLeftImage = null;
            this.ReminderFButton.OnDisabledState.IconRightImage = null;
            this.ReminderFButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ReminderFButton.onHoverState.BorderRadius = 15;
            this.ReminderFButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ReminderFButton.onHoverState.BorderThickness = 1;
            this.ReminderFButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ReminderFButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.ReminderFButton.onHoverState.IconLeftImage = null;
            this.ReminderFButton.onHoverState.IconRightImage = null;
            this.ReminderFButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.ReminderFButton.OnIdleState.BorderRadius = 15;
            this.ReminderFButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ReminderFButton.OnIdleState.BorderThickness = 1;
            this.ReminderFButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.ReminderFButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.ReminderFButton.OnIdleState.IconLeftImage = null;
            this.ReminderFButton.OnIdleState.IconRightImage = null;
            this.ReminderFButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.ReminderFButton.OnPressedState.BorderRadius = 15;
            this.ReminderFButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ReminderFButton.OnPressedState.BorderThickness = 1;
            this.ReminderFButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.ReminderFButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.ReminderFButton.OnPressedState.IconLeftImage = null;
            this.ReminderFButton.OnPressedState.IconRightImage = null;
            this.ReminderFButton.Size = new System.Drawing.Size(130, 33);
            this.ReminderFButton.TabIndex = 11;
            this.ReminderFButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReminderFButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.ReminderFButton.TextMarginLeft = 0;
            this.ReminderFButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.ReminderFButton.UseDefaultRadiusAndThickness = true;
            // 
            // FullData
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(790, 665);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ReminderFButton);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.DuesFDataGrid);
            this.Controls.Add(this.ExpiredFDataGrid);
            this.Controls.Add(this.ExpiringFDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FullData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FullData";
            this.Load += new System.EventHandler(this.FullData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DuesFDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpiredFDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpiringFDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton ReminderFButton;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuDataGridView DuesFDataGrid;
        private Bunifu.UI.WinForms.BunifuDataGridView ExpiredFDataGrid;
        private Bunifu.UI.WinForms.BunifuDataGridView ExpiringFDataGrid;
        private Bunifu.UI.WinForms.BunifuImageButton CloseButton;
    }
}