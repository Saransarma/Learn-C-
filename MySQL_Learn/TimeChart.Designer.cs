namespace MySQL_Learn
{
    partial class TimeChart
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
            this.btnTime = new System.Windows.Forms.Button();
            this.dataGridTime = new System.Windows.Forms.DataGridView();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTime)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTime
            // 
            this.btnTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTime.Location = new System.Drawing.Point(627, 47);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(139, 40);
            this.btnTime.TabIndex = 0;
            this.btnTime.Text = "Time_Chart";
            this.btnTime.UseVisualStyleBackColor = true;
            this.btnTime.Click += new System.EventHandler(this.btnTime_Click);
            // 
            // dataGridTime
            // 
            this.dataGridTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTime.Location = new System.Drawing.Point(29, 24);
            this.dataGridTime.Name = "dataGridTime";
            this.dataGridTime.RowTemplate.Height = 24;
            this.dataGridTime.Size = new System.Drawing.Size(529, 392);
            this.dataGridTime.TabIndex = 1;
           // this.dataGridTime.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTime_CellContentDoubleClick);
            this.dataGridTime.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridTime_CellMouseDoubleClick);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(627, 135);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnAdmin.TabIndex = 2;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(627, 191);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(75, 23);
            this.btnUser.TabIndex = 3;
            this.btnUser.Text = "User";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // TimeChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.dataGridTime);
            this.Controls.Add(this.btnTime);
            this.Name = "TimeChart";
            this.Text = "TimeChart";
            this.Load += new System.EventHandler(this.TimeChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTime;
        private System.Windows.Forms.DataGridView dataGridTime;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnUser;
    }
}