namespace DATABASE_Project
{
    partial class HighestCustomer
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
            this.highestCus = new System.Windows.Forms.DataGridView();
            this.HCasBack = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.highestCus)).BeginInit();
            this.SuspendLayout();
            // 
            // highestCus
            // 
            this.highestCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.highestCus.Location = new System.Drawing.Point(183, 63);
            this.highestCus.Name = "highestCus";
            this.highestCus.Size = new System.Drawing.Size(420, 63);
            this.highestCus.TabIndex = 0;
            this.highestCus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // HCasBack
            // 
            this.HCasBack.AnimationHoverSpeed = 0.07F;
            this.HCasBack.AnimationSpeed = 0.03F;
            this.HCasBack.BackColor = System.Drawing.Color.Transparent;
            this.HCasBack.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.HCasBack.BorderColor = System.Drawing.Color.Black;
            this.HCasBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.HCasBack.FocusedColor = System.Drawing.Color.Empty;
            this.HCasBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.HCasBack.ForeColor = System.Drawing.Color.White;
            this.HCasBack.Image = null;
            this.HCasBack.ImageSize = new System.Drawing.Size(20, 20);
            this.HCasBack.Location = new System.Drawing.Point(24, 357);
            this.HCasBack.Name = "HCasBack";
            this.HCasBack.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.HCasBack.OnHoverBorderColor = System.Drawing.Color.Black;
            this.HCasBack.OnHoverForeColor = System.Drawing.Color.White;
            this.HCasBack.OnHoverImage = null;
            this.HCasBack.OnPressedColor = System.Drawing.Color.Black;
            this.HCasBack.Radius = 20;
            this.HCasBack.Size = new System.Drawing.Size(96, 54);
            this.HCasBack.TabIndex = 17;
            this.HCasBack.Text = "Back";
            this.HCasBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HCasBack.Click += new System.EventHandler(this.HCasBack_Click);
            // 
            // HighestCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HCasBack);
            this.Controls.Add(this.highestCus);
            this.Name = "HighestCustomer";
            this.Text = "HighestCustomer";
            this.Load += new System.EventHandler(this.HighestCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.highestCus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView highestCus;
        private Guna.UI.WinForms.GunaButton HCasBack;
    }
}