namespace POS.UI
{
    partial class AddDeadProduct
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
            this.userText = new System.Windows.Forms.ComboBox();
            this.dateText = new System.Windows.Forms.DateTimePicker();
            this.quntInput = new System.Windows.Forms.NumericUpDown();
            this.nameText = new System.Windows.Forms.ComboBox();
            this.billText = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lab = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.noteText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quntInput)).BeginInit();
            this.SuspendLayout();
            // 
            // userText
            // 
            this.userText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.userText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.userText.FormattingEnabled = true;
            this.userText.Location = new System.Drawing.Point(50, 52);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(180, 21);
            this.userText.TabIndex = 0;
            // 
            // dateText
            // 
            this.dateText.Location = new System.Drawing.Point(30, 301);
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(200, 20);
            this.dateText.TabIndex = 1;
            // 
            // quntInput
            // 
            this.quntInput.Location = new System.Drawing.Point(51, 144);
            this.quntInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.quntInput.Name = "quntInput";
            this.quntInput.Size = new System.Drawing.Size(179, 20);
            this.quntInput.TabIndex = 2;
            // 
            // nameText
            // 
            this.nameText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.nameText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.nameText.FormattingEnabled = true;
            this.nameText.Location = new System.Drawing.Point(50, 94);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(180, 21);
            this.nameText.TabIndex = 3;
            // 
            // billText
            // 
            this.billText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.billText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.billText.FormattingEnabled = true;
            this.billText.Location = new System.Drawing.Point(50, 186);
            this.billText.Name = "billText";
            this.billText.Size = new System.Drawing.Size(180, 21);
            this.billText.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "اسم المستخدم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "اسم المنتج";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "الكمية";
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(244, 189);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(62, 13);
            this.lab.TabIndex = 8;
            this.lab.Text = "رقم الفاتورة";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "تاريخ التلف";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.LightGreen;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Location = new System.Drawing.Point(39, 353);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(91, 33);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "حفظ";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "اضافة منتج  مرتجع";
            // 
            // noteText
            // 
            this.noteText.Location = new System.Drawing.Point(51, 226);
            this.noteText.Multiline = true;
            this.noteText.Name = "noteText";
            this.noteText.Size = new System.Drawing.Size(179, 44);
            this.noteText.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "ملاحظات";
            // 
            // AddDeadProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(364, 437);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.noteText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.billText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.quntInput);
            this.Controls.Add(this.dateText);
            this.Controls.Add(this.userText);
            this.Name = "AddDeadProduct";
            this.Text = "اضافة مرتجع";
            this.Load += new System.EventHandler(this.AddDeadProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quntInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox userText;
        private System.Windows.Forms.DateTimePicker dateText;
        private System.Windows.Forms.NumericUpDown quntInput;
        private System.Windows.Forms.ComboBox nameText;
        private System.Windows.Forms.ComboBox billText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox noteText;
        private System.Windows.Forms.Label label6;
    }
}