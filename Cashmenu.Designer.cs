namespace DATABASE_Project
{
    partial class Cashmenu
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.caOrders = new System.Windows.Forms.Button();
            this.orderPanel = new System.Windows.Forms.Panel();
            this.fiOrID = new System.Windows.Forms.Label();
            this.orderIDT = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.finReciept = new Guna.UI.WinForms.GunaButton();
            this.orderData = new System.Windows.Forms.DataGridView();
            this.Orders = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.ClogOutButton = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.orderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderData)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Olive;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 454);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // caOrders
            // 
            this.caOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caOrders.ForeColor = System.Drawing.Color.IndianRed;
            this.caOrders.Location = new System.Drawing.Point(28, 33);
            this.caOrders.Name = "caOrders";
            this.caOrders.Size = new System.Drawing.Size(106, 76);
            this.caOrders.TabIndex = 3;
            this.caOrders.Text = "Orders";
            this.caOrders.UseVisualStyleBackColor = true;
            // 
            // orderPanel
            // 
            this.orderPanel.Controls.Add(this.fiOrID);
            this.orderPanel.Controls.Add(this.orderIDT);
            this.orderPanel.Controls.Add(this.gunaLabel2);
            this.orderPanel.Controls.Add(this.finReciept);
            this.orderPanel.Controls.Add(this.orderData);
            this.orderPanel.Controls.Add(this.Orders);
            this.orderPanel.Location = new System.Drawing.Point(195, 12);
            this.orderPanel.Name = "orderPanel";
            this.orderPanel.Size = new System.Drawing.Size(520, 367);
            this.orderPanel.TabIndex = 4;
            this.orderPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // fiOrID
            // 
            this.fiOrID.AutoSize = true;
            this.fiOrID.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiOrID.Location = new System.Drawing.Point(317, 246);
            this.fiOrID.Name = "fiOrID";
            this.fiOrID.Size = new System.Drawing.Size(66, 20);
            this.fiOrID.TabIndex = 30;
            this.fiOrID.Text = "Order ID:";
            // 
            // orderIDT
            // 
            this.orderIDT.BaseColor = System.Drawing.Color.White;
            this.orderIDT.BorderColor = System.Drawing.Color.Silver;
            this.orderIDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.orderIDT.FocusedBaseColor = System.Drawing.Color.White;
            this.orderIDT.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.orderIDT.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.orderIDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.orderIDT.Location = new System.Drawing.Point(389, 236);
            this.orderIDT.Name = "orderIDT";
            this.orderIDT.PasswordChar = '\0';
            this.orderIDT.SelectedText = "";
            this.orderIDT.Size = new System.Drawing.Size(54, 30);
            this.orderIDT.TabIndex = 29;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.IndianRed;
            this.gunaLabel2.Location = new System.Drawing.Point(383, 204);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(0, 28);
            this.gunaLabel2.TabIndex = 28;
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // finReciept
            // 
            this.finReciept.AnimationHoverSpeed = 0.07F;
            this.finReciept.AnimationSpeed = 0.03F;
            this.finReciept.BaseColor = System.Drawing.Color.White;
            this.finReciept.BorderColor = System.Drawing.Color.Black;
            this.finReciept.DialogResult = System.Windows.Forms.DialogResult.None;
            this.finReciept.FocusedColor = System.Drawing.Color.Empty;
            this.finReciept.Font = new System.Drawing.Font("Segoe UI Black", 9F);
            this.finReciept.ForeColor = System.Drawing.Color.IndianRed;
            this.finReciept.Image = null;
            this.finReciept.ImageSize = new System.Drawing.Size(20, 20);
            this.finReciept.Location = new System.Drawing.Point(338, 280);
            this.finReciept.Name = "finReciept";
            this.finReciept.OnHoverBaseColor = System.Drawing.Color.Black;
            this.finReciept.OnHoverBorderColor = System.Drawing.Color.Black;
            this.finReciept.OnHoverForeColor = System.Drawing.Color.White;
            this.finReciept.OnHoverImage = null;
            this.finReciept.OnPressedColor = System.Drawing.Color.Black;
            this.finReciept.Size = new System.Drawing.Size(133, 42);
            this.finReciept.TabIndex = 27;
            this.finReciept.Text = "Confirm";
            this.finReciept.Click += new System.EventHandler(this.finReciept_Click);
            // 
            // orderData
            // 
            this.orderData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderData.Location = new System.Drawing.Point(45, 68);
            this.orderData.Name = "orderData";
            this.orderData.Size = new System.Drawing.Size(379, 133);
            this.orderData.TabIndex = 2;
            // 
            // Orders
            // 
            this.Orders.AutoSize = true;
            this.Orders.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Orders.ForeColor = System.Drawing.Color.Olive;
            this.Orders.Location = new System.Drawing.Point(200, 12);
            this.Orders.Name = "Orders";
            this.Orders.Size = new System.Drawing.Size(103, 40);
            this.Orders.TabIndex = 1;
            this.Orders.Text = "Orders";
            // 
            // timer3
            // 
            this.timer3.Interval = 4000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // ClogOutButton
            // 
            this.ClogOutButton.AnimationHoverSpeed = 0.07F;
            this.ClogOutButton.AnimationSpeed = 0.03F;
            this.ClogOutButton.BackColor = System.Drawing.Color.Transparent;
            this.ClogOutButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClogOutButton.BorderColor = System.Drawing.Color.Black;
            this.ClogOutButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ClogOutButton.FocusedColor = System.Drawing.Color.Empty;
            this.ClogOutButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClogOutButton.ForeColor = System.Drawing.Color.White;
            this.ClogOutButton.Image = null;
            this.ClogOutButton.ImageSize = new System.Drawing.Size(20, 20);
            this.ClogOutButton.Location = new System.Drawing.Point(28, 280);
            this.ClogOutButton.Name = "ClogOutButton";
            this.ClogOutButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ClogOutButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ClogOutButton.OnHoverForeColor = System.Drawing.Color.White;
            this.ClogOutButton.OnHoverImage = null;
            this.ClogOutButton.OnPressedColor = System.Drawing.Color.Black;
            this.ClogOutButton.Radius = 20;
            this.ClogOutButton.Size = new System.Drawing.Size(96, 54);
            this.ClogOutButton.TabIndex = 15;
            this.ClogOutButton.Text = "LogOut";
            this.ClogOutButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClogOutButton.Click += new System.EventHandler(this.ClogOutButton_Click);
            // 
            // Cashmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClogOutButton);
            this.Controls.Add(this.orderPanel);
            this.Controls.Add(this.caOrders);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Cashmenu";
            this.Text = "Cashmenu";
            this.Load += new System.EventHandler(this.Cashmenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.orderPanel.ResumeLayout(false);
            this.orderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button caOrders;
        private System.Windows.Forms.Panel orderPanel;
        private System.Windows.Forms.DataGridView orderData;
        private System.Windows.Forms.Label Orders;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label fiOrID;
        private Guna.UI.WinForms.GunaTextBox orderIDT;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaButton finReciept;
        private Guna.UI.WinForms.GunaButton ClogOutButton;
    }
}