namespace WindowsFormsApp3
{
    partial class ReportViewAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.LblUserId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDltUser = new System.Windows.Forms.Button();
            this.btnDltReport = new System.Windows.Forms.Button();
            this.btnOldReport = new System.Windows.Forms.Button();
            this.btnNewReport = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRestore);
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.btnNewReport);
            this.panel1.Controls.Add(this.btnOldReport);
            this.panel1.Controls.Add(this.btnDltReport);
            this.panel1.Controls.Add(this.btnDltUser);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.dgvReport);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 503);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LblUserId);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(715, 50);
            this.panel2.TabIndex = 0;
            // 
            // dgvReport
            // 
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(0, 99);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.Size = new System.Drawing.Size(709, 296);
            this.dgvReport.TabIndex = 1;
            this.dgvReport.SelectionChanged += new System.EventHandler(this.dgvReport_SelectionChanged);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(3, 455);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 33);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // LblUserId
            // 
            this.LblUserId.AutoSize = true;
            this.LblUserId.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold);
            this.LblUserId.Location = new System.Drawing.Point(341, 5);
            this.LblUserId.Name = "LblUserId";
            this.LblUserId.Size = new System.Drawing.Size(57, 28);
            this.LblUserId.TabIndex = 5;
            this.LblUserId.Text = "-----";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "USERID";
            // 
            // btnDltUser
            // 
            this.btnDltUser.Location = new System.Drawing.Point(181, 417);
            this.btnDltUser.Name = "btnDltUser";
            this.btnDltUser.Size = new System.Drawing.Size(122, 33);
            this.btnDltUser.TabIndex = 3;
            this.btnDltUser.Text = "DELETE USER";
            this.btnDltUser.UseVisualStyleBackColor = true;
            this.btnDltUser.Click += new System.EventHandler(this.btnDltUser_Click);
            // 
            // btnDltReport
            // 
            this.btnDltReport.Location = new System.Drawing.Point(349, 417);
            this.btnDltReport.Name = "btnDltReport";
            this.btnDltReport.Size = new System.Drawing.Size(123, 33);
            this.btnDltReport.TabIndex = 4;
            this.btnDltReport.Text = "DELETE REPORT";
            this.btnDltReport.UseVisualStyleBackColor = true;
            this.btnDltReport.Click += new System.EventHandler(this.btnDltReport_Click);
            // 
            // btnOldReport
            // 
            this.btnOldReport.Location = new System.Drawing.Point(74, 60);
            this.btnOldReport.Name = "btnOldReport";
            this.btnOldReport.Size = new System.Drawing.Size(122, 33);
            this.btnOldReport.TabIndex = 5;
            this.btnOldReport.Text = "OLD REPORT";
            this.btnOldReport.UseVisualStyleBackColor = true;
            this.btnOldReport.Click += new System.EventHandler(this.btnOldReport_Click);
            // 
            // btnNewReport
            // 
            this.btnNewReport.Location = new System.Drawing.Point(279, 60);
            this.btnNewReport.Name = "btnNewReport";
            this.btnNewReport.Size = new System.Drawing.Size(122, 33);
            this.btnNewReport.TabIndex = 6;
            this.btnNewReport.Text = "NEW REPORT";
            this.btnNewReport.UseVisualStyleBackColor = true;
            this.btnNewReport.Click += new System.EventHandler(this.btnNewReport_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(457, 60);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(212, 33);
            this.btnPrevious.TabIndex = 7;
            this.btnPrevious.Text = "PREVIOUS DELETED USER REPORT";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(527, 417);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(123, 33);
            this.btnRestore.TabIndex = 8;
            this.btnRestore.Text = "RESTORE REPORT";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // ReportViewAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 501);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReportViewAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORT LIST";
            this.Load += new System.EventHandler(this.ReportViewAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNewReport;
        private System.Windows.Forms.Button btnOldReport;
        private System.Windows.Forms.Button btnDltReport;
        private System.Windows.Forms.Button btnDltUser;
        private System.Windows.Forms.Label LblUserId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnRestore;
    }
}