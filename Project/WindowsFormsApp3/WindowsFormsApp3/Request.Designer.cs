namespace WindowsFormsApp3
{
    partial class Request
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
            this.DgvRequest = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Approve = new System.Windows.Forms.Button();
            this.Reject = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LblId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LblUid = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblPhn = new System.Windows.Forms.Label();
            this.LblDob = new System.Windows.Forms.Label();
            this.LblAddress = new System.Windows.Forms.Label();
            this.LblNid = new System.Windows.Forms.Label();
            this.LblGender = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvRequest
            // 
            this.DgvRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRequest.Location = new System.Drawing.Point(12, 54);
            this.DgvRequest.Name = "DgvRequest";
            this.DgvRequest.Size = new System.Drawing.Size(687, 232);
            this.DgvRequest.TabIndex = 0;
        
            this.DgvRequest.SelectionChanged += new System.EventHandler(this.DgvRequest_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "USERID";
            // 
            // Approve
            // 
            this.Approve.Location = new System.Drawing.Point(230, 475);
            this.Approve.Name = "Approve";
            this.Approve.Size = new System.Drawing.Size(75, 23);
            this.Approve.TabIndex = 3;
            this.Approve.Text = "APPROVE";
            this.Approve.UseVisualStyleBackColor = true;
            this.Approve.Click += new System.EventHandler(this.Approve_Click);
            // 
            // Reject
            // 
            this.Reject.Location = new System.Drawing.Point(356, 475);
            this.Reject.Name = "Reject";
            this.Reject.Size = new System.Drawing.Size(75, 23);
            this.Reject.TabIndex = 4;
            this.Reject.Text = "REJECT";
            this.Reject.UseVisualStyleBackColor = true;
            this.Reject.Click += new System.EventHandler(this.Reject_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(206, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 36);
            this.label2.TabIndex = 18;
            this.label2.Text = "ID";
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold);
            this.LblId.Location = new System.Drawing.Point(275, 9);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(70, 36);
            this.LblId.TabIndex = 19;
            this.LblId.Text = "-----";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "NAME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "NID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "EMAIL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "DOB";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(323, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(261, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "PHONE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(461, 342);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "ADDRESS";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(461, 310);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "GENDER";
            // 
            // LblUid
            // 
            this.LblUid.AutoSize = true;
            this.LblUid.Location = new System.Drawing.Point(101, 310);
            this.LblUid.Name = "LblUid";
            this.LblUid.Size = new System.Drawing.Size(22, 13);
            this.LblUid.TabIndex = 28;
            this.LblUid.Text = "-----";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(101, 351);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(22, 13);
            this.LblName.TabIndex = 29;
            this.LblName.Text = "-----";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(323, 310);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(22, 13);
            this.LblEmail.TabIndex = 30;
            this.LblEmail.Text = "-----";
            // 
            // LblPhn
            // 
            this.LblPhn.AutoSize = true;
            this.LblPhn.Location = new System.Drawing.Point(323, 351);
            this.LblPhn.Name = "LblPhn";
            this.LblPhn.Size = new System.Drawing.Size(22, 13);
            this.LblPhn.TabIndex = 31;
            this.LblPhn.Text = "-----";
            // 
            // LblDob
            // 
            this.LblDob.AutoSize = true;
            this.LblDob.Location = new System.Drawing.Point(323, 399);
            this.LblDob.Name = "LblDob";
            this.LblDob.Size = new System.Drawing.Size(22, 13);
            this.LblDob.TabIndex = 32;
            this.LblDob.Text = "-----";
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Location = new System.Drawing.Point(547, 342);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(22, 13);
            this.LblAddress.TabIndex = 33;
            this.LblAddress.Text = "-----";
            // 
            // LblNid
            // 
            this.LblNid.AutoSize = true;
            this.LblNid.Location = new System.Drawing.Point(101, 399);
            this.LblNid.Name = "LblNid";
            this.LblNid.Size = new System.Drawing.Size(22, 13);
            this.LblNid.TabIndex = 34;
            this.LblNid.Text = "-----";
            // 
            // LblGender
            // 
            this.LblGender.AutoSize = true;
            this.LblGender.Location = new System.Drawing.Point(547, 310);
            this.LblGender.Name = "LblGender";
            this.LblGender.Size = new System.Drawing.Size(22, 13);
            this.LblGender.TabIndex = 35;
            this.LblGender.Text = "-----";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(461, 382);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "USERNAME";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(461, 416);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "PASSWORD";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(547, 382);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(22, 13);
            this.lblUserName.TabIndex = 38;
            this.lblUserName.Text = "-----";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(547, 416);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(22, 13);
            this.lblPassword.TabIndex = 39;
            this.lblPassword.Text = "-----";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(95, 475);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 40;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(711, 520);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.LblGender);
            this.Controls.Add(this.LblNid);
            this.Controls.Add(this.LblAddress);
            this.Controls.Add(this.LblDob);
            this.Controls.Add(this.LblPhn);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblUid);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Reject);
            this.Controls.Add(this.Approve);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvRequest);
            this.Name = "Request";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Request";
            this.Load += new System.EventHandler(this.Request_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvRequest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvRequest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Approve;
        private System.Windows.Forms.Button Reject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LblUid;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblPhn;
        private System.Windows.Forms.Label LblDob;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Label LblNid;
        private System.Windows.Forms.Label LblGender;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnBack;
    }
}