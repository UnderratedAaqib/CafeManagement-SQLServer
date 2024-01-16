namespace DATABASE_Project
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.siButton = new System.Windows.Forms.Button();
            this.loButton = new System.Windows.Forms.Button();
            this.custButton = new System.Windows.Forms.Button();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // siButton
            // 
            this.siButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siButton.Location = new System.Drawing.Point(130, 31);
            this.siButton.Name = "siButton";
            this.siButton.Size = new System.Drawing.Size(191, 65);
            this.siButton.TabIndex = 0;
            this.siButton.Text = "SignUp";
            this.siButton.UseVisualStyleBackColor = true;
            this.siButton.Click += new System.EventHandler(this.Sign_Up);
            // 
            // loButton
            // 
            this.loButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loButton.Location = new System.Drawing.Point(130, 150);
            this.loButton.Name = "loButton";
            this.loButton.Size = new System.Drawing.Size(191, 75);
            this.loButton.TabIndex = 1;
            this.loButton.Text = "Login";
            this.loButton.UseVisualStyleBackColor = true;
            this.loButton.Click += new System.EventHandler(this.Login);
            // 
            // custButton
            // 
            this.custButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custButton.Location = new System.Drawing.Point(130, 279);
            this.custButton.Name = "custButton";
            this.custButton.Size = new System.Drawing.Size(191, 75);
            this.custButton.TabIndex = 2;
            this.custButton.Text = "Customer";
            this.custButton.UseVisualStyleBackColor = true;
            this.custButton.Click += new System.EventHandler(this.custButton_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(454, 2);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(347, 446);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.gunaPictureBox1.TabIndex = 3;
            this.gunaPictureBox1.TabStop = false;
            this.gunaPictureBox1.Click += new System.EventHandler(this.gunaPictureBox1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.custButton);
            this.Controls.Add(this.loButton);
            this.Controls.Add(this.siButton);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button siButton;
        private System.Windows.Forms.Button loButton;
        private System.Windows.Forms.Button custButton;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
    }
}