namespace POS.UI
{
    partial class AddSillingBillSc
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.PiecePriceT = new System.Windows.Forms.TextBox();
            this.userText = new System.Windows.Forms.ComboBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.quntInput = new System.Windows.Forms.NumericUpDown();
            this.otherInput = new System.Windows.Forms.NumericUpDown();
            this.prodText = new System.Windows.Forms.ComboBox();
            this.PaidInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cutText = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateInput = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.noteText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.totalText = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQunt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSubt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.totBeforText = new System.Windows.Forms.TextBox();
            this.print = new System.Windows.Forms.Button();
            this.paidTextDisplay = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.disTextDisplay = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.allTotalText = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.calcBtn = new System.Windows.Forms.Button();
            this.latText = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.PieceDisInput = new System.Windows.Forms.TextBox();
            this.BillDisInput = new System.Windows.Forms.TextBox();
            this.sillBillDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quntInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otherInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaidInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sillBillDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.BillDisInput);
            this.groupBox1.Controls.Add(this.PieceDisInput);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.PiecePriceT);
            this.groupBox1.Controls.Add(this.userText);
            this.groupBox1.Controls.Add(this.AddBtn);
            this.groupBox1.Controls.Add(this.quntInput);
            this.groupBox1.Controls.Add(this.otherInput);
            this.groupBox1.Controls.Add(this.prodText);
            this.groupBox1.Controls.Add(this.PaidInput);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cutText);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateInput);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.noteText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(803, 201);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات فاتورة المبيعات";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(24, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 79);
            this.button1.TabIndex = 57;
            this.button1.Text = "حذف";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(734, 178);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 15);
            this.label13.TabIndex = 56;
            this.label13.Text = "السعر";
            // 
            // PiecePriceT
            // 
            this.PiecePriceT.Location = new System.Drawing.Point(568, 172);
            this.PiecePriceT.Name = "PiecePriceT";
            this.PiecePriceT.ReadOnly = true;
            this.PiecePriceT.Size = new System.Drawing.Size(151, 21);
            this.PiecePriceT.TabIndex = 55;
            // 
            // userText
            // 
            this.userText.FormattingEnabled = true;
            this.userText.Location = new System.Drawing.Point(540, 19);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(179, 23);
            this.userText.TabIndex = 37;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Location = new System.Drawing.Point(160, 113);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(96, 79);
            this.AddBtn.TabIndex = 54;
            this.AddBtn.Text = "اضافة";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // quntInput
            // 
            this.quntInput.Location = new System.Drawing.Point(311, 167);
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
            this.quntInput.Size = new System.Drawing.Size(140, 21);
            this.quntInput.TabIndex = 40;
            this.quntInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // otherInput
            // 
            this.otherInput.Location = new System.Drawing.Point(311, 18);
            this.otherInput.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.otherInput.Name = "otherInput";
            this.otherInput.Size = new System.Drawing.Size(140, 21);
            this.otherInput.TabIndex = 43;
            this.otherInput.ValueChanged += new System.EventHandler(this.otherInput_ValueChanged);
            // 
            // prodText
            // 
            this.prodText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.prodText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.prodText.FormattingEnabled = true;
            this.prodText.Location = new System.Drawing.Point(568, 140);
            this.prodText.Name = "prodText";
            this.prodText.Size = new System.Drawing.Size(151, 23);
            this.prodText.TabIndex = 39;
            this.prodText.SelectedIndexChanged += new System.EventHandler(this.prodText_SelectedIndexChanged);
            // 
            // PaidInput
            // 
            this.PaidInput.Location = new System.Drawing.Point(311, 62);
            this.PaidInput.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.PaidInput.Name = "PaidInput";
            this.PaidInput.Size = new System.Drawing.Size(140, 21);
            this.PaidInput.TabIndex = 42;
            this.PaidInput.ValueChanged += new System.EventHandler(this.PaidInput_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(474, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 44;
            this.label1.Text = "الكميه";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(704, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 15);
            this.label10.TabIndex = 51;
            this.label10.Text = "الخصم علي الفاتورة";
            // 
            // cutText
            // 
            this.cutText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cutText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cutText.FormattingEnabled = true;
            this.cutText.Location = new System.Drawing.Point(540, 57);
            this.cutText.Name = "cutText";
            this.cutText.Size = new System.Drawing.Size(179, 23);
            this.cutText.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(471, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 45;
            this.label5.Text = "الخصم";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 46;
            this.label6.Text = "التاريخ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(733, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 36;
            this.label4.Text = "اسم المنتج";
            // 
            // dateInput
            // 
            this.dateInput.Location = new System.Drawing.Point(24, 59);
            this.dateInput.Name = "dateInput";
            this.dateInput.Size = new System.Drawing.Size(230, 21);
            this.dateInput.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(488, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 47;
            this.label7.Text = "المدفوع";
            // 
            // noteText
            // 
            this.noteText.Location = new System.Drawing.Point(24, 17);
            this.noteText.Name = "noteText";
            this.noteText.Size = new System.Drawing.Size(230, 21);
            this.noteText.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(743, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 35;
            this.label3.Text = "اسم العميل";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(458, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 15);
            this.label9.TabIndex = 49;
            this.label9.Text = "مصروفات اخري";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(260, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 48;
            this.label8.Text = "ملاحظات";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(732, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 34;
            this.label2.Text = "اسم المستخدم";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(161, 472);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 15);
            this.label11.TabIndex = 52;
            this.label11.Text = "اجمالي ";
            // 
            // totalText
            // 
            this.totalText.Enabled = false;
            this.totalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalText.Location = new System.Drawing.Point(15, 466);
            this.totalText.Multiline = true;
            this.totalText.Name = "totalText";
            this.totalText.ReadOnly = true;
            this.totalText.Size = new System.Drawing.Size(140, 31);
            this.totalText.TabIndex = 32;
            this.totalText.Text = "0";
            this.totalText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalText.TextChanged += new System.EventHandler(this.totalText_TextChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.ColPrice,
            this.ColQunt,
            this.ColDis,
            this.ColSubt});
            this.dataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView.Location = new System.Drawing.Point(14, 219);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView.Size = new System.Drawing.Size(803, 244);
            this.dataGridView.TabIndex = 56;
            // 
            // colName
            // 
            this.colName.HeaderText = "اسم المنتج";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // ColPrice
            // 
            this.ColPrice.HeaderText = "سعر الوحدة";
            this.ColPrice.Name = "ColPrice";
            this.ColPrice.ReadOnly = true;
            // 
            // ColQunt
            // 
            this.ColQunt.HeaderText = "الكمية";
            this.ColQunt.Name = "ColQunt";
            this.ColQunt.ReadOnly = true;
            // 
            // ColDis
            // 
            this.ColDis.HeaderText = "الخصم";
            this.ColDis.Name = "ColDis";
            this.ColDis.ReadOnly = true;
            // 
            // ColSubt
            // 
            this.ColSubt.HeaderText = "الاجمالي الفرعي";
            this.ColSubt.Name = "ColSubt";
            this.ColSubt.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.totBeforText);
            this.groupBox2.Controls.Add(this.print);
            this.groupBox2.Controls.Add(this.paidTextDisplay);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.disTextDisplay);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.allTotalText);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.calcBtn);
            this.groupBox2.Controls.Add(this.latText);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.PrintBtn);
            this.groupBox2.Location = new System.Drawing.Point(15, 503);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(802, 139);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "الحساب";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(551, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(114, 15);
            this.label17.TabIndex = 88;
            this.label17.Text = "اجمالي الفاتوره قبل الخصم";
            // 
            // totBeforText
            // 
            this.totBeforText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totBeforText.Location = new System.Drawing.Point(444, 16);
            this.totBeforText.Multiline = true;
            this.totBeforText.Name = "totBeforText";
            this.totBeforText.ReadOnly = true;
            this.totBeforText.Size = new System.Drawing.Size(101, 33);
            this.totBeforText.TabIndex = 87;
            this.totBeforText.Text = "0";
            this.totBeforText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // print
            // 
            this.print.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.print.Enabled = false;
            this.print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.print.Location = new System.Drawing.Point(6, 71);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(161, 44);
            this.print.TabIndex = 86;
            this.print.Text = "طباعة";
            this.print.UseVisualStyleBackColor = false;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // paidTextDisplay
            // 
            this.paidTextDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidTextDisplay.Location = new System.Drawing.Point(444, 96);
            this.paidTextDisplay.Multiline = true;
            this.paidTextDisplay.Name = "paidTextDisplay";
            this.paidTextDisplay.ReadOnly = true;
            this.paidTextDisplay.Size = new System.Drawing.Size(101, 31);
            this.paidTextDisplay.TabIndex = 84;
            this.paidTextDisplay.Text = "0";
            this.paidTextDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(578, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 15);
            this.label12.TabIndex = 85;
            this.label12.Text = "المدفوع";
            // 
            // disTextDisplay
            // 
            this.disTextDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disTextDisplay.Location = new System.Drawing.Point(444, 54);
            this.disTextDisplay.Multiline = true;
            this.disTextDisplay.Name = "disTextDisplay";
            this.disTextDisplay.ReadOnly = true;
            this.disTextDisplay.Size = new System.Drawing.Size(101, 33);
            this.disTextDisplay.TabIndex = 82;
            this.disTextDisplay.Text = "0";
            this.disTextDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(567, 65);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 15);
            this.label16.TabIndex = 83;
            this.label16.Text = "الخصم علي الفاتورة";
            // 
            // allTotalText
            // 
            this.allTotalText.BackColor = System.Drawing.Color.DarkMagenta;
            this.allTotalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allTotalText.ForeColor = System.Drawing.Color.Yellow;
            this.allTotalText.Location = new System.Drawing.Point(200, 19);
            this.allTotalText.Multiline = true;
            this.allTotalText.Name = "allTotalText";
            this.allTotalText.ReadOnly = true;
            this.allTotalText.Size = new System.Drawing.Size(101, 30);
            this.allTotalText.TabIndex = 80;
            this.allTotalText.Text = "0";
            this.allTotalText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(321, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 15);
            this.label15.TabIndex = 81;
            this.label15.Text = "اجمالي الفاتوره  بعد الخصم";
            // 
            // calcBtn
            // 
            this.calcBtn.BackColor = System.Drawing.Color.Orange;
            this.calcBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calcBtn.Location = new System.Drawing.Point(688, 29);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(89, 56);
            this.calcBtn.TabIndex = 79;
            this.calcBtn.Text = "حساب الاجمالي";
            this.calcBtn.UseVisualStyleBackColor = false;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // latText
            // 
            this.latText.BackColor = System.Drawing.Color.GreenYellow;
            this.latText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latText.Location = new System.Drawing.Point(200, 65);
            this.latText.Multiline = true;
            this.latText.Name = "latText";
            this.latText.ReadOnly = true;
            this.latText.Size = new System.Drawing.Size(101, 52);
            this.latText.TabIndex = 77;
            this.latText.Text = "0";
            this.latText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(334, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 15);
            this.label14.TabIndex = 78;
            this.label14.Text = "المتبقي";
            // 
            // PrintBtn
            // 
            this.PrintBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.PrintBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintBtn.Location = new System.Drawing.Point(6, 20);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(161, 44);
            this.PrintBtn.TabIndex = 76;
            this.PrintBtn.Text = "حفظ";
            this.PrintBtn.UseVisualStyleBackColor = false;
            this.PrintBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // PieceDisInput
            // 
            this.PieceDisInput.Location = new System.Drawing.Point(311, 136);
            this.PieceDisInput.Name = "PieceDisInput";
            this.PieceDisInput.Size = new System.Drawing.Size(140, 21);
            this.PieceDisInput.TabIndex = 58;
            this.PieceDisInput.Text = "0";
            this.PieceDisInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PieceDisInput_KeyPress);
            // 
            // BillDisInput
            // 
            this.BillDisInput.Location = new System.Drawing.Point(558, 101);
            this.BillDisInput.Name = "BillDisInput";
            this.BillDisInput.Size = new System.Drawing.Size(140, 21);
            this.BillDisInput.TabIndex = 59;
            this.BillDisInput.Text = "0";
            this.BillDisInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BillDisInput_KeyPress);
            // 
            // sillBillDetailsBindingSource
            // 
            this.sillBillDetailsBindingSource.DataSource = typeof(POS.Util.SillBillDetails);
            // 
            // AddSillingBillSc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(834, 645);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.totalText);
            this.Controls.Add(this.label11);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddSillingBillSc";
            this.Text = "فاتورة المبيعات";
            this.Load += new System.EventHandler(this.AddSillingBillSc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quntInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otherInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaidInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sillBillDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox userText;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.NumericUpDown quntInput;
        private System.Windows.Forms.NumericUpDown otherInput;
        private System.Windows.Forms.ComboBox prodText;
        private System.Windows.Forms.NumericUpDown PaidInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cutText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox noteText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox totalText;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox PiecePriceT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource sillBillDetailsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQunt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDis;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSubt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox paidTextDisplay;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox disTextDisplay;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox allTotalText;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.TextBox latText;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox totBeforText;
        private System.Windows.Forms.TextBox BillDisInput;
        private System.Windows.Forms.TextBox PieceDisInput;
    }
}