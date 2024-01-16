namespace DATABASE_Project
{
    partial class SignUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.unm = new System.Windows.Forms.TextBox();
            this.eml = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.paso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.id1 = new System.Windows.Forms.TextBox();
            this.co = new System.Windows.Forms.Label();
            this.no = new System.Windows.Forms.TextBox();
            this.exp = new System.Windows.Forms.Label();
            this.ep = new System.Windows.Forms.Label();
            this.expr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.Name1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            this.label2.Click += new System.EventHandler(this.ema);
            // 
            // unm
            // 
            this.unm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unm.Location = new System.Drawing.Point(177, 105);
            this.unm.Name = "unm";
            this.unm.Size = new System.Drawing.Size(330, 23);
            this.unm.TabIndex = 2;
            this.unm.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // eml
            // 
            this.eml.Location = new System.Drawing.Point(132, 155);
            this.eml.Multiline = true;
            this.eml.Name = "eml";
            this.eml.Size = new System.Drawing.Size(338, 20);
            this.eml.TabIndex = 3;
            this.eml.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.passw);
            // 
            // paso
            // 
            this.paso.Location = new System.Drawing.Point(168, 202);
            this.paso.Name = "paso";
            this.paso.Size = new System.Drawing.Size(288, 20);
            this.paso.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(201, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(318, 46);
            this.label4.TabIndex = 6;
            this.label4.Text = "REGISTRATION";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(590, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 78);
            this.button1.TabIndex = 7;
            this.button1.Text = "SignUp";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Signup_button);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(52, 54);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(42, 31);
            this.ID.TabIndex = 8;
            this.ID.Text = "ID";
            this.ID.Click += new System.EventHandler(this.id21);
            // 
            // id1
            // 
            this.id1.Location = new System.Drawing.Point(100, 58);
            this.id1.Name = "id1";
            this.id1.Size = new System.Drawing.Size(100, 20);
            this.id1.TabIndex = 9;
            this.id1.TextChanged += new System.EventHandler(this.id1_TextChanged);
            // 
            // co
            // 
            this.co.AutoSize = true;
            this.co.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.co.Location = new System.Drawing.Point(59, 248);
            this.co.Name = "co";
            this.co.Size = new System.Drawing.Size(94, 29);
            this.co.TabIndex = 10;
            this.co.Text = "Contact";
            this.co.Click += new System.EventHandler(this.nm);
            // 
            // no
            // 
            this.no.Location = new System.Drawing.Point(159, 257);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(224, 20);
            this.no.TabIndex = 11;
            this.no.TextChanged += new System.EventHandler(this.number_TextChanged);
            // 
            // exp
            // 
            this.exp.Location = new System.Drawing.Point(0, 0);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(100, 23);
            this.exp.TabIndex = 0;
            // 
            // ep
            // 
            this.ep.AutoSize = true;
            this.ep.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ep.Location = new System.Drawing.Point(53, 292);
            this.ep.Name = "ep";
            this.ep.Size = new System.Drawing.Size(135, 29);
            this.ep.TabIndex = 12;
            this.ep.Text = "Experience";
            // 
            // expr
            // 
            this.expr.Location = new System.Drawing.Point(194, 301);
            this.expr.Name = "expr";
            this.expr.Size = new System.Drawing.Size(170, 20);
            this.expr.TabIndex = 13;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(821, 450);
            this.Controls.Add(this.expr);
            this.Controls.Add(this.ep);
            this.Controls.Add(this.exp);
            this.Controls.Add(this.no);
            this.Controls.Add(this.co);
            this.Controls.Add(this.id1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.paso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.eml);
            this.Controls.Add(this.unm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox unm;
        private System.Windows.Forms.TextBox eml;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox paso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox id1;
        private System.Windows.Forms.Label co;
        private System.Windows.Forms.TextBox no;
        private System.Windows.Forms.Label exp;
        private System.Windows.Forms.Label ep;
        private System.Windows.Forms.TextBox expr;
    }
}