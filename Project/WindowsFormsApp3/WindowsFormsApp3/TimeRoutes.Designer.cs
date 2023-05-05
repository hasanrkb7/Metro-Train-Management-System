namespace WindowsFormsApp3
{
    partial class TimeRoutes
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
            this.btnBack = new System.Windows.Forms.Button();
            this.txtTrainId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSeat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTrainIName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblUserId = new System.Windows.Forms.Label();
            this.UserId = new System.Windows.Forms.Label();
            this.dgvTrain = new System.Windows.Forms.DataGridView();
            this.btnPayment = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrain)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnPayment);
            this.panel1.Controls.Add(this.txtTrainId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtSeat);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtDay);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtTime);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtTo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtFrom);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTrainIName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LblUserId);
            this.panel1.Controls.Add(this.UserId);
            this.panel1.Controls.Add(this.dgvTrain);
            this.panel1.Location = new System.Drawing.Point(-6, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 591);
            this.panel1.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(15, 534);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 42);
            this.btnBack.TabIndex = 37;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtTrainId
            // 
            this.txtTrainId.Location = new System.Drawing.Point(212, 367);
            this.txtTrainId.Name = "txtTrainId";
            this.txtTrainId.ReadOnly = true;
            this.txtTrainId.Size = new System.Drawing.Size(100, 20);
            this.txtTrainId.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "TRAIN ID";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(504, 483);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(430, 486);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "AMOUNT";
            // 
            // txtSeat
            // 
            this.txtSeat.Location = new System.Drawing.Point(504, 445);
            this.txtSeat.Name = "txtSeat";
            this.txtSeat.Size = new System.Drawing.Size(100, 20);
            this.txtSeat.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 448);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "TOTAL TICKET";
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(504, 408);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(100, 20);
            this.txtDay.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(430, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "DAY";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(504, 371);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 20);
            this.txtTime.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(430, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "TIME";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(212, 483);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(100, 20);
            this.txtTo.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 486);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "TO";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(212, 445);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(100, 20);
            this.txtFrom.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "FROM";
            // 
            // txtTrainIName
            // 
            this.txtTrainIName.Location = new System.Drawing.Point(212, 408);
            this.txtTrainIName.Name = "txtTrainIName";
            this.txtTrainIName.Size = new System.Drawing.Size(100, 20);
            this.txtTrainIName.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "TRAIN NAME";
            // 
            // LblUserId
            // 
            this.LblUserId.AutoSize = true;
            this.LblUserId.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold);
            this.LblUserId.Location = new System.Drawing.Point(406, 5);
            this.LblUserId.Name = "LblUserId";
            this.LblUserId.Size = new System.Drawing.Size(57, 28);
            this.LblUserId.TabIndex = 8;
            this.LblUserId.Text = "-----";
            // 
            // UserId
            // 
            this.UserId.AutoSize = true;
            this.UserId.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserId.Location = new System.Drawing.Point(279, 5);
            this.UserId.Name = "UserId";
            this.UserId.Size = new System.Drawing.Size(92, 28);
            this.UserId.TabIndex = 4;
            this.UserId.Text = "USERID";
            // 
            // dgvTrain
            // 
            this.dgvTrain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrain.Location = new System.Drawing.Point(15, 108);
            this.dgvTrain.Name = "dgvTrain";
            this.dgvTrain.Size = new System.Drawing.Size(845, 253);
            this.dgvTrain.TabIndex = 1;
            this.dgvTrain.SelectionChanged += new System.EventHandler(this.dgvTrain_SelectionChanged);
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(643, 399);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(184, 66);
            this.btnPayment.TabIndex = 36;
            this.btnPayment.Text = "PAYMENT";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // TimeRoutes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 592);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TimeRoutes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TIME ROUTES ";
            this.Load += new System.EventHandler(this.TimeRoutes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvTrain;
        private System.Windows.Forms.Label LblUserId;
        private System.Windows.Forms.Label UserId;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSeat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTrainIName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTrainId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPayment;
    }
}