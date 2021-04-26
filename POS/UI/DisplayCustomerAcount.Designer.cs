namespace POS.UI
{
    partial class DisplayCustomerAcount
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
            this.label4 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.newVendBal = new System.Windows.Forms.NumericUpDown();
            this.custText = new System.Windows.Forms.ComboBox();
            this.balanceText = new System.Windows.Forms.TextBox();
            this.noteText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.newVendBal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم العميل";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "القيمة المسددة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "حساب العميل";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "سداد العملاء";
            this.label4.Click += new System.EventHandler(this.CustomerName_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.LightGreen;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Location = new System.Drawing.Point(42, 283);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(96, 41);
            this.saveBtn.TabIndex = 19;
            this.saveBtn.Text = "حفظ";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // newVendBal
            // 
            this.newVendBal.Location = new System.Drawing.Point(42, 179);
            this.newVendBal.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.newVendBal.Name = "newVendBal";
            this.newVendBal.Size = new System.Drawing.Size(184, 20);
            this.newVendBal.TabIndex = 18;
            // 
            // custText
            // 
            this.custText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.custText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.custText.FormattingEnabled = true;
            this.custText.Location = new System.Drawing.Point(42, 68);
            this.custText.Name = "custText";
            this.custText.Size = new System.Drawing.Size(184, 21);
            this.custText.TabIndex = 17;
            this.custText.SelectedIndexChanged += new System.EventHandler(this.vendText_SelectedIndexChanged);
            // 
            // balanceText
            // 
            this.balanceText.Enabled = false;
            this.balanceText.Location = new System.Drawing.Point(42, 113);
            this.balanceText.Multiline = true;
            this.balanceText.Name = "balanceText";
            this.balanceText.Size = new System.Drawing.Size(184, 41);
            this.balanceText.TabIndex = 16;
            // 
            // noteText
            // 
            this.noteText.Location = new System.Drawing.Point(42, 220);
            this.noteText.Multiline = true;
            this.noteText.Name = "noteText";
            this.noteText.Size = new System.Drawing.Size(184, 43);
            this.noteText.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "ملاحظات";
            // 
            // DisplayCustomerAcount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(348, 358);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.noteText);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.newVendBal);
            this.Controls.Add(this.custText);
            this.Controls.Add(this.balanceText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DisplayCustomerAcount";
            this.Text = "سداد العملاء";
            this.Load += new System.EventHandler(this.DisplayCustomerAcount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newVendBal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.NumericUpDown newVendBal;
        private System.Windows.Forms.ComboBox custText;
        private System.Windows.Forms.TextBox balanceText;
        private System.Windows.Forms.TextBox noteText;
        private System.Windows.Forms.Label label5;
    }
}