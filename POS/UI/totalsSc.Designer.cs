namespace POS.UI
{
    partial class totalsSc
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
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTime1 = new System.Windows.Forms.DateTimePicker();
            this.dateTime2 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.calcBtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.expnse = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buyTotal = new System.Windows.Forms.TextBox();
            this.buyLate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buyPaid = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sellTotal = new System.Windows.Forms.TextBox();
            this.sellLate = new System.Windows.Forms.TextBox();
            this.sellPaid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bPaid = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.sPaid = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "مبيعات";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(270, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "الخزنة";
            // 
            // dateTime1
            // 
            this.dateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime1.Location = new System.Drawing.Point(351, 58);
            this.dateTime1.Name = "dateTime1";
            this.dateTime1.Size = new System.Drawing.Size(132, 20);
            this.dateTime1.TabIndex = 15;
            this.dateTime1.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // dateTime2
            // 
            this.dateTime2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime2.Location = new System.Drawing.Point(32, 58);
            this.dateTime2.Name = "dateTime2";
            this.dateTime2.Size = new System.Drawing.Size(133, 20);
            this.dateTime2.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(507, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "من";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(185, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "الي";
            // 
            // calcBtn
            // 
            this.calcBtn.BackColor = System.Drawing.Color.LightGreen;
            this.calcBtn.Location = new System.Drawing.Point(217, 97);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(127, 42);
            this.calcBtn.TabIndex = 24;
            this.calcBtn.Text = "حساب";
            this.calcBtn.UseVisualStyleBackColor = false;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(250, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "المصروفات";
            // 
            // expnse
            // 
            this.expnse.Enabled = false;
            this.expnse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expnse.Location = new System.Drawing.Point(227, 188);
            this.expnse.Multiline = true;
            this.expnse.Name = "expnse";
            this.expnse.Size = new System.Drawing.Size(100, 34);
            this.expnse.TabIndex = 25;
            this.expnse.Text = "0";
            this.expnse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bPaid);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.buyTotal);
            this.groupBox1.Controls.Add(this.buyLate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buyPaid);
            this.groupBox1.Location = new System.Drawing.Point(351, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(200, 225);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // buyTotal
            // 
            this.buyTotal.Enabled = false;
            this.buyTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTotal.Location = new System.Drawing.Point(13, 167);
            this.buyTotal.Multiline = true;
            this.buyTotal.Name = "buyTotal";
            this.buyTotal.Size = new System.Drawing.Size(100, 34);
            this.buyTotal.TabIndex = 27;
            this.buyTotal.Text = "0";
            this.buyTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buyLate
            // 
            this.buyLate.Enabled = false;
            this.buyLate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyLate.Location = new System.Drawing.Point(13, 76);
            this.buyLate.Multiline = true;
            this.buyLate.Name = "buyLate";
            this.buyLate.Size = new System.Drawing.Size(100, 34);
            this.buyLate.TabIndex = 26;
            this.buyLate.Text = "0";
            this.buyLate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(143, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "الاجمالي";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(143, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "المتبقي";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(127, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "المدفوع نقدا";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "مشتريات";
            // 
            // buyPaid
            // 
            this.buyPaid.Enabled = false;
            this.buyPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyPaid.Location = new System.Drawing.Point(13, 27);
            this.buyPaid.Multiline = true;
            this.buyPaid.Name = "buyPaid";
            this.buyPaid.Size = new System.Drawing.Size(100, 34);
            this.buyPaid.TabIndex = 21;
            this.buyPaid.Text = "0";
            this.buyPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sPaid);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.sellTotal);
            this.groupBox2.Controls.Add(this.sellLate);
            this.groupBox2.Controls.Add(this.sellPaid);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(26, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(186, 225);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // sellTotal
            // 
            this.sellTotal.Enabled = false;
            this.sellTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellTotal.Location = new System.Drawing.Point(6, 164);
            this.sellTotal.Multiline = true;
            this.sellTotal.Name = "sellTotal";
            this.sellTotal.Size = new System.Drawing.Size(100, 34);
            this.sellTotal.TabIndex = 29;
            this.sellTotal.Text = "0";
            this.sellTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sellLate
            // 
            this.sellLate.Enabled = false;
            this.sellLate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellLate.Location = new System.Drawing.Point(6, 111);
            this.sellLate.Multiline = true;
            this.sellLate.Name = "sellLate";
            this.sellLate.Size = new System.Drawing.Size(100, 34);
            this.sellLate.TabIndex = 28;
            this.sellLate.Text = "0";
            this.sellLate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sellPaid
            // 
            this.sellPaid.Enabled = false;
            this.sellPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellPaid.Location = new System.Drawing.Point(7, 18);
            this.sellPaid.Multiline = true;
            this.sellPaid.Name = "sellPaid";
            this.sellPaid.Size = new System.Drawing.Size(100, 34);
            this.sellPaid.TabIndex = 27;
            this.sellPaid.Text = "0";
            this.sellPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "الاجمالي";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "المتبقي";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "المدفوع نقدا";
            // 
            // bPaid
            // 
            this.bPaid.Enabled = false;
            this.bPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPaid.Location = new System.Drawing.Point(13, 117);
            this.bPaid.Multiline = true;
            this.bPaid.Name = "bPaid";
            this.bPaid.Size = new System.Drawing.Size(100, 34);
            this.bPaid.TabIndex = 29;
            this.bPaid.Text = "0";
            this.bPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(143, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "المسدد";
            // 
            // sPaid
            // 
            this.sPaid.Enabled = false;
            this.sPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sPaid.Location = new System.Drawing.Point(7, 71);
            this.sPaid.Multiline = true;
            this.sPaid.Name = "sPaid";
            this.sPaid.Size = new System.Drawing.Size(100, 34);
            this.sPaid.TabIndex = 31;
            this.sPaid.Text = "0";
            this.sPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(134, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "المسدد";
            // 
            // totalsSc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(566, 356);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.expnse);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTime2);
            this.Controls.Add(this.dateTime1);
            this.Controls.Add(this.label6);
            this.Name = "totalsSc";
            this.Text = "totalsSc";
            this.Load += new System.EventHandler(this.totalsSc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTime1;
        private System.Windows.Forms.DateTimePicker dateTime2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox expnse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox buyTotal;
        private System.Windows.Forms.TextBox buyLate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox buyPaid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox sellTotal;
        private System.Windows.Forms.TextBox sellLate;
        private System.Windows.Forms.TextBox sellPaid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bPaid;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox sPaid;
        private System.Windows.Forms.Label label14;
    }
}