namespace SignUp
{
    partial class AdminLogin
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdminUN = new System.Windows.Forms.TextBox();
            this.txtAdminPW = new System.Windows.Forms.TextBox();
            this.btnAdminExit = new System.Windows.Forms.Button();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin LogIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "UserName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            // 
            // txtAdminUN
            // 
            this.txtAdminUN.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminUN.Location = new System.Drawing.Point(138, 54);
            this.txtAdminUN.Name = "txtAdminUN";
            this.txtAdminUN.Size = new System.Drawing.Size(202, 27);
            this.txtAdminUN.TabIndex = 1;
            // 
            // txtAdminPW
            // 
            this.txtAdminPW.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminPW.Location = new System.Drawing.Point(138, 115);
            this.txtAdminPW.Name = "txtAdminPW";
            this.txtAdminPW.Size = new System.Drawing.Size(202, 27);
            this.txtAdminPW.TabIndex = 1;
            this.txtAdminPW.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnAdminExit
            // 
            this.btnAdminExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminExit.Location = new System.Drawing.Point(138, 196);
            this.btnAdminExit.Name = "btnAdminExit";
            this.btnAdminExit.Size = new System.Drawing.Size(75, 34);
            this.btnAdminExit.TabIndex = 2;
            this.btnAdminExit.Text = "Exit";
            this.btnAdminExit.UseVisualStyleBackColor = true;
            this.btnAdminExit.Click += new System.EventHandler(this.btnAdminExit_Click);
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminLogin.Location = new System.Drawing.Point(265, 196);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(75, 34);
            this.btnAdminLogin.TabIndex = 2;
            this.btnAdminLogin.Text = "Login";
            this.btnAdminLogin.UseVisualStyleBackColor = true;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(5, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 8);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 257);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdminLogin);
            this.Controls.Add(this.btnAdminExit);
            this.Controls.Add(this.txtAdminPW);
            this.Controls.Add(this.txtAdminUN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminLogin";
            this.Text = "AdminLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdminUN;
        private System.Windows.Forms.TextBox txtAdminPW;
        private System.Windows.Forms.Button btnAdminExit;
        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}