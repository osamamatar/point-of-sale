namespace FilterMangment.View
{
    partial class Clients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clients));
            this.TxtCustSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboCustGov = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtCustVallige = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtCustCenter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCustPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCustName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtCustBalance = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_clientscount = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtCustId = new System.Windows.Forms.TextBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.TxtCustScore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtCustNotes = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtCustSearch
            // 
            this.TxtCustSearch.Font = new System.Drawing.Font("Wide Latin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCustSearch.ForeColor = System.Drawing.Color.Black;
            this.TxtCustSearch.Location = new System.Drawing.Point(318, 33);
            this.TxtCustSearch.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCustSearch.Name = "TxtCustSearch";
            this.TxtCustSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtCustSearch.Size = new System.Drawing.Size(296, 36);
            this.TxtCustSearch.TabIndex = 1;
            this.TxtCustSearch.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Wide Latin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(375, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 34);
            this.label2.TabIndex = 17;
            this.label2.Text = "الرصيد";
            // 
            // ComboCustGov
            // 
            this.ComboCustGov.Font = new System.Drawing.Font("Wide Latin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboCustGov.FormattingEnabled = true;
            this.ComboCustGov.Items.AddRange(new object[] {
            "الفيوم ",
            "بني سويف",
            "القاهرة ",
            "الجيزة",
            "الاسكندرية",
            "الدقهلية",
            "الشرقية",
            "المنوفية",
            "القليوبية",
            "البحيرة",
            "الغربية",
            "بورسعيد",
            "دمياط",
            "الاسماعيلية",
            "السويس",
            "كفر الشيخ",
            "جبال السخنة ",
            "مطروح",
            "العلمين",
            "مطروح",
            "سيوة ",
            "شمال سيناء ",
            "وسط سيناء",
            "طور سيناء",
            "المنيا ",
            "اسيوط",
            "سوهاج",
            "قنا",
            "البحر الاحمر",
            "الاقصر",
            "أسوان",
            "الوحات",
            "الوادي الجديد",
            "توشكي",
            "",
            ""});
            this.ComboCustGov.Location = new System.Drawing.Point(444, 51);
            this.ComboCustGov.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboCustGov.Name = "ComboCustGov";
            this.ComboCustGov.Size = new System.Drawing.Size(121, 36);
            this.ComboCustGov.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Wide Latin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(117, 13);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 34);
            this.label8.TabIndex = 16;
            this.label8.Text = "عنوان تفصيلي";
            // 
            // TxtCustVallige
            // 
            this.TxtCustVallige.Font = new System.Drawing.Font("Wide Latin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCustVallige.ForeColor = System.Drawing.Color.Black;
            this.TxtCustVallige.Location = new System.Drawing.Point(60, 51);
            this.TxtCustVallige.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCustVallige.Name = "TxtCustVallige";
            this.TxtCustVallige.Size = new System.Drawing.Size(225, 36);
            this.TxtCustVallige.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Wide Latin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(350, 13);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 34);
            this.label7.TabIndex = 14;
            this.label7.Text = "المركز";
            // 
            // TxtCustCenter
            // 
            this.TxtCustCenter.Font = new System.Drawing.Font("Wide Latin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCustCenter.ForeColor = System.Drawing.Color.Black;
            this.TxtCustCenter.Location = new System.Drawing.Point(329, 51);
            this.TxtCustCenter.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCustCenter.Name = "TxtCustCenter";
            this.TxtCustCenter.Size = new System.Drawing.Size(99, 36);
            this.TxtCustCenter.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Wide Latin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(469, 13);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 34);
            this.label6.TabIndex = 12;
            this.label6.Text = "المحافظة";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Wide Latin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(381, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 34);
            this.label5.TabIndex = 8;
            this.label5.Text = "الهاتف";
            // 
            // TxtCustPhone
            // 
            this.TxtCustPhone.Font = new System.Drawing.Font("Wide Latin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCustPhone.ForeColor = System.Drawing.Color.Black;
            this.TxtCustPhone.Location = new System.Drawing.Point(43, 70);
            this.TxtCustPhone.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCustPhone.Name = "TxtCustPhone";
            this.TxtCustPhone.Size = new System.Drawing.Size(297, 36);
            this.TxtCustPhone.TabIndex = 6;
            this.TxtCustPhone.TextChanged += new System.EventHandler(this.txt_phone_TextChanged);
            this.TxtCustPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_balance_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(393, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "الاسم ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtCustName
            // 
            this.TxtCustName.Font = new System.Drawing.Font("Wide Latin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCustName.ForeColor = System.Drawing.Color.Black;
            this.TxtCustName.Location = new System.Drawing.Point(43, 23);
            this.TxtCustName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCustName.Name = "TxtCustName";
            this.TxtCustName.Size = new System.Drawing.Size(297, 36);
            this.TxtCustName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Wide Latin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(637, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 34);
            this.label3.TabIndex = 22;
            this.label3.Text = "بحث";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Wide Latin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(8, 108);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(1517, 522);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العملاء";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 34);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1488, 469);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.ComboCustGov);
            this.groupBox3.Controls.Add(this.TxtCustCenter);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.TxtCustVallige);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox3.Location = new System.Drawing.Point(446, 638);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(613, 95);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.TxtCustBalance);
            this.groupBox1.Controls.Add(this.TxtCustPhone);
            this.groupBox1.Controls.Add(this.TxtCustName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(1067, 638);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(458, 166);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            // 
            // TxtCustBalance
            // 
            this.TxtCustBalance.Font = new System.Drawing.Font("Wide Latin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCustBalance.ForeColor = System.Drawing.Color.Black;
            this.TxtCustBalance.Location = new System.Drawing.Point(43, 118);
            this.TxtCustBalance.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCustBalance.Name = "TxtCustBalance";
            this.TxtCustBalance.Size = new System.Drawing.Size(297, 36);
            this.TxtCustBalance.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Wide Latin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(105, 32);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(136, 34);
            this.label9.TabIndex = 48;
            this.label9.Text = "عدد العملاء :";
            // 
            // lbl_clientscount
            // 
            this.lbl_clientscount.AutoSize = true;
            this.lbl_clientscount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_clientscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_clientscount.ForeColor = System.Drawing.Color.White;
            this.lbl_clientscount.Location = new System.Drawing.Point(213, 6);
            this.lbl_clientscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_clientscount.Name = "lbl_clientscount";
            this.lbl_clientscount.Size = new System.Drawing.Size(0, 32);
            this.lbl_clientscount.TabIndex = 49;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Transparent;
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Wide Latin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.Image")));
            this.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnDelete.Location = new System.Drawing.Point(83, 13);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(102, 87);
            this.BtnDelete.TabIndex = 54;
            this.BtnDelete.Text = "حذف";
            this.BtnDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnDelete.UseVisualStyleBackColor = false;
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.Transparent;
            this.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEdit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnEdit.FlatAppearance.BorderSize = 0;
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.Font = new System.Drawing.Font("Wide Latin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.ForeColor = System.Drawing.Color.White;
            this.BtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.Image")));
            this.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEdit.Location = new System.Drawing.Point(220, 13);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(102, 87);
            this.BtnEdit.TabIndex = 53;
            this.BtnEdit.Text = "تعديل";
            this.BtnEdit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnEdit.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Wide Latin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(246, 36);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 34);
            this.label10.TabIndex = 52;
            this.label10.Text = "كود العميل";
            // 
            // TxtCustId
            // 
            this.TxtCustId.Font = new System.Drawing.Font("Wide Latin", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCustId.ForeColor = System.Drawing.Color.Red;
            this.TxtCustId.Location = new System.Drawing.Point(73, 33);
            this.TxtCustId.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCustId.Name = "TxtCustId";
            this.TxtCustId.ReadOnly = true;
            this.TxtCustId.Size = new System.Drawing.Size(140, 41);
            this.TxtCustId.TabIndex = 51;
            this.TxtCustId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Wide Latin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnClose.Location = new System.Drawing.Point(7, 15);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(206, 138);
            this.BtnClose.TabIndex = 48;
            this.BtnClose.Text = "خروج";
            this.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.Transparent;
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Wide Latin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnSave.Location = new System.Drawing.Point(219, 15);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(205, 143);
            this.BtnSave.TabIndex = 47;
            this.BtnSave.Text = "حفظ";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSave.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Gray;
            this.groupBox4.Controls.Add(this.BtnClose);
            this.groupBox4.Controls.Add(this.BtnSave);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox4.Location = new System.Drawing.Point(8, 639);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(431, 165);
            this.groupBox4.TabIndex = 55;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.TxtCustId);
            this.groupBox5.Location = new System.Drawing.Point(1130, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(395, 105);
            this.groupBox5.TabIndex = 56;
            this.groupBox5.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.BtnDelete);
            this.groupBox6.Controls.Add(this.BtnEdit);
            this.groupBox6.Location = new System.Drawing.Point(737, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(387, 105);
            this.groupBox6.TabIndex = 57;
            this.groupBox6.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lbl_clientscount);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.TxtCustSearch);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Location = new System.Drawing.Point(8, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(723, 105);
            this.groupBox7.TabIndex = 58;
            this.groupBox7.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.Transparent;
            this.groupBox8.Controls.Add(this.TxtCustScore);
            this.groupBox8.Controls.Add(this.label4);
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Controls.Add(this.TxtCustNotes);
            this.groupBox8.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox8.Location = new System.Drawing.Point(446, 741);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox8.Size = new System.Drawing.Size(613, 63);
            this.groupBox8.TabIndex = 59;
            this.groupBox8.TabStop = false;
            // 
            // TxtCustScore
            // 
            this.TxtCustScore.Font = new System.Drawing.Font("Wide Latin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCustScore.ForeColor = System.Drawing.Color.Black;
            this.TxtCustScore.Location = new System.Drawing.Point(420, 15);
            this.TxtCustScore.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCustScore.Name = "TxtCustScore";
            this.TxtCustScore.Size = new System.Drawing.Size(99, 36);
            this.TxtCustScore.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Wide Latin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(300, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 34);
            this.label4.TabIndex = 16;
            this.label4.Text = "ملاحظات";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Wide Latin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(527, 14);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 34);
            this.label11.TabIndex = 14;
            this.label11.Text = "التقييم";
            // 
            // TxtCustNotes
            // 
            this.TxtCustNotes.Font = new System.Drawing.Font("Wide Latin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCustNotes.ForeColor = System.Drawing.Color.Black;
            this.TxtCustNotes.Location = new System.Drawing.Point(8, 12);
            this.TxtCustNotes.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCustNotes.Multiline = true;
            this.TxtCustNotes.Name = "TxtCustNotes";
            this.TxtCustNotes.Size = new System.Drawing.Size(284, 44);
            this.TxtCustNotes.TabIndex = 5;
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1540, 814);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1558, 861);
            this.Name = "Clients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "العملاء";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Clients_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCustSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCustPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCustName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtCustCenter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtCustVallige;
        private System.Windows.Forms.ComboBox ComboCustGov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_clientscount;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox TxtCustId;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox TxtCustBalance;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox TxtCustScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtCustNotes;
    }
}