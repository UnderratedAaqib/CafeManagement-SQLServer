namespace DATABASE_Project
{
    partial class CustomerLogin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.c_passT = new System.Windows.Forms.TextBox();
            this.c_usernameT = new System.Windows.Forms.TextBox();
            this.c_password = new System.Windows.Forms.Label();
            this.c_username = new System.Windows.Forms.Label();
            this.RLogin = new System.Windows.Forms.Button();
            this.gLogin = new System.Windows.Forms.Button();
            this.RegCAccount = new System.Windows.Forms.Label();
            this.reAccount = new System.Windows.Forms.LinkLabel();
            this.backButton = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Olive;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 450);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // c_passT
            // 
            this.c_passT.Location = new System.Drawing.Point(411, 166);
            this.c_passT.Name = "c_passT";
            this.c_passT.PasswordChar = '*';
            this.c_passT.Size = new System.Drawing.Size(293, 20);
            this.c_passT.TabIndex = 7;
            // 
            // c_usernameT
            // 
            this.c_usernameT.Location = new System.Drawing.Point(411, 87);
            this.c_usernameT.Name = "c_usernameT";
            this.c_usernameT.Size = new System.Drawing.Size(293, 20);
            this.c_usernameT.TabIndex = 6;
            // 
            // c_password
            // 
            this.c_password.AutoSize = true;
            this.c_password.Font = new System.Drawing.Font("Algerian", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_password.Location = new System.Drawing.Point(204, 151);
            this.c_password.Name = "c_password";
            this.c_password.Size = new System.Drawing.Size(192, 36);
            this.c_password.TabIndex = 5;
            this.c_password.Text = "Password";
            // 
            // c_username
            // 
            this.c_username.AutoSize = true;
            this.c_username.Font = new System.Drawing.Font("Algerian", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_username.ForeColor = System.Drawing.SystemColors.ControlText;
            this.c_username.Location = new System.Drawing.Point(212, 72);
            this.c_username.Name = "c_username";
            this.c_username.Size = new System.Drawing.Size(193, 36);
            this.c_username.TabIndex = 4;
            this.c_username.Text = "Username";
            // 
            // RLogin
            // 
            this.RLogin.Location = new System.Drawing.Point(530, 211);
            this.RLogin.Name = "RLogin";
            this.RLogin.Size = new System.Drawing.Size(165, 53);
            this.RLogin.TabIndex = 8;
            this.RLogin.Text = "Login";
            this.RLogin.UseVisualStyleBackColor = true;
            this.RLogin.Click += new System.EventHandler(this.RLogin_Click);
            // 
            // gLogin
            // 
            this.gLogin.Location = new System.Drawing.Point(381, 329);
            this.gLogin.Name = "gLogin";
            this.gLogin.Size = new System.Drawing.Size(165, 53);
            this.gLogin.TabIndex = 9;
            this.gLogin.Text = "LoginAsGuest";
            this.gLogin.UseVisualStyleBackColor = true;
            this.gLogin.Click += new System.EventHandler(this.gLogin_Click);
            // 
            // RegCAccount
            // 
            this.RegCAccount.AutoSize = true;
            this.RegCAccount.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegCAccount.Location = new System.Drawing.Point(224, 224);
            this.RegCAccount.Name = "RegCAccount";
            this.RegCAccount.Size = new System.Drawing.Size(181, 23);
            this.RegCAccount.TabIndex = 10;
            this.RegCAccount.Text = "Don\'t have an account?";
            // 
            // reAccount
            // 
            this.reAccount.AutoSize = true;
            this.reAccount.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.reAccount.Location = new System.Drawing.Point(424, 231);
            this.reAccount.Name = "reAccount";
            this.reAccount.Size = new System.Drawing.Size(46, 13);
            this.reAccount.TabIndex = 11;
            this.reAccount.TabStop = true;
            this.reAccount.Text = "Register";
            this.reAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.reAccount_LinkClicked);
            // 
            // backButton
            // 
            this.backButton.AnimationHoverSpeed = 0.07F;
            this.backButton.AnimationSpeed = 0.03F;
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.backButton.BorderColor = System.Drawing.Color.Black;
            this.backButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.backButton.FocusedColor = System.Drawing.Color.Empty;
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Image = null;
            this.backButton.ImageSize = new System.Drawing.Size(20, 20);
            this.backButton.Location = new System.Drawing.Point(32, 329);
            this.backButton.Name = "backButton";
            this.backButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.backButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.backButton.OnHoverForeColor = System.Drawing.Color.White;
            this.backButton.OnHoverImage = null;
            this.backButton.OnPressedColor = System.Drawing.Color.Black;
            this.backButton.Radius = 20;
            this.backButton.Size = new System.Drawing.Size(96, 54);
            this.backButton.TabIndex = 15;
            this.backButton.Text = "Back";
            this.backButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // CustomerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.reAccount);
            this.Controls.Add(this.RegCAccount);
            this.Controls.Add(this.gLogin);
            this.Controls.Add(this.RLogin);
            this.Controls.Add(this.c_passT);
            this.Controls.Add(this.c_usernameT);
            this.Controls.Add(this.c_password);
            this.Controls.Add(this.c_username);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CustomerLogin";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox c_passT;
        private System.Windows.Forms.TextBox c_usernameT;
        private System.Windows.Forms.Label c_password;
        private System.Windows.Forms.Label c_username;
        private System.Windows.Forms.Button RLogin;
        private System.Windows.Forms.Button gLogin;
        private System.Windows.Forms.Label RegCAccount;
        private System.Windows.Forms.LinkLabel reAccount;
        private Guna.UI.WinForms.GunaButton backButton;
    }
}