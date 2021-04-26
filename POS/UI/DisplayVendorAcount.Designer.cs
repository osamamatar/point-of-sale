namespace POS.UI
{
    partial class DisplayVendorAcount
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.newVendBal = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vendText = new System.Windows.Forms.ComboBox();
            this.balanceText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.noteText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.newVendBal)).BeginInit();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.LightGreen;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Location = new System.Drawing.Point(29, 279);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(96, 41);
            this.saveBtn.TabIndex = 13;
            this.saveBtn.Text = "حفظ";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // newVendBal
            // 
            this.newVendBal.Location = new System.Drawing.Point(29, 173);
            this.newVendBal.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.newVendBal.Name = "newVendBal";
            this.newVendBal.Size = new System.Drawing.Size(184, 20);
            this.newVendBal.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "حساب المورد";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "القيمة المسددة";
            // 
            // vendText
            // 
            this.vendText.FormattingEnabled = true;
            this.vendText.Location = new System.Drawing.Point(29, 62);
            this.vendText.Name = "vendText";
            this.vendText.Size = new System.Drawing.Size(184, 21);
            this.vendText.TabIndex = 9;
            this.vendText.SelectedIndexChanged += new System.EventHandler(this.vendText_SelectedIndexChanged);
            // 
            // balanceText
            // 
            this.balanceText.Enabled = false;
            this.balanceText.Location = new System.Drawing.Point(29, 107);
            this.balanceText.Multiline = true;
            this.balanceText.Name = "balanceText";
            this.balanceText.Size = new System.Drawing.Size(184, 41);
            this.balanceText.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "اسم المورد";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "سداد الموردين";
            // 
            // noteText
            // 
            this.noteText.Location = new System.Drawing.Point(29, 199);
            this.noteText.Multiline = true;
            this.noteText.Name = "noteText";
            this.noteText.Size = new System.Drawing.Size(184, 43);
            this.noteText.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "ملاحظات";
            // 
            // DisplayVendorAcount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(370, 387);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.noteText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.newVendBal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vendText);
            this.Controls.Add(this.balanceText);
            this.Controls.Add(this.label1);
            this.Name = "DisplayVendorAcount";
            this.Text = "سداد الموردين";
            this.Load += new System.EventHandler(this.DisplayVendorAcount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newVendBal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.NumericUpDown newVendBal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox vendText;
        private System.Windows.Forms.TextBox balanceText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox noteText;
        private System.Windows.Forms.Label label5;
    }
}