namespace Matrix
{
    partial class ProfilePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfilePanel));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.DeviceMenu = new Bunifu.UI.WinForms.BunifuDropdown();
            this.CamBox = new System.Windows.Forms.PictureBox();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.UpdateButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.CaptureButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SaveButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.StartCamButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.CloseButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.ChangeCam = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.DeviceLabel = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.CamBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DeviceMenu
            // 
            this.DeviceMenu.BackColor = System.Drawing.Color.Transparent;
            this.DeviceMenu.BackgroundColor = System.Drawing.Color.White;
            this.DeviceMenu.BorderColor = System.Drawing.Color.Silver;
            this.DeviceMenu.BorderRadius = 1;
            this.DeviceMenu.Color = System.Drawing.Color.Silver;
            this.DeviceMenu.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.DeviceMenu.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DeviceMenu.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.DeviceMenu.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DeviceMenu.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DeviceMenu.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.DeviceMenu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DeviceMenu.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.DeviceMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeviceMenu.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.DeviceMenu.FillDropDown = true;
            this.DeviceMenu.FillIndicator = false;
            this.DeviceMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeviceMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeviceMenu.ForeColor = System.Drawing.Color.Black;
            this.DeviceMenu.FormattingEnabled = true;
            this.DeviceMenu.Icon = null;
            this.DeviceMenu.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.DeviceMenu.IndicatorColor = System.Drawing.Color.Gray;
            this.DeviceMenu.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.DeviceMenu.ItemBackColor = System.Drawing.Color.White;
            this.DeviceMenu.ItemBorderColor = System.Drawing.Color.White;
            this.DeviceMenu.ItemForeColor = System.Drawing.Color.Black;
            this.DeviceMenu.ItemHeight = 26;
            this.DeviceMenu.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.DeviceMenu.ItemHighLightForeColor = System.Drawing.Color.White;
            this.DeviceMenu.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.DeviceMenu.ItemTopMargin = 3;
            this.DeviceMenu.Location = new System.Drawing.Point(426, 38);
            this.DeviceMenu.Name = "DeviceMenu";
            this.DeviceMenu.Size = new System.Drawing.Size(125, 32);
            this.DeviceMenu.TabIndex = 0;
            this.DeviceMenu.Text = null;
            this.DeviceMenu.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.DeviceMenu.TextLeftMargin = 5;
            this.DeviceMenu.Visible = false;
            this.DeviceMenu.SelectedIndexChanged += new System.EventHandler(this.DeviceMenu_SelectedIndexChanged);
            // 
            // CamBox
            // 
            this.CamBox.Location = new System.Drawing.Point(25, 101);
            this.CamBox.Name = "CamBox";
            this.CamBox.Size = new System.Drawing.Size(260, 263);
            this.CamBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CamBox.TabIndex = 2;
            this.CamBox.TabStop = false;
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(291, 101);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(260, 263);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 2;
            this.PictureBox.TabStop = false;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.Location = new System.Drawing.Point(126, 370);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(50, 24);
            this.bunifuLabel2.TabIndex = 1;
            this.bunifuLabel2.Text = "Camera";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.Location = new System.Drawing.Point(394, 370);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(50, 24);
            this.bunifuLabel3.TabIndex = 1;
            this.bunifuLabel3.Text = "Picture";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // UpdateButton
            // 
            this.UpdateButton.AllowAnimations = true;
            this.UpdateButton.AllowMouseEffects = true;
            this.UpdateButton.AllowToggling = false;
            this.UpdateButton.AnimationSpeed = 200;
            this.UpdateButton.AutoGenerateColors = false;
            this.UpdateButton.AutoRoundBorders = false;
            this.UpdateButton.AutoSizeLeftIcon = true;
            this.UpdateButton.AutoSizeRightIcon = true;
            this.UpdateButton.BackColor = System.Drawing.Color.Transparent;
            this.UpdateButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.UpdateButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpdateButton.BackgroundImage")));
            this.UpdateButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.UpdateButton.ButtonText = "Browse";
            this.UpdateButton.ButtonTextMarginLeft = 0;
            this.UpdateButton.ColorContrastOnClick = 45;
            this.UpdateButton.ColorContrastOnHover = 45;
            this.UpdateButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.UpdateButton.CustomizableEdges = borderEdges1;
            this.UpdateButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.UpdateButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.UpdateButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.UpdateButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.UpdateButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.UpdateButton.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.ForeColor = System.Drawing.Color.White;
            this.UpdateButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.UpdateButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.UpdateButton.IconMarginLeft = 11;
            this.UpdateButton.IconPadding = 10;
            this.UpdateButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.UpdateButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.UpdateButton.IconSize = 25;
            this.UpdateButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.UpdateButton.IdleBorderRadius = 15;
            this.UpdateButton.IdleBorderThickness = 1;
            this.UpdateButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.UpdateButton.IdleIconLeftImage = null;
            this.UpdateButton.IdleIconRightImage = null;
            this.UpdateButton.IndicateFocus = false;
            this.UpdateButton.Location = new System.Drawing.Point(450, 409);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.UpdateButton.OnDisabledState.BorderRadius = 15;
            this.UpdateButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.UpdateButton.OnDisabledState.BorderThickness = 1;
            this.UpdateButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.UpdateButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.UpdateButton.OnDisabledState.IconLeftImage = null;
            this.UpdateButton.OnDisabledState.IconRightImage = null;
            this.UpdateButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.UpdateButton.onHoverState.BorderRadius = 15;
            this.UpdateButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.UpdateButton.onHoverState.BorderThickness = 1;
            this.UpdateButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.UpdateButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.UpdateButton.onHoverState.IconLeftImage = null;
            this.UpdateButton.onHoverState.IconRightImage = null;
            this.UpdateButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.UpdateButton.OnIdleState.BorderRadius = 15;
            this.UpdateButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.UpdateButton.OnIdleState.BorderThickness = 1;
            this.UpdateButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.UpdateButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.UpdateButton.OnIdleState.IconLeftImage = null;
            this.UpdateButton.OnIdleState.IconRightImage = null;
            this.UpdateButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.UpdateButton.OnPressedState.BorderRadius = 15;
            this.UpdateButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.UpdateButton.OnPressedState.BorderThickness = 1;
            this.UpdateButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.UpdateButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.UpdateButton.OnPressedState.IconLeftImage = null;
            this.UpdateButton.OnPressedState.IconRightImage = null;
            this.UpdateButton.Size = new System.Drawing.Size(101, 39);
            this.UpdateButton.TabIndex = 30;
            this.UpdateButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpdateButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpdateButton.TextMarginLeft = 0;
            this.UpdateButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.UpdateButton.UseDefaultRadiusAndThickness = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // CaptureButton
            // 
            this.CaptureButton.AllowAnimations = true;
            this.CaptureButton.AllowMouseEffects = true;
            this.CaptureButton.AllowToggling = false;
            this.CaptureButton.AnimationSpeed = 200;
            this.CaptureButton.AutoGenerateColors = false;
            this.CaptureButton.AutoRoundBorders = false;
            this.CaptureButton.AutoSizeLeftIcon = true;
            this.CaptureButton.AutoSizeRightIcon = true;
            this.CaptureButton.BackColor = System.Drawing.Color.Transparent;
            this.CaptureButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.CaptureButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CaptureButton.BackgroundImage")));
            this.CaptureButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.CaptureButton.ButtonText = "Capture";
            this.CaptureButton.ButtonTextMarginLeft = 0;
            this.CaptureButton.ColorContrastOnClick = 45;
            this.CaptureButton.ColorContrastOnHover = 45;
            this.CaptureButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.CaptureButton.CustomizableEdges = borderEdges2;
            this.CaptureButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CaptureButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.CaptureButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.CaptureButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.CaptureButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.CaptureButton.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptureButton.ForeColor = System.Drawing.Color.White;
            this.CaptureButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CaptureButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.CaptureButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.CaptureButton.IconMarginLeft = 11;
            this.CaptureButton.IconPadding = 10;
            this.CaptureButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CaptureButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.CaptureButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.CaptureButton.IconSize = 25;
            this.CaptureButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.CaptureButton.IdleBorderRadius = 15;
            this.CaptureButton.IdleBorderThickness = 1;
            this.CaptureButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.CaptureButton.IdleIconLeftImage = null;
            this.CaptureButton.IdleIconRightImage = null;
            this.CaptureButton.IndicateFocus = false;
            this.CaptureButton.Location = new System.Drawing.Point(157, 409);
            this.CaptureButton.Name = "CaptureButton";
            this.CaptureButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.CaptureButton.OnDisabledState.BorderRadius = 15;
            this.CaptureButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.CaptureButton.OnDisabledState.BorderThickness = 1;
            this.CaptureButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.CaptureButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.CaptureButton.OnDisabledState.IconLeftImage = null;
            this.CaptureButton.OnDisabledState.IconRightImage = null;
            this.CaptureButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CaptureButton.onHoverState.BorderRadius = 15;
            this.CaptureButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.CaptureButton.onHoverState.BorderThickness = 1;
            this.CaptureButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CaptureButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.CaptureButton.onHoverState.IconLeftImage = null;
            this.CaptureButton.onHoverState.IconRightImage = null;
            this.CaptureButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.CaptureButton.OnIdleState.BorderRadius = 15;
            this.CaptureButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.CaptureButton.OnIdleState.BorderThickness = 1;
            this.CaptureButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.CaptureButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.CaptureButton.OnIdleState.IconLeftImage = null;
            this.CaptureButton.OnIdleState.IconRightImage = null;
            this.CaptureButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.CaptureButton.OnPressedState.BorderRadius = 15;
            this.CaptureButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.CaptureButton.OnPressedState.BorderThickness = 1;
            this.CaptureButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.CaptureButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.CaptureButton.OnPressedState.IconLeftImage = null;
            this.CaptureButton.OnPressedState.IconRightImage = null;
            this.CaptureButton.Size = new System.Drawing.Size(101, 39);
            this.CaptureButton.TabIndex = 29;
            this.CaptureButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CaptureButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.CaptureButton.TextMarginLeft = 0;
            this.CaptureButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.CaptureButton.UseDefaultRadiusAndThickness = true;
            this.CaptureButton.Click += new System.EventHandler(this.CaptureButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.AllowAnimations = true;
            this.SaveButton.AllowMouseEffects = true;
            this.SaveButton.AllowToggling = false;
            this.SaveButton.AnimationSpeed = 200;
            this.SaveButton.AutoGenerateColors = false;
            this.SaveButton.AutoRoundBorders = false;
            this.SaveButton.AutoSizeLeftIcon = true;
            this.SaveButton.AutoSizeRightIcon = true;
            this.SaveButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.SaveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveButton.BackgroundImage")));
            this.SaveButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SaveButton.ButtonText = "Save";
            this.SaveButton.ButtonTextMarginLeft = 0;
            this.SaveButton.ColorContrastOnClick = 45;
            this.SaveButton.ColorContrastOnHover = 45;
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.SaveButton.CustomizableEdges = borderEdges3;
            this.SaveButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SaveButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SaveButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SaveButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SaveButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.SaveButton.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.SaveButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.SaveButton.IconMarginLeft = 11;
            this.SaveButton.IconPadding = 10;
            this.SaveButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.SaveButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.SaveButton.IconSize = 25;
            this.SaveButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.SaveButton.IdleBorderRadius = 15;
            this.SaveButton.IdleBorderThickness = 1;
            this.SaveButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.SaveButton.IdleIconLeftImage = null;
            this.SaveButton.IdleIconRightImage = null;
            this.SaveButton.IndicateFocus = false;
            this.SaveButton.Location = new System.Drawing.Point(301, 409);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SaveButton.OnDisabledState.BorderRadius = 15;
            this.SaveButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SaveButton.OnDisabledState.BorderThickness = 1;
            this.SaveButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SaveButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SaveButton.OnDisabledState.IconLeftImage = null;
            this.SaveButton.OnDisabledState.IconRightImage = null;
            this.SaveButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SaveButton.onHoverState.BorderRadius = 15;
            this.SaveButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SaveButton.onHoverState.BorderThickness = 1;
            this.SaveButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SaveButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.SaveButton.onHoverState.IconLeftImage = null;
            this.SaveButton.onHoverState.IconRightImage = null;
            this.SaveButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.SaveButton.OnIdleState.BorderRadius = 15;
            this.SaveButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SaveButton.OnIdleState.BorderThickness = 1;
            this.SaveButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.SaveButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.SaveButton.OnIdleState.IconLeftImage = null;
            this.SaveButton.OnIdleState.IconRightImage = null;
            this.SaveButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SaveButton.OnPressedState.BorderRadius = 15;
            this.SaveButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SaveButton.OnPressedState.BorderThickness = 1;
            this.SaveButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SaveButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.SaveButton.OnPressedState.IconLeftImage = null;
            this.SaveButton.OnPressedState.IconRightImage = null;
            this.SaveButton.Size = new System.Drawing.Size(101, 39);
            this.SaveButton.TabIndex = 29;
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.SaveButton.TextMarginLeft = 0;
            this.SaveButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.SaveButton.UseDefaultRadiusAndThickness = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // StartCamButton
            // 
            this.StartCamButton.AllowAnimations = true;
            this.StartCamButton.AllowMouseEffects = true;
            this.StartCamButton.AllowToggling = false;
            this.StartCamButton.AnimationSpeed = 200;
            this.StartCamButton.AutoGenerateColors = false;
            this.StartCamButton.AutoRoundBorders = false;
            this.StartCamButton.AutoSizeLeftIcon = true;
            this.StartCamButton.AutoSizeRightIcon = true;
            this.StartCamButton.BackColor = System.Drawing.Color.Transparent;
            this.StartCamButton.BackColor1 = System.Drawing.Color.SteelBlue;
            this.StartCamButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StartCamButton.BackgroundImage")));
            this.StartCamButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.StartCamButton.ButtonText = "Start Cam";
            this.StartCamButton.ButtonTextMarginLeft = 0;
            this.StartCamButton.ColorContrastOnClick = 45;
            this.StartCamButton.ColorContrastOnHover = 45;
            this.StartCamButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.StartCamButton.CustomizableEdges = borderEdges4;
            this.StartCamButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.StartCamButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.StartCamButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.StartCamButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.StartCamButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.StartCamButton.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartCamButton.ForeColor = System.Drawing.Color.White;
            this.StartCamButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StartCamButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.StartCamButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.StartCamButton.IconMarginLeft = 11;
            this.StartCamButton.IconPadding = 10;
            this.StartCamButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StartCamButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.StartCamButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.StartCamButton.IconSize = 25;
            this.StartCamButton.IdleBorderColor = System.Drawing.Color.AliceBlue;
            this.StartCamButton.IdleBorderRadius = 15;
            this.StartCamButton.IdleBorderThickness = 1;
            this.StartCamButton.IdleFillColor = System.Drawing.Color.SteelBlue;
            this.StartCamButton.IdleIconLeftImage = null;
            this.StartCamButton.IdleIconRightImage = null;
            this.StartCamButton.IndicateFocus = false;
            this.StartCamButton.Location = new System.Drawing.Point(25, 409);
            this.StartCamButton.Name = "StartCamButton";
            this.StartCamButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.StartCamButton.OnDisabledState.BorderRadius = 15;
            this.StartCamButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.StartCamButton.OnDisabledState.BorderThickness = 1;
            this.StartCamButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.StartCamButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.StartCamButton.OnDisabledState.IconLeftImage = null;
            this.StartCamButton.OnDisabledState.IconRightImage = null;
            this.StartCamButton.onHoverState.BorderColor = System.Drawing.Color.Turquoise;
            this.StartCamButton.onHoverState.BorderRadius = 15;
            this.StartCamButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.StartCamButton.onHoverState.BorderThickness = 1;
            this.StartCamButton.onHoverState.FillColor = System.Drawing.Color.Turquoise;
            this.StartCamButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.StartCamButton.onHoverState.IconLeftImage = null;
            this.StartCamButton.onHoverState.IconRightImage = null;
            this.StartCamButton.OnIdleState.BorderColor = System.Drawing.Color.AliceBlue;
            this.StartCamButton.OnIdleState.BorderRadius = 15;
            this.StartCamButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.StartCamButton.OnIdleState.BorderThickness = 1;
            this.StartCamButton.OnIdleState.FillColor = System.Drawing.Color.SteelBlue;
            this.StartCamButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.StartCamButton.OnIdleState.IconLeftImage = null;
            this.StartCamButton.OnIdleState.IconRightImage = null;
            this.StartCamButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.StartCamButton.OnPressedState.BorderRadius = 15;
            this.StartCamButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.StartCamButton.OnPressedState.BorderThickness = 1;
            this.StartCamButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.StartCamButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.StartCamButton.OnPressedState.IconLeftImage = null;
            this.StartCamButton.OnPressedState.IconRightImage = null;
            this.StartCamButton.Size = new System.Drawing.Size(101, 39);
            this.StartCamButton.TabIndex = 29;
            this.StartCamButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StartCamButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.StartCamButton.TextMarginLeft = 0;
            this.StartCamButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.StartCamButton.UseDefaultRadiusAndThickness = true;
            this.StartCamButton.Click += new System.EventHandler(this.StartCamButton_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
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
            this.CloseButton.ImageSize = new System.Drawing.Size(29, 29);
            this.CloseButton.ImageZoomSize = new System.Drawing.Size(30, 30);
            this.CloseButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.InitialImage")));
            this.CloseButton.Location = new System.Drawing.Point(547, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Rotation = 0;
            this.CloseButton.ShowActiveImage = true;
            this.CloseButton.ShowCursorChanges = true;
            this.CloseButton.ShowImageBorders = true;
            this.CloseButton.ShowSizeMarkers = false;
            this.CloseButton.Size = new System.Drawing.Size(30, 30);
            this.CloseButton.TabIndex = 31;
            this.CloseButton.ToolTipText = "";
            this.CloseButton.WaitOnLoad = false;
            this.CloseButton.Zoom = 0;
            this.CloseButton.ZoomSpeed = 10;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ChangeCam
            // 
            this.ChangeCam.AllowAnimations = true;
            this.ChangeCam.AllowMouseEffects = true;
            this.ChangeCam.AllowToggling = false;
            this.ChangeCam.AnimationSpeed = 200;
            this.ChangeCam.AutoGenerateColors = false;
            this.ChangeCam.AutoRoundBorders = false;
            this.ChangeCam.AutoSizeLeftIcon = true;
            this.ChangeCam.AutoSizeRightIcon = true;
            this.ChangeCam.BackColor = System.Drawing.Color.Transparent;
            this.ChangeCam.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(215)))), ((int)(((byte)(177)))));
            this.ChangeCam.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChangeCam.BackgroundImage")));
            this.ChangeCam.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ChangeCam.ButtonText = "Change Camera";
            this.ChangeCam.ButtonTextMarginLeft = 0;
            this.ChangeCam.ColorContrastOnClick = 45;
            this.ChangeCam.ColorContrastOnHover = 45;
            this.ChangeCam.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.ChangeCam.CustomizableEdges = borderEdges5;
            this.ChangeCam.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ChangeCam.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ChangeCam.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ChangeCam.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ChangeCam.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.ChangeCam.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeCam.ForeColor = System.Drawing.Color.White;
            this.ChangeCam.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangeCam.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.ChangeCam.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.ChangeCam.IconMarginLeft = 11;
            this.ChangeCam.IconPadding = 10;
            this.ChangeCam.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChangeCam.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.ChangeCam.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.ChangeCam.IconSize = 25;
            this.ChangeCam.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(215)))), ((int)(((byte)(177)))));
            this.ChangeCam.IdleBorderRadius = 10;
            this.ChangeCam.IdleBorderThickness = 1;
            this.ChangeCam.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(215)))), ((int)(((byte)(177)))));
            this.ChangeCam.IdleIconLeftImage = null;
            this.ChangeCam.IdleIconRightImage = null;
            this.ChangeCam.IndicateFocus = false;
            this.ChangeCam.Location = new System.Drawing.Point(25, 36);
            this.ChangeCam.Name = "ChangeCam";
            this.ChangeCam.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ChangeCam.OnDisabledState.BorderRadius = 10;
            this.ChangeCam.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ChangeCam.OnDisabledState.BorderThickness = 1;
            this.ChangeCam.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ChangeCam.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ChangeCam.OnDisabledState.IconLeftImage = null;
            this.ChangeCam.OnDisabledState.IconRightImage = null;
            this.ChangeCam.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ChangeCam.onHoverState.BorderRadius = 10;
            this.ChangeCam.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ChangeCam.onHoverState.BorderThickness = 1;
            this.ChangeCam.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ChangeCam.onHoverState.ForeColor = System.Drawing.Color.White;
            this.ChangeCam.onHoverState.IconLeftImage = null;
            this.ChangeCam.onHoverState.IconRightImage = null;
            this.ChangeCam.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(215)))), ((int)(((byte)(177)))));
            this.ChangeCam.OnIdleState.BorderRadius = 10;
            this.ChangeCam.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ChangeCam.OnIdleState.BorderThickness = 1;
            this.ChangeCam.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(215)))), ((int)(((byte)(177)))));
            this.ChangeCam.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.ChangeCam.OnIdleState.IconLeftImage = null;
            this.ChangeCam.OnIdleState.IconRightImage = null;
            this.ChangeCam.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.ChangeCam.OnPressedState.BorderRadius = 10;
            this.ChangeCam.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ChangeCam.OnPressedState.BorderThickness = 1;
            this.ChangeCam.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.ChangeCam.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.ChangeCam.OnPressedState.IconLeftImage = null;
            this.ChangeCam.OnPressedState.IconRightImage = null;
            this.ChangeCam.Size = new System.Drawing.Size(125, 34);
            this.ChangeCam.TabIndex = 32;
            this.ChangeCam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChangeCam.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChangeCam.TextMarginLeft = 0;
            this.ChangeCam.TextPadding = new System.Windows.Forms.Padding(0);
            this.ChangeCam.UseDefaultRadiusAndThickness = true;
            this.ChangeCam.Click += new System.EventHandler(this.ChangeCam_Click);
            // 
            // DeviceLabel
            // 
            this.DeviceLabel.AllowParentOverrides = false;
            this.DeviceLabel.AutoEllipsis = false;
            this.DeviceLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.DeviceLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.DeviceLabel.Font = new System.Drawing.Font("Bebas Neue", 13.8F);
            this.DeviceLabel.Location = new System.Drawing.Point(26, 75);
            this.DeviceLabel.Name = "DeviceLabel";
            this.DeviceLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DeviceLabel.Size = new System.Drawing.Size(100, 28);
            this.DeviceLabel.TabIndex = 33;
            this.DeviceLabel.Text = "bunifuLabel1";
            this.DeviceLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.DeviceLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ProfilePanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(581, 483);
            this.Controls.Add(this.DeviceLabel);
            this.Controls.Add(this.ChangeCam);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.StartCamButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CaptureButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.CamBox);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.DeviceMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfilePanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProfilePanel";
            this.Load += new System.EventHandler(this.ProfilePanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CamBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDropdown DeviceMenu;
        private System.Windows.Forms.PictureBox CamBox;
        private System.Windows.Forms.PictureBox PictureBox;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton UpdateButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton CaptureButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton SaveButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton StartCamButton;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuImageButton CloseButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton ChangeCam;
        private Bunifu.UI.WinForms.BunifuLabel DeviceLabel;
    }
}