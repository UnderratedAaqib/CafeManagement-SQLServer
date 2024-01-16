namespace DATABASE_Project
{
    partial class GuestForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GcumenPanel = new System.Windows.Forms.Panel();
            this.GorderQuan = new System.Windows.Forms.Label();
            this.GordId = new System.Windows.Forms.Label();
            this.GquanT = new Guna.UI.WinForms.GunaTextBox();
            this.GordIDT = new Guna.UI.WinForms.GunaTextBox();
            this.GaddCart = new Guna.UI.WinForms.GunaButton();
            this.uID = new Guna.UI.WinForms.GunaLabel();
            this.GcustomerMenu = new Guna.UI.WinForms.GunaDataGridView();
            this.GcumenHeading = new System.Windows.Forms.Label();
            this.GCartPanel = new System.Windows.Forms.Panel();
            this.GCuBalance = new System.Windows.Forms.Label();
            this.GcuBalanceT = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.GfinalCheckoutButton = new Guna.UI.WinForms.GunaButton();
            this.GctID = new System.Windows.Forms.Label();
            this.GcdIDT = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.GRemovalCart = new Guna.UI.WinForms.GunaButton();
            this.GcartData = new Guna.UI.WinForms.GunaDataGridView();
            this.FinalCart = new System.Windows.Forms.Label();
            this.GcartButton = new System.Windows.Forms.Button();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.GMenButton = new System.Windows.Forms.Button();
            this.GlogOutButton = new Guna.UI.WinForms.GunaButton();
            this.tAmountLabel = new System.Windows.Forms.Label();
            this.GctAmountT = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GcumenPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GcustomerMenu)).BeginInit();
            this.GCartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GcartData)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Olive;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 450);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // GcumenPanel
            // 
            this.GcumenPanel.Controls.Add(this.GorderQuan);
            this.GcumenPanel.Controls.Add(this.GordId);
            this.GcumenPanel.Controls.Add(this.GquanT);
            this.GcumenPanel.Controls.Add(this.GordIDT);
            this.GcumenPanel.Controls.Add(this.GaddCart);
            this.GcumenPanel.Controls.Add(this.uID);
            this.GcumenPanel.Controls.Add(this.GcustomerMenu);
            this.GcumenPanel.Controls.Add(this.GcumenHeading);
            this.GcumenPanel.Location = new System.Drawing.Point(186, 12);
            this.GcumenPanel.Name = "GcumenPanel";
            this.GcumenPanel.Size = new System.Drawing.Size(522, 322);
            this.GcumenPanel.TabIndex = 13;
            this.GcumenPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.cumenPanel_Paint);
            // 
            // GorderQuan
            // 
            this.GorderQuan.AutoSize = true;
            this.GorderQuan.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GorderQuan.Location = new System.Drawing.Point(170, 268);
            this.GorderQuan.Name = "GorderQuan";
            this.GorderQuan.Size = new System.Drawing.Size(64, 20);
            this.GorderQuan.TabIndex = 20;
            this.GorderQuan.Text = "Quantity:";
            // 
            // GordId
            // 
            this.GordId.AutoSize = true;
            this.GordId.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GordId.Location = new System.Drawing.Point(78, 268);
            this.GordId.Name = "GordId";
            this.GordId.Size = new System.Drawing.Size(26, 20);
            this.GordId.TabIndex = 19;
            this.GordId.Text = "ID:";
            // 
            // GquanT
            // 
            this.GquanT.BaseColor = System.Drawing.Color.White;
            this.GquanT.BorderColor = System.Drawing.Color.Silver;
            this.GquanT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GquanT.FocusedBaseColor = System.Drawing.Color.White;
            this.GquanT.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.GquanT.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.GquanT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GquanT.Location = new System.Drawing.Point(238, 258);
            this.GquanT.Name = "GquanT";
            this.GquanT.PasswordChar = '\0';
            this.GquanT.SelectedText = "";
            this.GquanT.Size = new System.Drawing.Size(54, 30);
            this.GquanT.TabIndex = 18;
            // 
            // GordIDT
            // 
            this.GordIDT.BaseColor = System.Drawing.Color.White;
            this.GordIDT.BorderColor = System.Drawing.Color.Silver;
            this.GordIDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GordIDT.FocusedBaseColor = System.Drawing.Color.White;
            this.GordIDT.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.GordIDT.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.GordIDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GordIDT.Location = new System.Drawing.Point(110, 258);
            this.GordIDT.Name = "GordIDT";
            this.GordIDT.PasswordChar = '\0';
            this.GordIDT.SelectedText = "";
            this.GordIDT.Size = new System.Drawing.Size(54, 30);
            this.GordIDT.TabIndex = 17;
            // 
            // GaddCart
            // 
            this.GaddCart.AnimationHoverSpeed = 0.07F;
            this.GaddCart.AnimationSpeed = 0.03F;
            this.GaddCart.BaseColor = System.Drawing.Color.White;
            this.GaddCart.BorderColor = System.Drawing.Color.Black;
            this.GaddCart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.GaddCart.FocusedColor = System.Drawing.Color.Empty;
            this.GaddCart.Font = new System.Drawing.Font("Segoe UI Black", 9F);
            this.GaddCart.ForeColor = System.Drawing.Color.IndianRed;
            this.GaddCart.Image = null;
            this.GaddCart.ImageSize = new System.Drawing.Size(20, 20);
            this.GaddCart.Location = new System.Drawing.Point(372, 246);
            this.GaddCart.Name = "GaddCart";
            this.GaddCart.OnHoverBaseColor = System.Drawing.Color.Black;
            this.GaddCart.OnHoverBorderColor = System.Drawing.Color.Black;
            this.GaddCart.OnHoverForeColor = System.Drawing.Color.White;
            this.GaddCart.OnHoverImage = null;
            this.GaddCart.OnPressedColor = System.Drawing.Color.Black;
            this.GaddCart.Size = new System.Drawing.Size(96, 42);
            this.GaddCart.TabIndex = 16;
            this.GaddCart.Text = "Add Cart";
            this.GaddCart.Click += new System.EventHandler(this.GaddCart_Click);
            // 
            // uID
            // 
            this.uID.AutoSize = true;
            this.uID.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.uID.ForeColor = System.Drawing.Color.IndianRed;
            this.uID.Location = new System.Drawing.Point(104, 226);
            this.uID.Name = "uID";
            this.uID.Size = new System.Drawing.Size(0, 28);
            this.uID.TabIndex = 15;
            this.uID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GcustomerMenu
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.GcustomerMenu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GcustomerMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GcustomerMenu.BackgroundColor = System.Drawing.Color.White;
            this.GcustomerMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GcustomerMenu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GcustomerMenu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GcustomerMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GcustomerMenu.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GcustomerMenu.DefaultCellStyle = dataGridViewCellStyle3;
            this.GcustomerMenu.EnableHeadersVisualStyles = false;
            this.GcustomerMenu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GcustomerMenu.Location = new System.Drawing.Point(79, 71);
            this.GcustomerMenu.Name = "GcustomerMenu";
            this.GcustomerMenu.RowHeadersVisible = false;
            this.GcustomerMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GcustomerMenu.Size = new System.Drawing.Size(258, 107);
            this.GcustomerMenu.TabIndex = 1;
            this.GcustomerMenu.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.GcustomerMenu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.GcustomerMenu.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.GcustomerMenu.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.GcustomerMenu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.GcustomerMenu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.GcustomerMenu.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.GcustomerMenu.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GcustomerMenu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.GcustomerMenu.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GcustomerMenu.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.GcustomerMenu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GcustomerMenu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.GcustomerMenu.ThemeStyle.HeaderStyle.Height = 4;
            this.GcustomerMenu.ThemeStyle.ReadOnly = false;
            this.GcustomerMenu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GcustomerMenu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GcustomerMenu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.GcustomerMenu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GcustomerMenu.ThemeStyle.RowsStyle.Height = 22;
            this.GcustomerMenu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GcustomerMenu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // GcumenHeading
            // 
            this.GcumenHeading.AutoSize = true;
            this.GcumenHeading.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GcumenHeading.ForeColor = System.Drawing.Color.Olive;
            this.GcumenHeading.Location = new System.Drawing.Point(162, 10);
            this.GcumenHeading.Name = "GcumenHeading";
            this.GcumenHeading.Size = new System.Drawing.Size(88, 40);
            this.GcumenHeading.TabIndex = 0;
            this.GcumenHeading.Text = "Menu";
            // 
            // GCartPanel
            // 
            this.GCartPanel.Controls.Add(this.tAmountLabel);
            this.GCartPanel.Controls.Add(this.GctAmountT);
            this.GCartPanel.Controls.Add(this.gunaLabel3);
            this.GCartPanel.Controls.Add(this.GCuBalance);
            this.GCartPanel.Controls.Add(this.GcuBalanceT);
            this.GCartPanel.Controls.Add(this.gunaLabel2);
            this.GCartPanel.Controls.Add(this.GfinalCheckoutButton);
            this.GCartPanel.Controls.Add(this.GctID);
            this.GCartPanel.Controls.Add(this.GcdIDT);
            this.GCartPanel.Controls.Add(this.gunaLabel1);
            this.GCartPanel.Controls.Add(this.GRemovalCart);
            this.GCartPanel.Controls.Add(this.GcartData);
            this.GCartPanel.Controls.Add(this.FinalCart);
            this.GCartPanel.Location = new System.Drawing.Point(186, 12);
            this.GCartPanel.Name = "GCartPanel";
            this.GCartPanel.Size = new System.Drawing.Size(531, 328);
            this.GCartPanel.TabIndex = 14;
            // 
            // GCuBalance
            // 
            this.GCuBalance.AutoSize = true;
            this.GCuBalance.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GCuBalance.Location = new System.Drawing.Point(329, 234);
            this.GCuBalance.Name = "GCuBalance";
            this.GCuBalance.Size = new System.Drawing.Size(54, 20);
            this.GCuBalance.TabIndex = 26;
            this.GCuBalance.Text = "Money:";
            // 
            // GcuBalanceT
            // 
            this.GcuBalanceT.BaseColor = System.Drawing.Color.White;
            this.GcuBalanceT.BorderColor = System.Drawing.Color.Silver;
            this.GcuBalanceT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GcuBalanceT.FocusedBaseColor = System.Drawing.Color.White;
            this.GcuBalanceT.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.GcuBalanceT.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.GcuBalanceT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GcuBalanceT.Location = new System.Drawing.Point(389, 226);
            this.GcuBalanceT.Name = "GcuBalanceT";
            this.GcuBalanceT.PasswordChar = '\0';
            this.GcuBalanceT.SelectedText = "";
            this.GcuBalanceT.Size = new System.Drawing.Size(54, 30);
            this.GcuBalanceT.TabIndex = 25;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.IndianRed;
            this.gunaLabel2.Location = new System.Drawing.Point(383, 144);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(0, 28);
            this.gunaLabel2.TabIndex = 24;
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GfinalCheckoutButton
            // 
            this.GfinalCheckoutButton.AnimationHoverSpeed = 0.07F;
            this.GfinalCheckoutButton.AnimationSpeed = 0.03F;
            this.GfinalCheckoutButton.BaseColor = System.Drawing.Color.White;
            this.GfinalCheckoutButton.BorderColor = System.Drawing.Color.Black;
            this.GfinalCheckoutButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.GfinalCheckoutButton.FocusedColor = System.Drawing.Color.Empty;
            this.GfinalCheckoutButton.Font = new System.Drawing.Font("Segoe UI Black", 9F);
            this.GfinalCheckoutButton.ForeColor = System.Drawing.Color.IndianRed;
            this.GfinalCheckoutButton.Image = null;
            this.GfinalCheckoutButton.ImageSize = new System.Drawing.Size(20, 20);
            this.GfinalCheckoutButton.Location = new System.Drawing.Point(345, 268);
            this.GfinalCheckoutButton.Name = "GfinalCheckoutButton";
            this.GfinalCheckoutButton.OnHoverBaseColor = System.Drawing.Color.Black;
            this.GfinalCheckoutButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.GfinalCheckoutButton.OnHoverForeColor = System.Drawing.Color.White;
            this.GfinalCheckoutButton.OnHoverImage = null;
            this.GfinalCheckoutButton.OnPressedColor = System.Drawing.Color.Black;
            this.GfinalCheckoutButton.Size = new System.Drawing.Size(133, 42);
            this.GfinalCheckoutButton.TabIndex = 23;
            this.GfinalCheckoutButton.Text = "Proceed Checkout";
            this.GfinalCheckoutButton.Click += new System.EventHandler(this.GfinalCheckoutButton_Click);
            // 
            // GctID
            // 
            this.GctID.AutoSize = true;
            this.GctID.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GctID.Location = new System.Drawing.Point(96, 236);
            this.GctID.Name = "GctID";
            this.GctID.Size = new System.Drawing.Size(26, 20);
            this.GctID.TabIndex = 22;
            this.GctID.Text = "ID:";
            // 
            // GcdIDT
            // 
            this.GcdIDT.BaseColor = System.Drawing.Color.White;
            this.GcdIDT.BorderColor = System.Drawing.Color.Silver;
            this.GcdIDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GcdIDT.FocusedBaseColor = System.Drawing.Color.White;
            this.GcdIDT.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.GcdIDT.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.GcdIDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GcdIDT.Location = new System.Drawing.Point(127, 226);
            this.GcdIDT.Name = "GcdIDT";
            this.GcdIDT.PasswordChar = '\0';
            this.GcdIDT.SelectedText = "";
            this.GcdIDT.Size = new System.Drawing.Size(54, 30);
            this.GcdIDT.TabIndex = 21;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.IndianRed;
            this.gunaLabel1.Location = new System.Drawing.Point(122, 154);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(0, 28);
            this.gunaLabel1.TabIndex = 20;
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GRemovalCart
            // 
            this.GRemovalCart.AnimationHoverSpeed = 0.07F;
            this.GRemovalCart.AnimationSpeed = 0.03F;
            this.GRemovalCart.BaseColor = System.Drawing.Color.White;
            this.GRemovalCart.BorderColor = System.Drawing.Color.Black;
            this.GRemovalCart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.GRemovalCart.FocusedColor = System.Drawing.Color.Empty;
            this.GRemovalCart.Font = new System.Drawing.Font("Segoe UI Black", 9F);
            this.GRemovalCart.ForeColor = System.Drawing.Color.IndianRed;
            this.GRemovalCart.Image = null;
            this.GRemovalCart.ImageSize = new System.Drawing.Size(20, 20);
            this.GRemovalCart.Location = new System.Drawing.Point(82, 268);
            this.GRemovalCart.Name = "GRemovalCart";
            this.GRemovalCart.OnHoverBaseColor = System.Drawing.Color.Black;
            this.GRemovalCart.OnHoverBorderColor = System.Drawing.Color.Black;
            this.GRemovalCart.OnHoverForeColor = System.Drawing.Color.White;
            this.GRemovalCart.OnHoverImage = null;
            this.GRemovalCart.OnPressedColor = System.Drawing.Color.Black;
            this.GRemovalCart.Size = new System.Drawing.Size(133, 42);
            this.GRemovalCart.TabIndex = 17;
            this.GRemovalCart.Text = "Remove From Cart";
            this.GRemovalCart.Click += new System.EventHandler(this.RemovalCart_Click);
            // 
            // GcartData
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.GcartData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GcartData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GcartData.BackgroundColor = System.Drawing.Color.White;
            this.GcartData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GcartData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GcartData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GcartData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.GcartData.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GcartData.DefaultCellStyle = dataGridViewCellStyle6;
            this.GcartData.EnableHeadersVisualStyles = false;
            this.GcartData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GcartData.Location = new System.Drawing.Point(112, 61);
            this.GcartData.Name = "GcartData";
            this.GcartData.RowHeadersVisible = false;
            this.GcartData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GcartData.Size = new System.Drawing.Size(265, 102);
            this.GcartData.TabIndex = 1;
            this.GcartData.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.GcartData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.GcartData.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.GcartData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.GcartData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.GcartData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.GcartData.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.GcartData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GcartData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.GcartData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GcartData.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.GcartData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GcartData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.GcartData.ThemeStyle.HeaderStyle.Height = 4;
            this.GcartData.ThemeStyle.ReadOnly = false;
            this.GcartData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GcartData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GcartData.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.GcartData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GcartData.ThemeStyle.RowsStyle.Height = 22;
            this.GcartData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GcartData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // FinalCart
            // 
            this.FinalCart.AutoSize = true;
            this.FinalCart.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalCart.ForeColor = System.Drawing.Color.Olive;
            this.FinalCart.Location = new System.Drawing.Point(188, 18);
            this.FinalCart.Name = "FinalCart";
            this.FinalCart.Size = new System.Drawing.Size(69, 40);
            this.FinalCart.TabIndex = 0;
            this.FinalCart.Text = "Cart";
            // 
            // GcartButton
            // 
            this.GcartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GcartButton.ForeColor = System.Drawing.Color.IndianRed;
            this.GcartButton.Location = new System.Drawing.Point(12, 108);
            this.GcartButton.Name = "GcartButton";
            this.GcartButton.Size = new System.Drawing.Size(116, 76);
            this.GcartButton.TabIndex = 15;
            this.GcartButton.Text = "Cart";
            this.GcartButton.UseVisualStyleBackColor = true;
            this.GcartButton.Click += new System.EventHandler(this.cartButton_Click);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // GMenButton
            // 
            this.GMenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GMenButton.ForeColor = System.Drawing.Color.IndianRed;
            this.GMenButton.Location = new System.Drawing.Point(12, 22);
            this.GMenButton.Name = "GMenButton";
            this.GMenButton.Size = new System.Drawing.Size(116, 76);
            this.GMenButton.TabIndex = 16;
            this.GMenButton.Text = "Menu";
            this.GMenButton.UseVisualStyleBackColor = true;
            this.GMenButton.Click += new System.EventHandler(this.GMenButton_Click);
            // 
            // GlogOutButton
            // 
            this.GlogOutButton.AnimationHoverSpeed = 0.07F;
            this.GlogOutButton.AnimationSpeed = 0.03F;
            this.GlogOutButton.BackColor = System.Drawing.Color.Transparent;
            this.GlogOutButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GlogOutButton.BorderColor = System.Drawing.Color.Black;
            this.GlogOutButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.GlogOutButton.FocusedColor = System.Drawing.Color.Empty;
            this.GlogOutButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GlogOutButton.ForeColor = System.Drawing.Color.White;
            this.GlogOutButton.Image = null;
            this.GlogOutButton.ImageSize = new System.Drawing.Size(20, 20);
            this.GlogOutButton.Location = new System.Drawing.Point(32, 322);
            this.GlogOutButton.Name = "GlogOutButton";
            this.GlogOutButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.GlogOutButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.GlogOutButton.OnHoverForeColor = System.Drawing.Color.White;
            this.GlogOutButton.OnHoverImage = null;
            this.GlogOutButton.OnPressedColor = System.Drawing.Color.Black;
            this.GlogOutButton.Radius = 20;
            this.GlogOutButton.Size = new System.Drawing.Size(96, 54);
            this.GlogOutButton.TabIndex = 17;
            this.GlogOutButton.Text = "Exit";
            this.GlogOutButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GlogOutButton.Click += new System.EventHandler(this.GlogOutButton_Click);
            // 
            // tAmountLabel
            // 
            this.tAmountLabel.AutoSize = true;
            this.tAmountLabel.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tAmountLabel.Location = new System.Drawing.Point(291, 205);
            this.tAmountLabel.Name = "tAmountLabel";
            this.tAmountLabel.Size = new System.Drawing.Size(92, 20);
            this.tAmountLabel.TabIndex = 31;
            this.tAmountLabel.Text = "Total Amount:";
            // 
            // GctAmountT
            // 
            this.GctAmountT.BaseColor = System.Drawing.Color.White;
            this.GctAmountT.BorderColor = System.Drawing.Color.Silver;
            this.GctAmountT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GctAmountT.FocusedBaseColor = System.Drawing.Color.White;
            this.GctAmountT.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.GctAmountT.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.GctAmountT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GctAmountT.Location = new System.Drawing.Point(389, 198);
            this.GctAmountT.Name = "GctAmountT";
            this.GctAmountT.PasswordChar = '\0';
            this.GctAmountT.SelectedText = "";
            this.GctAmountT.Size = new System.Drawing.Size(54, 30);
            this.GctAmountT.TabIndex = 30;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.gunaLabel3.ForeColor = System.Drawing.Color.IndianRed;
            this.gunaLabel3.Location = new System.Drawing.Point(383, 170);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(0, 28);
            this.gunaLabel3.TabIndex = 29;
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GlogOutButton);
            this.Controls.Add(this.GMenButton);
            this.Controls.Add(this.GcartButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GCartPanel);
            this.Controls.Add(this.GcumenPanel);
            this.Name = "GuestForm";
            this.Text = "GuestForm";
            this.Load += new System.EventHandler(this.GuestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GcumenPanel.ResumeLayout(false);
            this.GcumenPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GcustomerMenu)).EndInit();
            this.GCartPanel.ResumeLayout(false);
            this.GCartPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GcartData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel GcumenPanel;
        private System.Windows.Forms.Label GorderQuan;
        private System.Windows.Forms.Label GordId;
        private Guna.UI.WinForms.GunaTextBox GquanT;
        private Guna.UI.WinForms.GunaTextBox GordIDT;
        private Guna.UI.WinForms.GunaButton GaddCart;
        private Guna.UI.WinForms.GunaLabel uID;
        private Guna.UI.WinForms.GunaDataGridView GcustomerMenu;
        private System.Windows.Forms.Label GcumenHeading;
        private System.Windows.Forms.Panel GCartPanel;
        private System.Windows.Forms.Label GCuBalance;
        private Guna.UI.WinForms.GunaTextBox GcuBalanceT;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaButton GfinalCheckoutButton;
        private System.Windows.Forms.Label GctID;
        private Guna.UI.WinForms.GunaTextBox GcdIDT;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton GRemovalCart;
        private Guna.UI.WinForms.GunaDataGridView GcartData;
        private System.Windows.Forms.Label FinalCart;
        private System.Windows.Forms.Button GcartButton;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button GMenButton;
        private Guna.UI.WinForms.GunaButton GlogOutButton;
        private System.Windows.Forms.Label tAmountLabel;
        private Guna.UI.WinForms.GunaTextBox GctAmountT;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
    }
}