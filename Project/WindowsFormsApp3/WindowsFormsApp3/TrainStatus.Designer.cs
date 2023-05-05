namespace WindowsFormsApp3
{
    partial class TrainStatus
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
            this.label11 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDeparture = new System.Windows.Forms.Button();
            this.btnArrived = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnArriving = new System.Windows.Forms.Button();
            this.dgvTrain = new System.Windows.Forms.DataGridView();
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
            this.txtTrainId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblId = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrain)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnDeparture);
            this.panel1.Controls.Add(this.btnArrived);
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnArriving);
            this.panel1.Controls.Add(this.dgvTrain);
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
            this.panel1.Controls.Add(this.txtTrainId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 563);
            this.panel1.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(124, 525);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(604, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "***PLEASE CORRECT TOTAL TICKET BEFORE PRESSING DEAPTURED";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(6, 518);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 37);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDeparture
            // 
            this.btnDeparture.Location = new System.Drawing.Point(641, 470);
            this.btnDeparture.Name = "btnDeparture";
            this.btnDeparture.Size = new System.Drawing.Size(99, 41);
            this.btnDeparture.TabIndex = 21;
            this.btnDeparture.Text = "DEPARTURED";
            this.btnDeparture.UseVisualStyleBackColor = true;
            this.btnDeparture.Click += new System.EventHandler(this.btnDeparture_Click);
            // 
            // btnArrived
            // 
            this.btnArrived.Location = new System.Drawing.Point(641, 415);
            this.btnArrived.Name = "btnArrived";
            this.btnArrived.Size = new System.Drawing.Size(99, 37);
            this.btnArrived.TabIndex = 20;
            this.btnArrived.Text = "ARRIVED";
            this.btnArrived.UseVisualStyleBackColor = true;
            this.btnArrived.Click += new System.EventHandler(this.btnArrived_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(436, 470);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(362, 473);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "AMOUNT";
            // 
            // btnArriving
            // 
            this.btnArriving.Location = new System.Drawing.Point(641, 361);
            this.btnArriving.Name = "btnArriving";
            this.btnArriving.Size = new System.Drawing.Size(99, 40);
            this.btnArriving.TabIndex = 17;
            this.btnArriving.Text = "ARRIVING";
            this.btnArriving.UseVisualStyleBackColor = true;
            this.btnArriving.Click += new System.EventHandler(this.btnArriving_Click);
            // 
            // dgvTrain
            // 
            this.dgvTrain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrain.Location = new System.Drawing.Point(6, 49);
            this.dgvTrain.Name = "dgvTrain";
            this.dgvTrain.Size = new System.Drawing.Size(808, 299);
            this.dgvTrain.TabIndex = 16;
            this.dgvTrain.SelectionChanged += new System.EventHandler(this.dgvTrain_SelectionChanged);
            // 
            // txtSeat
            // 
            this.txtSeat.Location = new System.Drawing.Point(436, 432);
            this.txtSeat.Name = "txtSeat";
            this.txtSeat.Size = new System.Drawing.Size(100, 20);
            this.txtSeat.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(347, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "TOTAL TICKET";
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(436, 395);
            this.txtDay.Name = "txtDay";
            this.txtDay.ReadOnly = true;
            this.txtDay.Size = new System.Drawing.Size(100, 20);
            this.txtDay.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "DAY";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(436, 358);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(100, 20);
            this.txtTime.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "TIME";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(144, 470);
            this.txtTo.Name = "txtTo";
            this.txtTo.ReadOnly = true;
            this.txtTo.Size = new System.Drawing.Size(100, 20);
            this.txtTo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "TO";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(144, 432);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.ReadOnly = true;
            this.txtFrom.Size = new System.Drawing.Size(100, 20);
            this.txtFrom.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "FROM";
            // 
            // txtTrainIName
            // 
            this.txtTrainIName.Location = new System.Drawing.Point(144, 395);
            this.txtTrainIName.Name = "txtTrainIName";
            this.txtTrainIName.ReadOnly = true;
            this.txtTrainIName.Size = new System.Drawing.Size(100, 20);
            this.txtTrainIName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "TRAIN NAME";
            // 
            // txtTrainId
            // 
            this.txtTrainId.Location = new System.Drawing.Point(144, 354);
            this.txtTrainId.Name = "txtTrainId";
            this.txtTrainId.ReadOnly = true;
            this.txtTrainId.Size = new System.Drawing.Size(100, 20);
            this.txtTrainId.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TRAIN ID";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LblId);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(6, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(752, 40);
            this.panel2.TabIndex = 1;
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblId.Location = new System.Drawing.Point(359, 6);
            this.LblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(49, 29);
            this.LblId.TabIndex = 35;
            this.LblId.Text = "----";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(251, 6);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 29);
            this.label9.TabIndex = 34;
            this.label9.Text = "UserID";
            // 
            // TrainStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 573);
            this.Controls.Add(this.panel1);
            this.Name = "TrainStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrainStatus";
            this.Load += new System.EventHandler(this.TrainStatus_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrain)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDeparture;
        private System.Windows.Forms.Button btnArrived;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnArriving;
        private System.Windows.Forms.DataGridView dgvTrain;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
    }
}