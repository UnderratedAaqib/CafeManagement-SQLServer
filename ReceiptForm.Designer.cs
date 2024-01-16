namespace DATABASE_Project
{
    partial class ReceiptForm
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
            this.Reciept = new System.Windows.Forms.Label();
            this.orderIDT = new System.Windows.Forms.Label();
            this.reIDT = new System.Windows.Forms.TextBox();
            this.tAmountT = new System.Windows.Forms.TextBox();
            this.tAmount = new System.Windows.Forms.Label();
            this.pAmountT = new System.Windows.Forms.TextBox();
            this.PAmount = new System.Windows.Forms.Label();
            this.cAmountT = new System.Windows.Forms.TextBox();
            this.cAmount = new System.Windows.Forms.Label();
            this.finalMessage = new System.Windows.Forms.Label();
            this.exButton = new Guna.UI.WinForms.GunaLinkLabel();
            this.SuspendLayout();
            // 
            // Reciept
            // 
            this.Reciept.AutoSize = true;
            this.Reciept.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reciept.ForeColor = System.Drawing.Color.Olive;
            this.Reciept.Location = new System.Drawing.Point(311, 9);
            this.Reciept.Name = "Reciept";
            this.Reciept.Size = new System.Drawing.Size(107, 40);
            this.Reciept.TabIndex = 2;
            this.Reciept.Text = "Reciept";
            // 
            // orderIDT
            // 
            this.orderIDT.AutoSize = true;
            this.orderIDT.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIDT.ForeColor = System.Drawing.Color.Olive;
            this.orderIDT.Location = new System.Drawing.Point(77, 66);
            this.orderIDT.Name = "orderIDT";
            this.orderIDT.Size = new System.Drawing.Size(126, 40);
            this.orderIDT.TabIndex = 3;
            this.orderIDT.Text = "Order ID";
            // 
            // reIDT
            // 
            this.reIDT.Location = new System.Drawing.Point(236, 82);
            this.reIDT.Name = "reIDT";
            this.reIDT.Size = new System.Drawing.Size(100, 20);
            this.reIDT.TabIndex = 4;
            this.reIDT.TextChanged += new System.EventHandler(this.reIDT_TextChanged);
            // 
            // tAmountT
            // 
            this.tAmountT.Location = new System.Drawing.Point(236, 146);
            this.tAmountT.Name = "tAmountT";
            this.tAmountT.Size = new System.Drawing.Size(100, 20);
            this.tAmountT.TabIndex = 6;
            // 
            // tAmount
            // 
            this.tAmount.AutoSize = true;
            this.tAmount.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tAmount.ForeColor = System.Drawing.Color.Olive;
            this.tAmount.Location = new System.Drawing.Point(35, 130);
            this.tAmount.Name = "tAmount";
            this.tAmount.Size = new System.Drawing.Size(185, 40);
            this.tAmount.TabIndex = 5;
            this.tAmount.Text = "Total Amount";
            // 
            // pAmountT
            // 
            this.pAmountT.Location = new System.Drawing.Point(236, 208);
            this.pAmountT.Name = "pAmountT";
            this.pAmountT.Size = new System.Drawing.Size(100, 20);
            this.pAmountT.TabIndex = 8;
            // 
            // PAmount
            // 
            this.PAmount.AutoSize = true;
            this.PAmount.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PAmount.ForeColor = System.Drawing.Color.Olive;
            this.PAmount.Location = new System.Drawing.Point(35, 192);
            this.PAmount.Name = "PAmount";
            this.PAmount.Size = new System.Drawing.Size(181, 40);
            this.PAmount.TabIndex = 7;
            this.PAmount.Text = "Paid Amount";
            // 
            // cAmountT
            // 
            this.cAmountT.Location = new System.Drawing.Point(236, 272);
            this.cAmountT.Name = "cAmountT";
            this.cAmountT.Size = new System.Drawing.Size(100, 20);
            this.cAmountT.TabIndex = 10;
            this.cAmountT.TextChanged += new System.EventHandler(this.cAmountT_TextChanged);
            // 
            // cAmount
            // 
            this.cAmount.AutoSize = true;
            this.cAmount.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cAmount.ForeColor = System.Drawing.Color.Olive;
            this.cAmount.Location = new System.Drawing.Point(14, 256);
            this.cAmount.Name = "cAmount";
            this.cAmount.Size = new System.Drawing.Size(216, 40);
            this.cAmount.TabIndex = 9;
            this.cAmount.Text = "Change Amount";
            // 
            // finalMessage
            // 
            this.finalMessage.AutoSize = true;
            this.finalMessage.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalMessage.ForeColor = System.Drawing.Color.Olive;
            this.finalMessage.Location = new System.Drawing.Point(403, 290);
            this.finalMessage.Name = "finalMessage";
            this.finalMessage.Size = new System.Drawing.Size(279, 40);
            this.finalMessage.TabIndex = 11;
            this.finalMessage.Text = "Thanks for Shopping";
            // 
            // exButton
            // 
            this.exButton.AutoSize = true;
            this.exButton.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.exButton.Location = new System.Drawing.Point(709, 323);
            this.exButton.Name = "exButton";
            this.exButton.Size = new System.Drawing.Size(43, 28);
            this.exButton.TabIndex = 12;
            this.exButton.TabStop = true;
            this.exButton.Text = "Exit";
            this.exButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.exButton_LinkClicked);
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exButton);
            this.Controls.Add(this.finalMessage);
            this.Controls.Add(this.cAmountT);
            this.Controls.Add(this.cAmount);
            this.Controls.Add(this.pAmountT);
            this.Controls.Add(this.PAmount);
            this.Controls.Add(this.tAmountT);
            this.Controls.Add(this.tAmount);
            this.Controls.Add(this.reIDT);
            this.Controls.Add(this.orderIDT);
            this.Controls.Add(this.Reciept);
            this.Name = "ReceiptForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.ReceiptForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Reciept;
        private System.Windows.Forms.Label orderIDT;
        private System.Windows.Forms.TextBox reIDT;
        private System.Windows.Forms.TextBox tAmountT;
        private System.Windows.Forms.Label tAmount;
        private System.Windows.Forms.TextBox pAmountT;
        private System.Windows.Forms.Label PAmount;
        private System.Windows.Forms.TextBox cAmountT;
        private System.Windows.Forms.Label cAmount;
        private System.Windows.Forms.Label finalMessage;
        private Guna.UI.WinForms.GunaLinkLabel exButton;
    }
}