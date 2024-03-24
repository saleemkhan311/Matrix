namespace Matrix
{
    partial class ReceiptPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptPanel));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.NameLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.WeightLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.FeesLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.TotalLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.MembershipLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.DuesLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.ReceivedByLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.PaymentLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.RenewalLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.ReceiptP = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CloseButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.SaveReceiptButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.ReceiptP.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // NameLabel
            // 
            this.NameLabel.AllowParentOverrides = false;
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NameLabel.AutoEllipsis = false;
            this.NameLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.NameLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.NameLabel.Font = new System.Drawing.Font("Bebas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(94, 102);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NameLabel.Size = new System.Drawing.Size(91, 23);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Member Name";
            this.NameLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.NameLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // WeightLabel
            // 
            this.WeightLabel.AllowParentOverrides = false;
            this.WeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WeightLabel.AutoEllipsis = false;
            this.WeightLabel.CursorType = null;
            this.WeightLabel.Font = new System.Drawing.Font("Bebas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.Location = new System.Drawing.Point(94, 141);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WeightLabel.Size = new System.Drawing.Size(46, 23);
            this.WeightLabel.TabIndex = 2;
            this.WeightLabel.Text = "Weight";
            this.WeightLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.WeightLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // FeesLabel
            // 
            this.FeesLabel.AllowParentOverrides = false;
            this.FeesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FeesLabel.AutoEllipsis = false;
            this.FeesLabel.CursorType = null;
            this.FeesLabel.Font = new System.Drawing.Font("Bebas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeesLabel.Location = new System.Drawing.Point(94, 174);
            this.FeesLabel.Name = "FeesLabel";
            this.FeesLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FeesLabel.Size = new System.Drawing.Size(29, 23);
            this.FeesLabel.TabIndex = 2;
            this.FeesLabel.Text = "Fees";
            this.FeesLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.FeesLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AllowParentOverrides = false;
            this.TotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TotalLabel.AutoEllipsis = false;
            this.TotalLabel.CursorType = null;
            this.TotalLabel.Font = new System.Drawing.Font("Bebas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(94, 209);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TotalLabel.Size = new System.Drawing.Size(37, 23);
            this.TotalLabel.TabIndex = 2;
            this.TotalLabel.Text = "Total";
            this.TotalLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.TotalLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // MembershipLabel
            // 
            this.MembershipLabel.AllowParentOverrides = false;
            this.MembershipLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MembershipLabel.AutoEllipsis = false;
            this.MembershipLabel.CursorType = null;
            this.MembershipLabel.Font = new System.Drawing.Font("Bebas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MembershipLabel.Location = new System.Drawing.Point(627, 145);
            this.MembershipLabel.Name = "MembershipLabel";
            this.MembershipLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MembershipLabel.Size = new System.Drawing.Size(71, 19);
            this.MembershipLabel.TabIndex = 2;
            this.MembershipLabel.Text = "Membership";
            this.MembershipLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.MembershipLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // DuesLabel
            // 
            this.DuesLabel.AllowParentOverrides = false;
            this.DuesLabel.AutoEllipsis = false;
            this.DuesLabel.CursorType = null;
            this.DuesLabel.Font = new System.Drawing.Font("Bebas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DuesLabel.Location = new System.Drawing.Point(497, 170);
            this.DuesLabel.Name = "DuesLabel";
            this.DuesLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DuesLabel.Size = new System.Drawing.Size(31, 23);
            this.DuesLabel.TabIndex = 2;
            this.DuesLabel.Text = "Dues";
            this.DuesLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.DuesLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ReceivedByLabel
            // 
            this.ReceivedByLabel.AllowParentOverrides = false;
            this.ReceivedByLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReceivedByLabel.AutoEllipsis = false;
            this.ReceivedByLabel.AutoSize = false;
            this.ReceivedByLabel.CursorType = null;
            this.ReceivedByLabel.Font = new System.Drawing.Font("Bebas", 14.25F);
            this.ReceivedByLabel.Location = new System.Drawing.Point(497, 311);
            this.ReceivedByLabel.Name = "ReceivedByLabel";
            this.ReceivedByLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ReceivedByLabel.Size = new System.Drawing.Size(124, 23);
            this.ReceivedByLabel.TabIndex = 2;
            this.ReceivedByLabel.Text = "Received By";
            this.ReceivedByLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.ReceivedByLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // PaymentLabel
            // 
            this.PaymentLabel.AllowParentOverrides = false;
            this.PaymentLabel.AutoEllipsis = false;
            this.PaymentLabel.CursorType = null;
            this.PaymentLabel.Font = new System.Drawing.Font("Bebas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentLabel.ForeColor = System.Drawing.Color.White;
            this.PaymentLabel.Location = new System.Drawing.Point(627, 3);
            this.PaymentLabel.Name = "PaymentLabel";
            this.PaymentLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PaymentLabel.Size = new System.Drawing.Size(92, 23);
            this.PaymentLabel.TabIndex = 2;
            this.PaymentLabel.Text = "Payment Date";
            this.PaymentLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.PaymentLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.PaymentLabel.Click += new System.EventHandler(this.PaymentLabel_Click);
            // 
            // RenewalLabel
            // 
            this.RenewalLabel.AllowParentOverrides = false;
            this.RenewalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RenewalLabel.AutoEllipsis = false;
            this.RenewalLabel.CursorType = null;
            this.RenewalLabel.Font = new System.Drawing.Font("Bebas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RenewalLabel.ForeColor = System.Drawing.Color.White;
            this.RenewalLabel.Location = new System.Drawing.Point(627, 53);
            this.RenewalLabel.Name = "RenewalLabel";
            this.RenewalLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RenewalLabel.Size = new System.Drawing.Size(91, 23);
            this.RenewalLabel.TabIndex = 2;
            this.RenewalLabel.Text = "Renewal Date";
            this.RenewalLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.RenewalLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ReceiptP
            // 
            this.ReceiptP.BackgroundImage = global::Matrix.Properties.Resources.Gym_Reciept_Print;
            this.ReceiptP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ReceiptP.Controls.Add(this.tableLayoutPanel1);
            this.ReceiptP.Location = new System.Drawing.Point(6, 33);
            this.ReceiptP.Name = "ReceiptP";
            this.ReceiptP.Size = new System.Drawing.Size(749, 337);
            this.ReceiptP.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.50117F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.49883F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel1.Controls.Add(this.PaymentLabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.WeightLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.DuesLabel, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.ReceivedByLabel, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.MembershipLabel, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.TotalLabel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.RenewalLabel, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.FeesLabel, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.NameLabel, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.17647F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.82353F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(749, 337);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.CloseButton.Image = global::Matrix.Properties.Resources.Close;
            this.CloseButton.ImageActive = null;
            this.CloseButton.ImageLocation = null;
            this.CloseButton.ImageMargin = 0;
            this.CloseButton.ImageSize = new System.Drawing.Size(24, 24);
            this.CloseButton.ImageZoomSize = new System.Drawing.Size(25, 25);
            this.CloseButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.InitialImage")));
            this.CloseButton.Location = new System.Drawing.Point(736, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Rotation = 0;
            this.CloseButton.ShowActiveImage = true;
            this.CloseButton.ShowCursorChanges = true;
            this.CloseButton.ShowImageBorders = true;
            this.CloseButton.ShowSizeMarkers = false;
            this.CloseButton.Size = new System.Drawing.Size(25, 25);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.ToolTipText = "";
            this.CloseButton.WaitOnLoad = false;
            this.CloseButton.Zoom = 0;
            this.CloseButton.ZoomSpeed = 10;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SaveReceiptButton
            // 
            this.SaveReceiptButton.AllowAnimations = true;
            this.SaveReceiptButton.AllowMouseEffects = true;
            this.SaveReceiptButton.AllowToggling = false;
            this.SaveReceiptButton.AnimationSpeed = 200;
            this.SaveReceiptButton.AutoGenerateColors = false;
            this.SaveReceiptButton.AutoRoundBorders = false;
            this.SaveReceiptButton.AutoSizeLeftIcon = true;
            this.SaveReceiptButton.AutoSizeRightIcon = true;
            this.SaveReceiptButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveReceiptButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.SaveReceiptButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveReceiptButton.BackgroundImage")));
            this.SaveReceiptButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SaveReceiptButton.ButtonText = "Save Receipt";
            this.SaveReceiptButton.ButtonTextMarginLeft = 0;
            this.SaveReceiptButton.ColorContrastOnClick = 45;
            this.SaveReceiptButton.ColorContrastOnHover = 45;
            this.SaveReceiptButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.SaveReceiptButton.CustomizableEdges = borderEdges1;
            this.SaveReceiptButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SaveReceiptButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SaveReceiptButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SaveReceiptButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SaveReceiptButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.SaveReceiptButton.Font = new System.Drawing.Font("Bebas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveReceiptButton.ForeColor = System.Drawing.Color.White;
            this.SaveReceiptButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveReceiptButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.SaveReceiptButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.SaveReceiptButton.IconMarginLeft = 11;
            this.SaveReceiptButton.IconPadding = 10;
            this.SaveReceiptButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveReceiptButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.SaveReceiptButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.SaveReceiptButton.IconSize = 25;
            this.SaveReceiptButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.SaveReceiptButton.IdleBorderRadius = 15;
            this.SaveReceiptButton.IdleBorderThickness = 1;
            this.SaveReceiptButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.SaveReceiptButton.IdleIconLeftImage = null;
            this.SaveReceiptButton.IdleIconRightImage = null;
            this.SaveReceiptButton.IndicateFocus = false;
            this.SaveReceiptButton.Location = new System.Drawing.Point(6, 376);
            this.SaveReceiptButton.Name = "SaveReceiptButton";
            this.SaveReceiptButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SaveReceiptButton.OnDisabledState.BorderRadius = 15;
            this.SaveReceiptButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SaveReceiptButton.OnDisabledState.BorderThickness = 1;
            this.SaveReceiptButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SaveReceiptButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SaveReceiptButton.OnDisabledState.IconLeftImage = null;
            this.SaveReceiptButton.OnDisabledState.IconRightImage = null;
            this.SaveReceiptButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SaveReceiptButton.onHoverState.BorderRadius = 15;
            this.SaveReceiptButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SaveReceiptButton.onHoverState.BorderThickness = 1;
            this.SaveReceiptButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SaveReceiptButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.SaveReceiptButton.onHoverState.IconLeftImage = null;
            this.SaveReceiptButton.onHoverState.IconRightImage = null;
            this.SaveReceiptButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.SaveReceiptButton.OnIdleState.BorderRadius = 15;
            this.SaveReceiptButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SaveReceiptButton.OnIdleState.BorderThickness = 1;
            this.SaveReceiptButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.SaveReceiptButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.SaveReceiptButton.OnIdleState.IconLeftImage = null;
            this.SaveReceiptButton.OnIdleState.IconRightImage = null;
            this.SaveReceiptButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SaveReceiptButton.OnPressedState.BorderRadius = 15;
            this.SaveReceiptButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SaveReceiptButton.OnPressedState.BorderThickness = 1;
            this.SaveReceiptButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SaveReceiptButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.SaveReceiptButton.OnPressedState.IconLeftImage = null;
            this.SaveReceiptButton.OnPressedState.IconRightImage = null;
            this.SaveReceiptButton.Size = new System.Drawing.Size(150, 39);
            this.SaveReceiptButton.TabIndex = 7;
            this.SaveReceiptButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveReceiptButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.SaveReceiptButton.TextMarginLeft = 0;
            this.SaveReceiptButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.SaveReceiptButton.UseDefaultRadiusAndThickness = true;
            this.SaveReceiptButton.Click += new System.EventHandler(this.SaveReceiptButton_Click);
            // 
            // ReceiptPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(766, 422);
            this.Controls.Add(this.SaveReceiptButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ReceiptP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReceiptPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReceiptPanel";
            this.ReceiptP.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuLabel WeightLabel;
        private Bunifu.UI.WinForms.BunifuLabel NameLabel;
        private Bunifu.UI.WinForms.BunifuLabel FeesLabel;
        private Bunifu.UI.WinForms.BunifuLabel RenewalLabel;
        private Bunifu.UI.WinForms.BunifuLabel PaymentLabel;
        private Bunifu.UI.WinForms.BunifuLabel ReceivedByLabel;
        private Bunifu.UI.WinForms.BunifuLabel DuesLabel;
        private Bunifu.UI.WinForms.BunifuLabel MembershipLabel;
        private Bunifu.UI.WinForms.BunifuLabel TotalLabel;
        private System.Windows.Forms.Panel ReceiptP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.UI.WinForms.BunifuImageButton CloseButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton SaveReceiptButton;
    }
}