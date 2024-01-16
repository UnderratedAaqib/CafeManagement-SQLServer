namespace DATABASE_Project
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.log_name = new System.Windows.Forms.Label();
            this.lg_pass = new System.Windows.Forms.Label();
            this.unamee = new System.Windows.Forms.TextBox();
            this.upass = new System.Windows.Forms.TextBox();
            this.ent_log = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backButton = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // log_name
            // 
            this.log_name.AutoSize = true;
            this.log_name.Font = new System.Drawing.Font("Algerian", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_name.ForeColor = System.Drawing.SystemColors.ControlText;
            this.log_name.Location = new System.Drawing.Point(12, 94);
            this.log_name.Name = "log_name";
            this.log_name.Size = new System.Drawing.Size(193, 36);
            this.log_name.TabIndex = 0;
            this.log_name.Text = "Username";
            this.log_name.Click += new System.EventHandler(this.lgna);
            // 
            // lg_pass
            // 
            this.lg_pass.AutoSize = true;
            this.lg_pass.Font = new System.Drawing.Font("Algerian", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lg_pass.Location = new System.Drawing.Point(4, 159);
            this.lg_pass.Name = "lg_pass";
            this.lg_pass.Size = new System.Drawing.Size(192, 36);
            this.lg_pass.TabIndex = 1;
            this.lg_pass.Text = "Password";
            this.lg_pass.Click += new System.EventHandler(this.lg_pass_Click);
            // 
            // unamee
            // 
            this.unamee.Location = new System.Drawing.Point(202, 109);
            this.unamee.Name = "unamee";
            this.unamee.Size = new System.Drawing.Size(293, 20);
            this.unamee.TabIndex = 2;
            this.unamee.Click += new System.EventHandler(this.unamee_Click);
            this.unamee.TextChanged += new System.EventHandler(this.utextbox);
            // 
            // upass
            // 
            this.upass.Location = new System.Drawing.Point(202, 174);
            this.upass.Name = "upass";
            this.upass.PasswordChar = '*';
            this.upass.Size = new System.Drawing.Size(293, 20);
            this.upass.TabIndex = 3;
            this.upass.Click += new System.EventHandler(this.upasscode);
            // 
            // ent_log
            // 
            this.ent_log.Location = new System.Drawing.Point(330, 290);
            this.ent_log.Name = "ent_log";
            this.ent_log.Size = new System.Drawing.Size(165, 53);
            this.ent_log.TabIndex = 4;
            this.ent_log.Text = "Enter";
            this.ent_log.UseVisualStyleBackColor = true;
            this.ent_log.Click += new System.EventHandler(this.ent_log_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Olive;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(590, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 124);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
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
            this.backButton.Location = new System.Drawing.Point(27, 307);
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
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ent_log);
            this.Controls.Add(this.upass);
            this.Controls.Add(this.unamee);
            this.Controls.Add(this.lg_pass);
            this.Controls.Add(this.log_name);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label log_name;
        private System.Windows.Forms.Label lg_pass;
        private System.Windows.Forms.TextBox unamee;
        private System.Windows.Forms.TextBox upass;
        private System.Windows.Forms.Button ent_log;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaButton backButton;
    }
}