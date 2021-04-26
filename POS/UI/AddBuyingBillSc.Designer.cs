namespace POS.UI
{
    partial class AddBuyingBillSc
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
            this.deleteBtn = new System.Windows.Forms.Button();
            this.userText = new System.Windows.Forms.ComboBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.quntInput = new System.Windows.Forms.NumericUpDown();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ProdNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PiecePriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quntCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalOfPieceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otherInput = new System.Windows.Forms.NumericUpDown();
            this.prodText = new System.Windows.Forms.ComboBox();
            this.PaidInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.VendText = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateInput = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.noteText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PiecePriceT = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.print = new System.Windows.Forms.Button();
            this.paidTextDisplay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.calcBtn = new System.Windows.Forms.Button();
            this.allTotalText = new System.Windows.Forms.TextBox();
            this.latText = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.totalText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.quntInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otherInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaidInput)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Red;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Location = new System.Drawing.Point(16, 124);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(73, 48);
            this.deleteBtn.TabIndex = 57;
            this.deleteBtn.Text = "حذف";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // userText
            // 
            this.userText.FormattingEnabled = true;
            this.userText.Location = new System.Drawing.Point(534, 28);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(150, 21);
            this.userText.TabIndex = 37;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Location = new System.Drawing.Point(119, 124);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(76, 48);
            this.AddBtn.TabIndex = 54;
            this.AddBtn.Text = "اضافة";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // quntInput
            // 
            this.quntInput.Location = new System.Drawing.Point(306, 129);
            this.quntInput.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.quntInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quntInput.Name = "quntInput";
            this.quntInput.Size = new System.Drawing.Size(140, 20);
            this.quntInput.TabIndex = 40;
            this.quntInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdNameCol,
            this.PiecePriceCol,
            this.quntCol,
            this.totalOfPieceCol});
            this.dataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView.Location = new System.Drawing.Point(11, 206);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView.Size = new System.Drawing.Size(776, 253);
            this.dataGridView.TabIndex = 63;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // ProdNameCol
            // 
            this.ProdNameCol.HeaderText = "اسم المنتج";
            this.ProdNameCol.Name = "ProdNameCol";
            this.ProdNameCol.ReadOnly = true;
            // 
            // PiecePriceCol
            // 
            this.PiecePriceCol.HeaderText = "سعر الوحده";
            this.PiecePriceCol.Name = "PiecePriceCol";
            this.PiecePriceCol.ReadOnly = true;
            // 
            // quntCol
            // 
            this.quntCol.HeaderText = "الكمية";
            this.quntCol.Name = "quntCol";
            this.quntCol.ReadOnly = true;
            // 
            // totalOfPieceCol
            // 
            this.totalOfPieceCol.HeaderText = "الاجمالي الفرعي";
            this.totalOfPieceCol.Name = "totalOfPieceCol";
            this.totalOfPieceCol.ReadOnly = true;
            // 
            // otherInput
            // 
            this.otherInput.Location = new System.Drawing.Point(306, 26);
            this.otherInput.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.otherInput.Name = "otherInput";
            this.otherInput.Size = new System.Drawing.Size(140, 20);
            this.otherInput.TabIndex = 43;
            // 
            // prodText
            // 
            this.prodText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.prodText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.prodText.FormattingEnabled = true;
            this.prodText.Location = new System.Drawing.Point(533, 119);
            this.prodText.Name = "prodText";
            this.prodText.Size = new System.Drawing.Size(151, 21);
            this.prodText.TabIndex = 39;
            this.prodText.SelectedIndexChanged += new System.EventHandler(this.prodText_SelectedIndexChanged);
            // 
            // PaidInput
            // 
            this.PaidInput.Location = new System.Drawing.Point(306, 67);
            this.PaidInput.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.PaidInput.Name = "PaidInput";
            this.PaidInput.Size = new System.Drawing.Size(140, 20);
            this.PaidInput.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "الكميه";
            // 
            // VendText
            // 
            this.VendText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.VendText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.VendText.FormattingEnabled = true;
            this.VendText.Location = new System.Drawing.Point(534, 66);
            this.VendText.Name = "VendText";
            this.VendText.Size = new System.Drawing.Size(151, 21);
            this.VendText.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(265, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "التاريخ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(698, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "اسم المنتج";
            // 
            // dateInput
            // 
            this.dateInput.Location = new System.Drawing.Point(19, 67);
            this.dateInput.Name = "dateInput";
            this.dateInput.Size = new System.Drawing.Size(230, 20);
            this.dateInput.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(483, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "المدفوع";
            // 
            // noteText
            // 
            this.noteText.Location = new System.Drawing.Point(19, 25);
            this.noteText.Name = "noteText";
            this.noteText.Size = new System.Drawing.Size(230, 20);
            this.noteText.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(698, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "اسم المورد";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(453, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "مصروفات اخري";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(255, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "ملاحظات";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(687, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "اسم المستخدم";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.PiecePriceT);
            this.groupBox1.Controls.Add(this.deleteBtn);
            this.groupBox1.Controls.Add(this.userText);
            this.groupBox1.Controls.Add(this.AddBtn);
            this.groupBox1.Controls.Add(this.quntInput);
            this.groupBox1.Controls.Add(this.otherInput);
            this.groupBox1.Controls.Add(this.prodText);
            this.groupBox1.Controls.Add(this.PaidInput);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.VendText);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateInput);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.noteText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(775, 187);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات فاتورة المشتريات";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(709, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 59;
            this.label10.Text = "سعر الشراء";
            // 
            // PiecePriceT
            // 
            this.PiecePriceT.Location = new System.Drawing.Point(534, 152);
            this.PiecePriceT.Name = "PiecePriceT";
            this.PiecePriceT.ReadOnly = true;
            this.PiecePriceT.Size = new System.Drawing.Size(151, 20);
            this.PiecePriceT.TabIndex = 58;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox2.Controls.Add(this.print);
            this.groupBox2.Controls.Add(this.paidTextDisplay);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.calcBtn);
            this.groupBox2.Controls.Add(this.allTotalText);
            this.groupBox2.Controls.Add(this.latText);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.saveBtn);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(11, 502);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(780, 128);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "الحساب";
            // 
            // print
            // 
            this.print.Enabled = false;
            this.print.Location = new System.Drawing.Point(10, 43);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(97, 44);
            this.print.TabIndex = 86;
            this.print.Text = "طباعه";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // paidTextDisplay
            // 
            this.paidTextDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidTextDisplay.Location = new System.Drawing.Point(428, 81);
            this.paidTextDisplay.Multiline = true;
            this.paidTextDisplay.Name = "paidTextDisplay";
            this.paidTextDisplay.ReadOnly = true;
            this.paidTextDisplay.Size = new System.Drawing.Size(101, 31);
            this.paidTextDisplay.TabIndex = 84;
            this.paidTextDisplay.Text = "0";
            this.paidTextDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(562, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 85;
            this.label5.Text = "المدفوع";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(549, 49);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 13);
            this.label15.TabIndex = 81;
            this.label15.Text = "اجمالي الفاتوره";
            // 
            // calcBtn
            // 
            this.calcBtn.BackColor = System.Drawing.Color.Orange;
            this.calcBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calcBtn.Location = new System.Drawing.Point(657, 34);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(96, 78);
            this.calcBtn.TabIndex = 79;
            this.calcBtn.Text = "حساب الاجمالي";
            this.calcBtn.UseVisualStyleBackColor = false;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // allTotalText
            // 
            this.allTotalText.BackColor = System.Drawing.Color.DarkMagenta;
            this.allTotalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allTotalText.ForeColor = System.Drawing.Color.Yellow;
            this.allTotalText.Location = new System.Drawing.Point(428, 41);
            this.allTotalText.Multiline = true;
            this.allTotalText.Name = "allTotalText";
            this.allTotalText.ReadOnly = true;
            this.allTotalText.Size = new System.Drawing.Size(101, 31);
            this.allTotalText.TabIndex = 80;
            this.allTotalText.Text = "0";
            this.allTotalText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // latText
            // 
            this.latText.BackColor = System.Drawing.Color.GreenYellow;
            this.latText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latText.Location = new System.Drawing.Point(217, 45);
            this.latText.Multiline = true;
            this.latText.Name = "latText";
            this.latText.ReadOnly = true;
            this.latText.Size = new System.Drawing.Size(101, 53);
            this.latText.TabIndex = 77;
            this.latText.Text = "0";
            this.latText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(339, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 78;
            this.label13.Text = "المتبقي";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Location = new System.Drawing.Point(113, 45);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(87, 42);
            this.saveBtn.TabIndex = 76;
            this.saveBtn.Text = "حفظ";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(165, 471);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 69;
            this.label11.Text = "اجمالي ";
            // 
            // totalText
            // 
            this.totalText.Enabled = false;
            this.totalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalText.Location = new System.Drawing.Point(11, 465);
            this.totalText.Multiline = true;
            this.totalText.Name = "totalText";
            this.totalText.ReadOnly = true;
            this.totalText.Size = new System.Drawing.Size(140, 31);
            this.totalText.TabIndex = 70;
            this.totalText.Text = "0";
            this.totalText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddBuyingBillSc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(804, 642);
            this.Controls.Add(this.totalText);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddBuyingBillSc";
            this.Text = "فاتورة المشتريات";
            this.Load += new System.EventHandler(this.AddBuyingBillSc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quntInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otherInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaidInput)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.ComboBox userText;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.NumericUpDown quntInput;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.NumericUpDown otherInput;
        private System.Windows.Forms.ComboBox prodText;
        private System.Windows.Forms.NumericUpDown PaidInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox VendText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox noteText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox paidTextDisplay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox allTotalText;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.TextBox latText;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox PiecePriceT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PiecePriceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn quntCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalOfPieceCol;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.TextBox totalText;
    }
}