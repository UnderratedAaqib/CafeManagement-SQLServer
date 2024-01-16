namespace DATABASE_Project
{
    partial class CashierInformation
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
            this.caInformation = new System.Windows.Forms.DataGridView();
            this.CasBack = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.caInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // caInformation
            // 
            this.caInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.caInformation.Location = new System.Drawing.Point(81, 21);
            this.caInformation.Name = "caInformation";
            this.caInformation.Size = new System.Drawing.Size(506, 325);
            this.caInformation.TabIndex = 0;
            // 
            // CasBack
            // 
            this.CasBack.AnimationHoverSpeed = 0.07F;
            this.CasBack.AnimationSpeed = 0.03F;
            this.CasBack.BackColor = System.Drawing.Color.Transparent;
            this.CasBack.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CasBack.BorderColor = System.Drawing.Color.Black;
            this.CasBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CasBack.FocusedColor = System.Drawing.Color.Empty;
            this.CasBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CasBack.ForeColor = System.Drawing.Color.White;
            this.CasBack.Image = null;
            this.CasBack.ImageSize = new System.Drawing.Size(20, 20);
            this.CasBack.Location = new System.Drawing.Point(39, 365);
            this.CasBack.Name = "CasBack";
            this.CasBack.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CasBack.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CasBack.OnHoverForeColor = System.Drawing.Color.White;
            this.CasBack.OnHoverImage = null;
            this.CasBack.OnPressedColor = System.Drawing.Color.Black;
            this.CasBack.Radius = 20;
            this.CasBack.Size = new System.Drawing.Size(96, 54);
            this.CasBack.TabIndex = 16;
            this.CasBack.Text = "Back";
            this.CasBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CasBack.Click += new System.EventHandler(this.CasBack_Click);
            // 
            // CashierInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CasBack);
            this.Controls.Add(this.caInformation);
            this.Name = "CashierInformation";
            this.Text = "CashierInformation";
            this.Load += new System.EventHandler(this.CashierInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.caInformation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView caInformation;
        private Guna.UI.WinForms.GunaButton CasBack;
    }
}